﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SceneReorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drop a .scene file right here.");
            var filename = Console.ReadLine();
            if (filename == "") return;
            if (filename.StartsWith("\""))
            {
                filename = filename.Substring(1, filename.Length - 2);
            }
            if (!File.Exists(filename))
            {
                Console.WriteLine("File Not Found");
                return;
            }
            var folder = Path.GetDirectoryName(filename);
            var outputFile = $"{folder}\\output.scene";

            var json = File.ReadAllText(filename);
            var scene = JsonConvert.DeserializeObject<Rootobject>(json);


            while(true)
            {
                Display(scene);

                Console.Write("Enter a channel # to swap, ENTER to quit: ");
                var firstCh = Console.ReadLine();
                if (firstCh == "")
                {
                    
                    var jsonOutput = JsonConvert.SerializeObject(scene, Formatting.Indented);
                    File.WriteAllText(outputFile, jsonOutput);
                    return;
                }
                Console.Write("Enter another channel # to swap it with: ");
                var secondCh = Console.ReadLine();

                var t = scene.line.GetType();
                var first = $"ch{firstCh}";
                var second = $"ch{secondCh}";
                var firstChannel = t.GetProperty(first);
                var secondChannel = t.GetProperty(second);
                var firstChannelObject = firstChannel.GetValue(scene.line);
                var secondChannelObject = secondChannel.GetValue(scene.line);
                var firstChannelProperties = firstChannel.PropertyType.GetProperties();
                var secondChannelProperties = secondChannel.PropertyType.GetProperties();
                for (int i = 0; i < firstChannelProperties.Length; i++)
                {
                    var firstChProp = firstChannelProperties[i];
                    var secondChProp = secondChannelProperties[i];
                    var firstValue = firstChProp.GetValue(firstChannelObject);
                    var secondValue = secondChProp.GetValue(secondChannelObject);
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

        static void Display(Rootobject scene)
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
            
        }
    }
    
}