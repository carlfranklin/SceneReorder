using Newtonsoft.Json;
using System;
using System.IO;
using MyNewClasses;

namespace SceneReorder
{
    class Program
    {
        static bool IsNumeric(string value) => double.TryParse(value, out _);

        static void Main(string[] args)
        {
            Console.WriteLine("Drop a .scene file right here.");
            var filename = Console.ReadLine();
            if (filename == "") return;
            if (filename.StartsWith("\""))
            {
                filename = filename.Substring(1, filename.Length - 2);
            }
            //string filename = @"F:\Documents\PreSonus\StudioLive AI\Library\Presets\Scene\test.scene";

            if (!File.Exists(filename))
            {
                Console.WriteLine("File Not Found");
                return;
            }
            var folder = Path.GetDirectoryName(filename);
            var outputFile = $"{folder}\\output.scene";

            var json = File.ReadAllText(filename);

            var scene = JsonConvert.DeserializeObject<Rootobject>(json);
            var t = scene.line.GetType();

            while (true)
            {
                string firstCh = "";
                string secondCh = "";
                var key = Display(scene);

                if (key.Key == ConsoleKey.Escape)   // SAVE and QUIT
                {
                    var jsonOutput = JsonConvert.SerializeObject(scene, Formatting.Indented);
                    File.WriteAllText(outputFile, jsonOutput);
                    return;
                }
                else if (key.Key == ConsoleKey.C)   // COPY CHANNEL SETTINGS
                {
                    Console.Write("Enter SOURCE channel (1-32): ");
                    firstCh = Console.ReadLine();
                    if (IsNumeric(firstCh))
                    {
                        Console.Write("Enter TARGET channel (1-32): ");
                        secondCh = Console.ReadLine();
                        if (IsNumeric(secondCh))
                        {
                            Console.Write("Choose Setting: [P]reamp, [F]ilter, [G]ate, [C]omp, [E]q, [L]imiter, [D]CA: ");
                            var settingKey = Console.ReadKey();
                            Console.WriteLine();
                            if (settingKey.Key == ConsoleKey.P
                                || settingKey.Key == ConsoleKey.F
                                || settingKey.Key == ConsoleKey.G
                                || settingKey.Key == ConsoleKey.C
                                || settingKey.Key == ConsoleKey.E
                                || settingKey.Key == ConsoleKey.L
                                || settingKey.Key == ConsoleKey.D)
                            {
                                // line property names
                                var first = $"ch{firstCh}";
                                var second = $"ch{secondCh}";

                                // PropertyInfo objects
                                var firstChannelLineProperty = t.GetProperty(first);
                                var secondChannelLineProperty = t.GetProperty(second);

                                // Channel objects
                                var firstChannelObject = firstChannelLineProperty.GetValue(scene.line);
                                var secondChannelObject = secondChannelLineProperty.GetValue(scene.line);

                                if (settingKey.Key == ConsoleKey.P)
                                {
                                    // Preamp
                                    var propSource = firstChannelLineProperty.PropertyType.GetProperty("preampgain");
                                    var propDest = secondChannelLineProperty.PropertyType.GetProperty("preampgain");
                                    var sourceValue = propSource.GetValue(firstChannelObject);
                                    propDest.SetValue(secondChannelObject, sourceValue);
                                }

                                else
                                {
                                    var firstChannelObjectProperties = firstChannelLineProperty.PropertyType.GetProperties();
                                    var secondChannelObjectProperties = secondChannelLineProperty.PropertyType.GetProperties();

                                    for (int i = 0; i < firstChannelObjectProperties.Length; i++)
                                    {
                                        // Get next PropertyInfo from the Channel objects
                                        var firstChProp = firstChannelObjectProperties[i];
                                        var secondChProp = secondChannelObjectProperties[i];

                                        // Get the value of these properties
                                        var firstValue = firstChProp.GetValue(firstChannelObject);
                                        var secondValue = secondChProp.GetValue(secondChannelObject);

                                        if (firstValue != null && secondValue != null)
                                        {
                                            if (firstChProp.Name.ToLower().StartsWith("gate") && settingKey.Key == ConsoleKey.G)
                                            {
                                                var firstGateProperties = firstChProp.PropertyType.GetProperties();
                                                var secondGateProperties = secondChProp.PropertyType.GetProperties();
                                                for (int g = 0; g < firstGateProperties.Length; g++)
                                                {
                                                    var firstGateProp = firstGateProperties[g];
                                                    var secondGateProp = secondGateProperties[g];
                                                    var firstGateValue = firstGateProp.GetValue(firstValue);
                                                    //var secondGateValue = secondGateProp.GetValue(secondValue);
                                                    secondGateProp.SetValue(secondValue, firstGateValue);
                                                    //firstGateProp.SetValue(firstValue, secondGateValue);
                                                }
                                            }
                                            else if (firstChProp.Name.ToLower().StartsWith("comp") && settingKey.Key == ConsoleKey.C)
                                            {
                                                var firstCompProperties = firstChProp.PropertyType.GetProperties();
                                                var secondCompProperties = secondChProp.PropertyType.GetProperties();
                                                for (int g = 0; g < firstCompProperties.Length; g++)
                                                {
                                                    var firstCompProp = firstCompProperties[g];
                                                    var secondCompProp = secondCompProperties[g];
                                                    var firstCompValue = firstCompProp.GetValue(firstValue);
                                                    //var secondCompValue = secondCompProp.GetValue(secondValue);
                                                    secondCompProp.SetValue(secondValue, firstCompValue);
                                                    //firstCompProp.SetValue(firstValue, secondCompValue);
                                                }
                                            }
                                            else if (firstChProp.Name.ToLower().StartsWith("limit") && settingKey.Key == ConsoleKey.L)
                                            {
                                                var firstLimitProperties = firstChProp.PropertyType.GetProperties();
                                                var secondLimitProperties = secondChProp.PropertyType.GetProperties();
                                                for (int g = 0; g < firstLimitProperties.Length; g++)
                                                {
                                                    var firstLimitProp = firstLimitProperties[g];
                                                    var secondLimitProp = secondLimitProperties[g];
                                                    var firstLimitValue = firstLimitProp.GetValue(firstValue);
                                                    //var secondLimitValue = secondLimitProp.GetValue(secondValue);
                                                    secondLimitProp.SetValue(secondValue, firstLimitValue);
                                                    //firstLimitProp.SetValue(firstValue, secondLimitValue);
                                                }
                                            }
                                            else if (firstChProp.Name.ToLower().StartsWith("eq") && settingKey.Key == ConsoleKey.E)
                                            {
                                                var firstEqProperties = firstChProp.PropertyType.GetProperties();
                                                var secondEqProperties = secondChProp.PropertyType.GetProperties();
                                                for (int g = 0; g < firstEqProperties.Length; g++)
                                                {
                                                    var firstEqProp = firstEqProperties[g];
                                                    var secondEqProp = secondEqProperties[g];
                                                    var firstEqValue = firstEqProp.GetValue(firstValue);
                                                    //var secondEqValue = secondEqProp.GetValue(secondValue);
                                                    secondEqProp.SetValue(secondValue, firstEqValue);
                                                    //firstEqProp.SetValue(firstValue, secondEqValue);
                                                }
                                            }
                                            else if (firstChProp.Name.ToLower().StartsWith("filter") && settingKey.Key == ConsoleKey.F)
                                            {
                                                var firstFilterProperties = firstChProp.PropertyType.GetProperties();
                                                var secondFilterProperties = secondChProp.PropertyType.GetProperties();
                                                for (int g = 0; g < firstFilterProperties.Length; g++)
                                                {
                                                    var firstFilterProp = firstFilterProperties[g];
                                                    var secondFilterProp = secondFilterProperties[g];
                                                    var firstFilterValue = firstFilterProp.GetValue(firstValue);
                                                    //var secondFilterValue = secondFilterProp.GetValue(secondValue);
                                                    secondFilterProp.SetValue(secondValue, firstFilterValue);
                                                    //firstFilterProp.SetValue(firstValue, secondFilterValue);
                                                }
                                            }
                                            else if (firstChProp.Name.ToLower().StartsWith("dca") && settingKey.Key == ConsoleKey.D)
                                            {
                                                var firstDcaProperties = firstChProp.PropertyType.GetProperties();
                                                var secondDcaProperties = secondChProp.PropertyType.GetProperties();
                                                for (int g = 0; g < firstDcaProperties.Length; g++)
                                                {
                                                    var firstDcaProp = firstDcaProperties[g];
                                                    var secondDcaProp = secondDcaProperties[g];
                                                    var firstDcaValue = firstDcaProp.GetValue(firstValue);
                                                    //var secondDcaValue = secondDcaProp.GetValue(secondValue);
                                                    secondDcaProp.SetValue(secondValue, firstDcaValue);
                                                    //firstDcaProp.SetValue(firstValue, secondDcaValue);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (key.Key == ConsoleKey.R)   // RESET
                {
                    Console.Write("Enter channel # to reset: ");
                    var startCh = Console.ReadLine();
                    if (IsNumeric(startCh))
                    {
                        int ch = Convert.ToInt32(startCh);
                        var cleanup = $"ch{ch}";
                        var ChannelLineProperty = t.GetProperty(cleanup);
                        var ChannelObject = (Channel)ChannelLineProperty.GetValue(scene.line);
                        Console.Write($"Enter new Channel Name (ENTER for Ch. {ch}): ");
                        var username = Console.ReadLine();
                        if (username == "")
                            username = $"Ch. {ch}";
                        ChannelObject.username = username;
                        ChannelObject.iconid = "";
                        ChannelObject.volume = 0;
                        ChannelObject.mute = 1;
                        ChannelObject.solo = 0;
                    }
                }
                else if (key.Key == ConsoleKey.S)   // SWAP
                {
                    Console.Write("Enter first channel to swap (1-32): ");
                    firstCh = Console.ReadLine();
                    if (IsNumeric(firstCh))
                    {
                        Console.Write("Enter another channel # to swap it with: ");
                        secondCh = Console.ReadLine();
                        if (IsNumeric(secondCh))
                        {
                            // line property names
                            var first = $"ch{firstCh}";
                            var second = $"ch{secondCh}";

                            // PropertyInfo objects
                            var firstChannelLineProperty = t.GetProperty(first);
                            var secondChannelLineProperty = t.GetProperty(second);

                            // Channel objects
                            var firstChannelObject = firstChannelLineProperty.GetValue(scene.line);
                            var secondChannelObject = secondChannelLineProperty.GetValue(scene.line);

                            // Channel object properties (array of PropertyInfo)
                            var firstChannelObjectProperties = firstChannelLineProperty.PropertyType.GetProperties();
                            var secondChannelObjectProperties = secondChannelLineProperty.PropertyType.GetProperties();

                            for (int i = 0; i < firstChannelObjectProperties.Length; i++)
                            {
                                // Get next PropertyInfo from the Channel objects
                                var firstChProp = firstChannelObjectProperties[i];
                                var secondChProp = secondChannelObjectProperties[i];

                                // Get the value of these properties
                                var firstValue = firstChProp.GetValue(firstChannelObject);
                                var secondValue = secondChProp.GetValue(secondChannelObject);

                                if (firstValue != null && secondValue != null)
                                {
                                    if (firstChProp.Name.ToLower().StartsWith("gate"))
                                    {
                                        var firstGateProperties = firstChProp.PropertyType.GetProperties();
                                        var secondGateProperties = secondChProp.PropertyType.GetProperties();
                                        for (int g = 0; g < firstGateProperties.Length; g++)
                                        {
                                            var firstGateProp = firstGateProperties[g];
                                            var secondGateProp = secondGateProperties[g];
                                            var firstGateValue = firstGateProp.GetValue(firstValue);
                                            var secondGateValue = secondGateProp.GetValue(secondValue);
                                            secondGateProp.SetValue(secondValue, firstGateValue);
                                            firstGateProp.SetValue(firstValue, secondGateValue);
                                        }
                                    }
                                    else if (firstChProp.Name.ToLower().StartsWith("comp"))
                                    {
                                        var firstCompProperties = firstChProp.PropertyType.GetProperties();
                                        var secondCompProperties = secondChProp.PropertyType.GetProperties();
                                        for (int g = 0; g < firstCompProperties.Length; g++)
                                        {
                                            var firstCompProp = firstCompProperties[g];
                                            var secondCompProp = secondCompProperties[g];
                                            var firstCompValue = firstCompProp.GetValue(firstValue);
                                            var secondCompValue = secondCompProp.GetValue(secondValue);
                                            secondCompProp.SetValue(secondValue, firstCompValue);
                                            firstCompProp.SetValue(firstValue, secondCompValue);
                                        }
                                    }
                                    else if (firstChProp.Name.ToLower().StartsWith("limit"))
                                    {
                                        var firstLimitProperties = firstChProp.PropertyType.GetProperties();
                                        var secondLimitProperties = secondChProp.PropertyType.GetProperties();
                                        for (int g = 0; g < firstLimitProperties.Length; g++)
                                        {
                                            var firstLimitProp = firstLimitProperties[g];
                                            var secondLimitProp = secondLimitProperties[g];
                                            var firstLimitValue = firstLimitProp.GetValue(firstValue);
                                            var secondLimitValue = secondLimitProp.GetValue(secondValue);
                                            secondLimitProp.SetValue(secondValue, firstLimitValue);
                                            firstLimitProp.SetValue(firstValue, secondLimitValue);
                                        }
                                    }
                                    else if (firstChProp.Name.ToLower().StartsWith("eq"))
                                    {
                                        var firstEqProperties = firstChProp.PropertyType.GetProperties();
                                        var secondEqProperties = secondChProp.PropertyType.GetProperties();
                                        for (int g = 0; g < firstEqProperties.Length; g++)
                                        {
                                            var firstEqProp = firstEqProperties[g];
                                            var secondEqProp = secondEqProperties[g];
                                            var firstEqValue = firstEqProp.GetValue(firstValue);
                                            var secondEqValue = secondEqProp.GetValue(secondValue);
                                            secondEqProp.SetValue(secondValue, firstEqValue);
                                            firstEqProp.SetValue(firstValue, secondEqValue);
                                        }
                                    }
                                    else if (firstChProp.Name.ToLower().StartsWith("filter"))
                                    {
                                        var firstFilterProperties = firstChProp.PropertyType.GetProperties();
                                        var secondFilterProperties = secondChProp.PropertyType.GetProperties();
                                        for (int g = 0; g < firstFilterProperties.Length; g++)
                                        {
                                            var firstFilterProp = firstFilterProperties[g];
                                            var secondFilterProp = secondFilterProperties[g];
                                            var firstFilterValue = firstFilterProp.GetValue(firstValue);
                                            var secondFilterValue = secondFilterProp.GetValue(secondValue);
                                            secondFilterProp.SetValue(secondValue, firstFilterValue);
                                            firstFilterProp.SetValue(firstValue, secondFilterValue);
                                        }
                                    }
                                    else if (firstChProp.Name.ToLower().StartsWith("dca"))
                                    {
                                        var firstDcaProperties = firstChProp.PropertyType.GetProperties();
                                        var secondDcaProperties = secondChProp.PropertyType.GetProperties();
                                        for (int g = 0; g < firstDcaProperties.Length; g++)
                                        {
                                            var firstDcaProp = firstDcaProperties[g];
                                            var secondDcaProp = secondDcaProperties[g];
                                            var firstDcaValue = firstDcaProp.GetValue(firstValue);
                                            var secondDcaValue = secondDcaProp.GetValue(secondValue);
                                            secondDcaProp.SetValue(secondValue, firstDcaValue);
                                            firstDcaProp.SetValue(firstValue, secondDcaValue);
                                        }
                                    }
                                    else
                                    {
                                        secondChProp.SetValue(secondChannelObject, firstValue);
                                        firstChProp.SetValue(firstChannelObject, secondValue);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            static ConsoleKeyInfo Display(Rootobject scene)
            {
                Console.WriteLine("CH 1: " + scene.line.ch1.username);
                Console.WriteLine("CH 2: " + scene.line.ch2.username);
                Console.WriteLine("CH 3: " + scene.line.ch3.username);
                Console.WriteLine("CH 4: " + scene.line.ch4.username);
                Console.WriteLine("CH 5: " + scene.line.ch5.username);
                Console.WriteLine("CH 6: " + scene.line.ch6.username);
                Console.WriteLine("CH 7: " + scene.line.ch7.username);
                Console.WriteLine("CH 8: " + scene.line.ch8.username);
                Console.WriteLine("CH 9: " + scene.line.ch9.username);
                Console.WriteLine("CH 10: " + scene.line.ch10.username);
                Console.WriteLine("CH 11: " + scene.line.ch11.username);
                Console.WriteLine("CH 12: " + scene.line.ch12.username);
                Console.WriteLine("CH 13: " + scene.line.ch13.username);
                Console.WriteLine("CH 14: " + scene.line.ch14.username);
                Console.WriteLine("CH 15: " + scene.line.ch15.username);
                Console.WriteLine("CH 16: " + scene.line.ch16.username);
                Console.WriteLine("CH 17: " + scene.line.ch17.username);
                Console.WriteLine("CH 18: " + scene.line.ch18.username);
                Console.WriteLine("CH 19: " + scene.line.ch19.username);
                Console.WriteLine("CH 20: " + scene.line.ch20.username);
                Console.WriteLine("CH 21: " + scene.line.ch21.username);
                Console.WriteLine("CH 22: " + scene.line.ch22.username);
                Console.WriteLine("CH 23: " + scene.line.ch23.username);
                Console.WriteLine("CH 24: " + scene.line.ch24.username);
                Console.WriteLine("CH 25: " + scene.line.ch25.username);
                Console.WriteLine("CH 26: " + scene.line.ch26.username);
                Console.WriteLine("CH 27: " + scene.line.ch27.username);
                Console.WriteLine("CH 28: " + scene.line.ch28.username);
                Console.WriteLine("CH 29: " + scene.line.ch29.username);
                Console.WriteLine("CH 30: " + scene.line.ch30.username);
                Console.WriteLine("CH 31: " + scene.line.ch31.username);
                Console.WriteLine("CH 32: " + scene.line.ch32.username);
                Console.WriteLine();
                Console.Write("Select: [S]wap channels, [C]opy channel settings, [R]eset channel, or ESC to save & quit: ");
                var key = Console.ReadKey();
                Console.WriteLine();
                return key;
            }
        }
    }
}