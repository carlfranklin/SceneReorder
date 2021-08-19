using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rootobject
{
    public Aux aux { get; set; }
    public Fxbus fxbus { get; set; }
    public Main main { get; set; }
    public Mono mono { get; set; }
    public Fx fx { get; set; }
    public Line line { get; set; }
    public Return _return { get; set; }
    public Fxreturn fxreturn { get; set; }
    public Talkback talkback { get; set; }
    public Geq geq { get; set; }
    public Mutegroup mutegroup { get; set; }
    public Filtergroup filtergroup { get; set; }
    public Mastersection mastersection { get; set; }
}

public class Aux
{
    public Ch1 ch1 { get; set; }
    public Ch2 ch2 { get; set; }
    public Ch3 ch3 { get; set; }
    public Ch4 ch4 { get; set; }
    public Ch5 ch5 { get; set; }
    public Ch6 ch6 { get; set; }
    public Ch7 ch7 { get; set; }
    public Ch8 ch8 { get; set; }
    public Ch9 ch9 { get; set; }
    public Ch10 ch10 { get; set; }
    public Ch11 ch11 { get; set; }
    public Ch12 ch12 { get; set; }
    public Ch13 ch13 { get; set; }
    public Ch14 ch14 { get; set; }
    public Ch15 ch15 { get; set; }
    public Ch16 ch16 { get; set; }
}

public class Channel
{
    public string username { get; set; }
    public long color { get; set; }
    public int memab { get; set; }
    public int solo { get; set; }
    public double volume { get; set; }
    public int mute { get; set; }
    public double pan { get; set; }
    public int stereopan { get; set; }
    public int linkmaster { get; set; }
    public string iconid { get; set; }
    public int lr { get; set; }
    public int mono { get; set; }
    public int sub1 { get; set; }
    public int sub2 { get; set; }
    public int sub3 { get; set; }
    public int sub4 { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double aux12_pan { get; set; }
    public double aux34_pan { get; set; }
    public double aux56_pan { get; set; }
    public double aux78_pan { get; set; }
    public double aux910_pan { get; set; }
    public double aux1112_pan { get; set; }
    public double aux1314_pan { get; set; }
    public double aux1516_pan { get; set; }
    public int aux12_stpan { get; set; }
    public int aux34_stpan { get; set; }
    public int aux56_stpan { get; set; }
    public int aux78_stpan { get; set; }
    public int aux910_stpan { get; set; }
    public int aux1112_stpan { get; set; }
    public int aux1314_stpan { get; set; }
    public int aux1516_stpan { get; set; }
    public int assign_aux1 { get; set; }
    public int assign_aux2 { get; set; }
    public int assign_aux3 { get; set; }
    public int assign_aux4 { get; set; }
    public int assign_aux5 { get; set; }
    public int assign_aux6 { get; set; }
    public int assign_aux7 { get; set; }
    public int assign_aux8 { get; set; }
    public int assign_aux9 { get; set; }
    public int assign_aux10 { get; set; }
    public int assign_aux11 { get; set; }
    public int assign_aux12 { get; set; }
    public int assign_aux13 { get; set; }
    public int assign_aux14 { get; set; }
    public int assign_aux15 { get; set; }
    public int assign_aux16 { get; set; }
    public double FXA { get; set; }
    public double FXB { get; set; }
    public double FXC { get; set; }
    public double FXD { get; set; }
    public int digitalin { get; set; }
    public int digitaloption { get; set; }
    public int prepost { get; set; }
    public int polarity { get; set; }
    public int scdetect { get; set; }
    public double preampgain { get; set; }
    public int assign_fx1 { get; set; }
    public int assign_fx2 { get; set; }
    public int assign_fx3 { get; set; }
    public int assign_fx4 { get; set; }

}

public class Ch1 : Channel
{
    public Gate gate { get; set; }
    public Comp comp { get; set; }
    public Limit limit { get; set; }
    public Eq eq { get; set; }
    public Filter filter { get; set; }
}

public class Ch2 : Channel
{
    public Gate1 gate { get; set; }
    public Comp1 comp { get; set; }
    public Limit1 limit { get; set; }
    public Eq1 eq { get; set; }
    public Filter1 filter { get; set; }
    public Altmem altmem { get; set; }
}
public class Ch3 : Channel
{
    public Gate3 gate { get; set; }
    public Comp3 comp { get; set; }
    public Limit3 limit { get; set; }
    public Eq3 eq { get; set; }
    public Filter3 filter { get; set; }
}
public class Ch4 : Channel
{
    public Gate4 gate { get; set; }
    public Comp4 comp { get; set; }
    public Limit4 limit { get; set; }
    public Eq4 eq { get; set; }
    public Filter4 filter { get; set; }
}
public class Ch5 : Channel
{
    public Gate5 gate { get; set; }
    public Comp5 comp { get; set; }
    public Limit5 limit { get; set; }
    public Eq5 eq { get; set; }
    public Filter5 filter { get; set; }
}
public class Ch6 : Channel
{
    public Gate6 gate { get; set; }
    public Comp6 comp { get; set; }
    public Limit6 limit { get; set; }
    public Eq6 eq { get; set; }
    public Filter6 filter { get; set; }
}
public class Ch7 : Channel
{
    public Gate7 gate { get; set; }
    public Comp7 comp { get; set; }
    public Limit7 limit { get; set; }
    public Eq7 eq { get; set; }
    public Filter7 filter { get; set; }
}
public class Ch8 : Channel
{
    public Gate8 gate { get; set; }
    public Comp8 comp { get; set; }
    public Limit8 limit { get; set; }
    public Eq8 eq { get; set; }
    public Filter8 filter { get; set; }
}
public class Ch9 : Channel
{
    public Gate9 gate { get; set; }
    public Comp9 comp { get; set; }
    public Limit9 limit { get; set; }
    public Eq9 eq { get; set; }
    public Filter9 filter { get; set; }
}
public class Ch10 : Channel
{
    public Gate10 gate { get; set; }
    public Comp10 comp { get; set; }
    public Limit10 limit { get; set; }
    public Eq10 eq { get; set; }
    public Filter10 filter { get; set; }
}
public class Ch11 : Channel
{
    public Gate11 gate { get; set; }
    public Comp11 comp { get; set; }
    public Limit11 limit { get; set; }
    public Eq11 eq { get; set; }
    public Filter11 filter { get; set; }
}
public class Ch12 : Channel
{
    public Gate12 gate { get; set; }
    public Comp12 comp { get; set; }
    public Limit12 limit { get; set; }
    public Eq12 eq { get; set; }
    public Filter12 filter { get; set; }
}
public class Ch13 : Channel
{
    public Gate13 gate { get; set; }
    public Comp13 comp { get; set; }
    public Limit13 limit { get; set; }
    public Eq13 eq { get; set; }
    public Filter13 filter { get; set; }
}
public class Ch14 : Channel
{
    public Gate14 gate { get; set; }
    public Comp14 comp { get; set; }
    public Limit14 limit { get; set; }
    public Eq14 eq { get; set; }
    public Filter14 filter { get; set; }
}
public class Ch15 : Channel
{
    public Gate15 gate { get; set; }
    public Comp15 comp { get; set; }
    public Limit15 limit { get; set; }
    public Eq15 eq { get; set; }
    public Filter15 filter { get; set; }
}
public class Ch16 : Channel
{
    public Gate16 gate { get; set; }
    public Comp16 comp { get; set; }
    public Limit16 limit { get; set; }
    public Eq16 eq { get; set; }
    public Filter16 filter { get; set; }
}
public class Ch17 : Channel
{
    public Gate17 gate { get; set; }
    public Comp17 comp { get; set; }
    public Limit17 limit { get; set; }
    public Eq17 eq { get; set; }
    public Filter17 filter { get; set; }
}
public class Ch18 : Channel
{
    public Gate18 gate { get; set; }
    public Comp18 comp { get; set; }
    public Limit18 limit { get; set; }
    public Eq18 eq { get; set; }
    public Filter18 filter { get; set; }
}
public class Ch19 : Channel
{
    public Gate19 gate { get; set; }
    public Comp19 comp { get; set; }
    public Limit19 limit { get; set; }
    public Eq19 eq { get; set; }
    public Filter19 filter { get; set; }
}
public class Ch20: Channel
{
    public Gate40 gate { get; set; }
    public Comp43 comp { get; set; }
    public Limit43 limit { get; set; }
    public Eq43 eq { get; set; }
    public Filter41 filter { get; set; }
    public Dca19 dca { get; set; }
}
public class Ch21 : Channel
{
    public Gate18 gate { get; set; }
    public Comp18 comp { get; set; }
    public Limit18 limit { get; set; }
    public Eq18 eq { get; set; }
    public Filter18 filter { get; set; }
}
public class Ch22 : Channel
{

}
public class Ch23 : Channel
{
    public Gate22 gate { get; set; }
    public Comp25 comp { get; set; }
    public Limit25 limit { get; set; }
    public Eq25 eq { get; set; }
    public Filter23 filter { get; set; }
    public Dca1 dca { get; set; }
}
public class Ch24 : Channel
{
    public Gate44 gate { get; set; }
    public Comp47 comp { get; set; }
    public Limit47 limit { get; set; }
    public Eq47 eq { get; set; }
    public Filter45 filter { get; set; }
    public Dca23 dca { get; set; }
}
public class Ch25 : Channel
{
    public Gate45 gate { get; set; }
    public Comp48 comp { get; set; }
    public Limit48 limit { get; set; }
    public Eq48 eq { get; set; }
    public Filter46 filter { get; set; }
    public Dca24 dca { get; set; }
}
public class Ch26 : Channel
{
    public Gate46 gate { get; set; }
    public Comp49 comp { get; set; }
    public Limit49 limit { get; set; }
    public Eq49 eq { get; set; }
    public Filter47 filter { get; set; }
    public Dca25 dca { get; set; }
}
public class Ch27 : Channel
{
    public Gate47 gate { get; set; }
    public Comp50 comp { get; set; }
    public Limit50 limit { get; set; }
    public Eq50 eq { get; set; }
    public Filter48 filter { get; set; }
    public Dca26 dca { get; set; }
}
public class Ch28 : Channel
{
    public Gate48 gate { get; set; }
    public Comp51 comp { get; set; }
    public Limit51 limit { get; set; }
    public Eq51 eq { get; set; }
    public Filter49 filter { get; set; }
    public Dca27 dca { get; set; }
}
public class Ch29 : Channel
{
    public Gate49 gate { get; set; }
    public Comp52 comp { get; set; }
    public Limit52 limit { get; set; }
    public Eq52 eq { get; set; }
    public Filter50 filter { get; set; }
    public Dca28 dca { get; set; }
}
public class Ch30 : Channel
{
    public Gate50 gate { get; set; }
    public Comp53 comp { get; set; }
    public Limit53 limit { get; set; }
    public Eq53 eq { get; set; }
    public Filter51 filter { get; set; }
    public Dca29 dca { get; set; }
}
public class Ch31 : Channel
{
    public Gate19 gate { get; set; }
    public Comp19 comp { get; set; }
    public Limit19 limit { get; set; }
    public Eq19 eq { get; set; }
    public Filter19 filter { get; set; }
}
public class Ch32 : Channel
{
}
public class Gate
{
    public int on { get; set; }
    public int keylisten { get; set; }
    public int expander { get; set; }
    public int keyfilter { get; set; }
    public int threshold { get; set; }
    public double range { get; set; }
    public double attack { get; set; }
    public double release { get; set; }
}

public class Comp
{
    public int on { get; set; }
    public int softknee { get; set; }
    public int automode { get; set; }
    public int threshold { get; set; }
    public int ratio { get; set; }
    public double attack { get; set; }
    public double release { get; set; }
    public int gain { get; set; }
}

public class Limit
{
    public double limiteron { get; set; }
    public double threshold { get; set; }
}

public class Eq
{
    public double eqallon { get; set; }
    public double eqgain1 { get; set; }
    public double eqq1 { get; set; }
    public double eqfreq1 { get; set; }
    public double eqbandon1 { get; set; }
    public double eqbandop1 { get; set; }
    public double eqgain2 { get; set; }
    public double eqq2 { get; set; }
    public double eqfreq2 { get; set; }
    public double eqbandon2 { get; set; }
    public double eqgain3 { get; set; }
    public double eqq3 { get; set; }
    public double eqfreq3 { get; set; }
    public double eqbandon3 { get; set; }
    public double eqgain4 { get; set; }
    public double eqq4 { get; set; }
    public double eqfreq4 { get; set; }
    public double eqbandon4 { get; set; }
    public double eqbandop4 { get; set; }
}

public class Filter
{
    public double hpf { get; set; }
}


public class Gate1 : Gate
{
}

public class Comp1 : Comp
{
}

public class Limit1 : Limit
{
}

public class Eq1 : Eq
{
}

public class Filter1 : Filter
{
}

public class Altmem
{
    public Gate2 gate { get; set; }
    public Comp2 comp { get; set; }
    public Limit2 limit { get; set; }
    public Eq2 eq { get; set; }
    public Filter2 filter { get; set; }
}

public class Gate2 : Gate
{
}

public class Comp2 : Comp
{
}

public class Limit2 : Limit
{
}

public class Eq2 : Eq
{
}

public class Filter2 : Filter
{
}

public class Gate3 : Gate
{

}

public class Comp3 : Comp
{
}

public class Limit3 : Limit
{
}

public class Eq3 : Eq
{
}

public class Filter3 : Filter
{
}


public class Gate4 : Gate
{
}

public class Comp4 : Comp
{
}

public class Limit4 : Limit
{
}

public class Eq4 : Eq
{
}

public class Filter4 : Filter
{
}

public class Gate5 : Gate
{
}

public class Comp5 : Comp
{
}

public class Limit5 : Limit
{
}

public class Eq5 : Eq
{
}

public class Filter5 : Filter
{
}

public class Gate6 : Gate
{
}

public class Comp6 : Comp
{
}

public class Limit6 : Limit
{
}

public class Eq6 : Eq
{
}

public class Filter6 : Filter
{
}

public class Gate7 : Gate
{
}

public class Comp7 : Comp
{
}

public class Limit7 : Limit
{
}

public class Eq7 : Eq
{
}

public class Filter7 : Filter
{
}

public class Gate8 : Gate
{
}

public class Comp8 : Comp
{
}

public class Limit8 : Limit
{
}

public class Eq8 : Eq
{
}

public class Filter8 : Filter
{
}

public class Gate9 : Gate
{
}

public class Comp9 : Comp
{
}

public class Limit9 : Limit
{
}

public class Eq9 : Eq
{
}

public class Filter9 : Filter
{
}

public class Gate10 : Gate
{
}

public class Comp10 : Comp
{
}

public class Limit10 : Limit
{
}

public class Eq10 : Eq
{
}

public class Filter10 : Filter
{
}

public class Gate11 : Gate
{
}

public class Comp11 : Comp
{
}

public class Limit11 : Limit
{
}

public class Eq11 : Eq
{
}

public class Filter11 : Filter
{
}

public class Gate12 : Gate
{
}

public class Comp12 : Comp
{
}

public class Limit12 : Comp
{
}

public class Eq12 : Eq
{
}

public class Filter12 : Filter
{
}
public class Gate13 : Gate
{
}

public class Comp13 : Comp
{
}

public class Limit13 : Limit
{
}

public class Eq13 : Eq
{
}

public class Filter13 : Filter
{
}

public class Gate14 : Gate
{
}

public class Comp14 : Comp
{

}

public class Limit14: Limit
{
}

public class Eq14: Eq
{
}

public class Filter14 : Filter
{
}

public class Gate15 : Gate
{
}

public class Comp15 : Comp
{
}

public class Limit15 : Limit
{
}

public class Eq15: Eq
{
}

public class Filter15 : Filter
{
}

public class Gate16 : Gate
{
}

public class Comp16 : Comp
{
}

public class Limit16 : Limit
{
}

public class Eq16 : Eq
{
}

public class Filter16 : Filter
{
}

public class Fxbus
{
    public Ch17 ch1 { get; set; }
    public Ch21 ch2 { get; set; }
    public Ch31 ch3 { get; set; }
    public Ch41 ch4 { get; set; }
}

public class Gate17 : Gate
{

}

public class Comp17 : Comp
{
}

public class Limit17 : Limit
{
}

public class Eq17 : Eq
{
}

public class Filter17 : Filter
{
}

public class Gate18 : Gate
{
}

public class Comp18 : Comp
{
}

public class Limit18 : Limit
{
}

public class Eq18 : Eq
{
}

public class Filter18 : Filter
{
}

public class Gate19 : Gate
{
}

public class Comp19 : Comp
{
}

public class Limit19 : Limit
{
}

public class Eq19 : Eq
{
}

public class Filter19 : Filter
{
}

public class Ch41 : Channel
{
}


public class Gate20 : Gate
{
}

public class Comp20 : Comp
{
}

public class Limit20 : Limit
{
}

public class Eq20 : Eq
{
}

public class Filter20 : Filter
{
}

public class Main
{
    public Ch18 ch1 { get; set; }
}

public class Comp21 : Comp
{
}

public class Limit21 : Limit
{
}

public class Eq21 : Eq
{
}

public class Altmem1
{
    public Comp22 comp { get; set; }
    public Limit22 limit { get; set; }
    public Eq22 eq { get; set; }
}

public class Comp22 : Comp
{
}

public class Limit22 : Limit
{
}

public class Eq22 : Eq
{
}

public class Mono
{
    public Ch19 ch1 { get; set; }
}

public class Comp23 : Comp
{
}

public class Limit23 : Limit
{
}

public class Eq23 : Eq
{
}

public class Filter21: Filter
{
}

public class Lpfilter
{
    public int lpf { get; set; }
}

public class Fx
{
    public Ch110 ch1 { get; set; }
    public Ch22 ch2 { get; set; }
    public Ch32 ch3 { get; set; }
    public Ch42 ch4 { get; set; }
}

public class Ch110 : Channel
{
}

public class Ch42 : Channel
{
}

public class Line
{
    public Ch111 ch1 { get; set; }
    public Ch23 ch2 { get; set; }
    public Ch33 ch3 { get; set; }
    public Ch43 ch4 { get; set; }
    public Ch51 ch5 { get; set; }
    public Ch61 ch6 { get; set; }
    public Ch71 ch7 { get; set; }
    public Ch81 ch8 { get; set; }
    public Ch91 ch9 { get; set; }
    public Ch101 ch10 { get; set; }
    public Ch112 ch11 { get; set; }
    public Ch121 ch12 { get; set; }
    public Ch131 ch13 { get; set; }
    public Ch141 ch14 { get; set; }
    public Ch151 ch15 { get; set; }
    public Ch161 ch16 { get; set; }
    public Ch171 ch17 { get; set; }
    public Ch181 ch18 { get; set; }
    public Ch191 ch19 { get; set; }
    public Ch20 ch20 { get; set; }
    public Ch211 ch21 { get; set; }
    public Ch221 ch22 { get; set; }
    public Ch231 ch23 { get; set; }
    public Ch24 ch24 { get; set; }
    public Ch25 ch25 { get; set; }
    public Ch26 ch26 { get; set; }
    public Ch27 ch27 { get; set; }
    public Ch28 ch28 { get; set; }
    public Ch29 ch29 { get; set; }
    public Ch30 ch30 { get; set; }
    public Ch311 ch31 { get; set; }
    public Ch321 ch32 { get; set; }
}

public class Ch111 : Channel
{
    public Gate21 gate { get; set; }
    public Comp24 comp { get; set; }
    public Limit24 limit { get; set; }
    public Eq24 eq { get; set; }
    public Filter22 filter { get; set; }
    public Dca dca { get; set; }
}

public class Gate21 : Gate
{
}

public class Comp24 : Comp
{
}

public class Limit24 : Limit
{
}

public class Eq24 : Eq
{
}

public class Filter22 : Filter
{ 
    public double hpf { get; set; }
}

public class Dca
{
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
}



public class Gate22 : Gate
{
}

public class Comp25 : Comp
{
}

public class Limit25 : Limit
{
}

public class Eq25 : Eq
{
}

public class Filter23 : Filter
{
}

public class Dca1 : Dca
{
}

public class Ch33 : Channel
{
    public Gate23 gate { get; set; }
    public Comp26 comp { get; set; }
    public Limit26 limit { get; set; }
    public Eq26 eq { get; set; }
    public Filter24 filter { get; set; }
    public Dca2 dca { get; set; }
}

public class Gate23 : Gate
{
}

public class Comp26 : Comp
{
}

public class Limit26 : Limit
{
}

public class Eq26 : Eq
{
}

public class Filter24 : Filter
{
}

public class Dca2 : Dca
{
}

public class Ch43 : Channel
{
    public Gate24 gate { get; set; }
    public Comp27 comp { get; set; }
    public Limit27 limit { get; set; }
    public Eq27 eq { get; set; }
    public Filter25 filter { get; set; }
    public Dca3 dca { get; set; }
}

public class Gate24 : Gate
{
}

public class Comp27 : Comp
{
}

public class Limit27 : Limit
{
}

public class Eq27 : Eq
{
}

public class Filter25 : Filter
{
}

public class Dca3 : Dca
{
}

public class Ch51 : Channel
{
    public Gate25 gate { get; set; }
    public Comp28 comp { get; set; }
    public Limit28 limit { get; set; }
    public Eq28 eq { get; set; }
    public Filter26 filter { get; set; }
    public Dca4 dca { get; set; }
}

public class Gate25 : Gate
{
}

public class Comp28 : Comp
{
}

public class Limit28 : Limit
{
}

public class Eq28 : Eq
{
}

public class Filter26 : Filter
{
}

public class Dca4 : Dca
{
}

public class Ch61 : Channel
{
    public Gate26 gate { get; set; }
    public Comp29 comp { get; set; }
    public Limit29 limit { get; set; }
    public Eq29 eq { get; set; }
    public Filter27 filter { get; set; }
    public Dca5 dca { get; set; }
}

public class Gate26 : Gate
{
}

public class Comp29 : Comp
{
}

public class Limit29: Limit
{
}

public class Eq29 : Eq
{
}

public class Filter27 : Filter
{
}

public class Dca5 : Dca
{
}

public class Ch71 : Channel
{
    public Gate27 gate { get; set; }
    public Comp30 comp { get; set; }
    public Limit30 limit { get; set; }
    public Eq30 eq { get; set; }
    public Filter28 filter { get; set; }
    public Dca6 dca { get; set; }
}

public class Gate27 : Gate
{
}

public class Comp30 : Comp
{
}

public class Limit30 : Limit
{
}

public class Eq30 : Eq
{
}

public class Filter28 : Filter
{
}

public class Dca6 : Dca
{
}

public class Ch81 : Channel
{
    public Gate28 gate { get; set; }
    public Comp31 comp { get; set; }
    public Limit31 limit { get; set; }
    public Eq31 eq { get; set; }
    public Filter29 filter { get; set; }
    public Dca7 dca { get; set; }
}

public class Gate28 : Gate
{

}

public class Comp31 : Comp
{
}

public class Limit31 : Limit
{
}

public class Eq31 : Eq
{
}

public class Filter29 : Filter
{
}

public class Dca7 : Dca
{
}

public class Ch91 : Channel
{
    public Gate29 gate { get; set; }
    public Comp32 comp { get; set; }
    public Limit32 limit { get; set; }
    public Eq32 eq { get; set; }
    public Filter30 filter { get; set; }
    public Dca8 dca { get; set; }
}

public class Gate29 : Gate
{
}

public class Comp32 : Comp
{
}

public class Limit32 : Limit
{
}

public class Eq32 : Eq
{
}

public class Filter30 : Filter
{
}

public class Dca8: Dca
{
}

public class Ch101 : Channel
{
    public Gate30 gate { get; set; }
    public Comp33 comp { get; set; }
    public Limit33 limit { get; set; }
    public Eq33 eq { get; set; }
    public Filter31 filter { get; set; }
    public Dca9 dca { get; set; }
}

public class Gate30 : Gate
{
}

public class Comp33 : Comp
{
}

public class Limit33: Limit
{
}

public class Eq33 : Eq
{
}

public class Filter31 : Filter
{
}

public class Dca9 : Dca
{
}

public class Ch112 : Channel
{
    public Gate31 gate { get; set; }
    public Comp34 comp { get; set; }
    public Limit34 limit { get; set; }
    public Eq34 eq { get; set; }
    public Filter32 filter { get; set; }
    public Dca10 dca { get; set; }
}

public class Gate31 : Gate
{
}

public class Comp34 : Comp
{
}

public class Limit34 : Limit
{
}

public class Eq34 : Eq
{
}

public class Filter32 : Filter
{
}

public class Dca10 : Dca
{
}

public class Ch121 : Channel
{
    public Gate32 gate { get; set; }
    public Comp35 comp { get; set; }
    public Limit35 limit { get; set; }
    public Eq35 eq { get; set; }
    public Filter33 filter { get; set; }
    public Dca11 dca { get; set; }
}

public class Gate32 : Gate
{
}

public class Comp35 : Comp
{
}

public class Limit35 : Limit
{
}

public class Eq35 : Eq
{
}

public class Filter33 : Filter
{
}

public class Dca11 : Dca
{
}

public class Ch131 : Channel
{
    public Gate33 gate { get; set; }
    public Comp36 comp { get; set; }
    public Limit36 limit { get; set; }
    public Eq36 eq { get; set; }
    public Filter34 filter { get; set; }
    public Dca12 dca { get; set; }
}

public class Gate33 : Gate
{
}

public class Comp36 : Comp
{
}

public class Limit36 : Limit
{
}

public class Eq36 : Eq
{
}

public class Filter34 : Filter
{
}

public class Dca12 : Dca
{
}

public class Ch141 : Channel
{
    public Gate34 gate { get; set; }
    public Comp37 comp { get; set; }
    public Limit37 limit { get; set; }
    public Eq37 eq { get; set; }
    public Filter35 filter { get; set; }
    public Dca13 dca { get; set; }
}

public class Gate34 : Gate
{
}

public class Comp37 : Comp
{
}

public class Limit37 : Limit
{
}

public class Eq37 : Eq
{
}

public class Filter35 : Filter
{
}

public class Dca13 : Dca
{
}

public class Ch151 : Channel
{
    public Gate35 gate { get; set; }
    public Comp38 comp { get; set; }
    public Limit38 limit { get; set; }
    public Eq38 eq { get; set; }
    public Filter36 filter { get; set; }
    public Dca14 dca { get; set; }
}

public class Gate35 : Gate
{
}

public class Comp38 : Comp
{
}

public class Limit38 : Limit
{
}

public class Eq38 : Eq
{
}

public class Filter36 : Filter
{
}

public class Dca14 : Dca
{
}

public class Ch161 : Channel
{
    public Gate36 gate { get; set; }
    public Comp39 comp { get; set; }
    public Limit39 limit { get; set; }
    public Eq39 eq { get; set; }
    public Filter37 filter { get; set; }
    public Dca15 dca { get; set; }
}

public class Gate36 : Gate
{
}

public class Comp39 : Comp
{
}

public class Limit39 : Limit
{
}

public class Eq39 : Eq
{
}

public class Filter37 : Filter
{
}

public class Dca15 : Dca
{
}

public class Ch171 : Channel
{
    public Gate37 gate { get; set; }
    public Comp40 comp { get; set; }
    public Limit40 limit { get; set; }
    public Eq40 eq { get; set; }
    public Filter38 filter { get; set; }
    public Dca16 dca { get; set; }
}

public class Gate37 : Gate
{
}

public class Comp40 : Comp
{
}

public class Limit40 : Limit
{
}

public class Eq40 : Eq
{
}

public class Filter38 : Filter
{
}

public class Dca16 : Dca
{
}

public class Ch181 : Channel
{
    public Gate38 gate { get; set; }
    public Comp41 comp { get; set; }
    public Limit41 limit { get; set; }
    public Eq41 eq { get; set; }
    public Filter39 filter { get; set; }
    public Dca17 dca { get; set; }
}

public class Gate38 : Gate
{
}

public class Comp41 : Comp
{
}

public class Limit41 : Limit
{
}

public class Eq41 : Eq
{
}

public class Filter39 : Filter
{
}

public class Dca17 : Dca
{
}

public class Ch191 : Channel
{
    public Gate39 gate { get; set; }
    public Comp42 comp { get; set; }
    public Limit42 limit { get; set; }
    public Eq42 eq { get; set; }
    public Filter40 filter { get; set; }
    public Dca18 dca { get; set; }
}

public class Gate39 : Gate
{
}

public class Comp42 : Comp
{
}

public class Limit42 : Limit
{
}

public class Eq42 : Eq
{
}

public class Filter40 : Filter
{
}

public class Dca18 : Dca
{
}

public class Gate40 : Gate
{
}

public class Comp43 : Comp
{
}

public class Limit43 : Limit
{
}

public class Eq43 : Eq
{
}

public class Filter41 : Filter
{
}

public class Dca19 : Dca
{
}

public class Ch211 : Channel
{
    public Gate41 gate { get; set; }
    public Comp44 comp { get; set; }
    public Limit44 limit { get; set; }
    public Eq44 eq { get; set; }
    public Filter42 filter { get; set; }
    public Dca20 dca { get; set; }
}

public class Gate41 : Gate
{
}

public class Comp44 : Comp
{
}

public class Limit44 : Limit
{
}

public class Eq44 : Eq
{
}

public class Filter42 : Filter
{
}

public class Dca20 : Dca
{
}

public class Ch221 : Channel
{
    public Gate42 gate { get; set; }
    public Comp45 comp { get; set; }
    public Limit45 limit { get; set; }
    public Eq45 eq { get; set; }
    public Filter43 filter { get; set; }
    public Dca21 dca { get; set; }
}

public class Gate42 : Gate
{
}

public class Comp45 : Comp
{
}

public class Limit45 : Limit
{
}

public class Eq45 : Eq
{
}

public class Filter43 : Filter
{
}

public class Dca21 : Dca
{
}

public class Ch231 : Channel
{
    public Gate43 gate { get; set; }
    public Comp46 comp { get; set; }
    public Limit46 limit { get; set; }
    public Eq46 eq { get; set; }
    public Filter44 filter { get; set; }
    public Dca22 dca { get; set; }
}

public class Gate43 : Gate
{
}

public class Comp46 : Comp
{
}

public class Limit46 : Limit
{
}

public class Eq46 : Eq
{
}

public class Filter44 : Filter
{
}

public class Dca22 : Dca
{
}


public class Gate44 : Gate
{
}

public class Comp47 : Comp
{
}

public class Limit47 : Limit
{
}

public class Eq47 : Eq
{
}

public class Filter45 : Filter
{
}

public class Dca23 : Dca
{
}

public class Gate45 : Gate
{
}

public class Comp48 : Comp
{
}

public class Limit48 : Limit
{
}

public class Eq48 : Eq
{
}

public class Filter46 : Filter
{
}

public class Dca24 : Dca
{
}

public class Gate46 : Gate
{
}
 
public class Comp49 : Comp
{
}

public class Limit49 : Limit
{
}

public class Eq49 : Eq
{
}

public class Filter47 : Filter
{
}

public class Dca25 : Dca
{
}

public class Gate47 : Gate
{
}

public class Comp50 : Comp
{
}

public class Limit50 : Limit
{
}
 
public class Eq50 : Eq
{
}

public class Filter48 : Filter
{
}

public class Dca26 : Dca
{
}

public class Gate48 : Gate
{
}

public class Comp51 : Comp
{
}

public class Limit51 : Limit
{
}

public class Eq51 : Eq
{
}

public class Filter49 : Filter
{
}

public class Dca27 : Dca
{
}

public class Gate49 : Gate
{
}

public class Comp52 : Comp
{
}

public class Limit52 : Limit
{
}

public class Eq52 : Eq
{
}

public class Filter50 : Filter
{
}

public class Dca28 : Dca
{
}

public class Gate50 : Gate
{
}

public class Comp53 : Comp
{
}

public class Limit53 : Limit
{
}
 
public class Eq53 : Eq
{
}

public class Filter51 : Filter
{
}

public class Dca29 : Dca
{
}

public class Ch311 : Channel
{
    public Gate51 gate { get; set; }
    public Comp54 comp { get; set; }
    public Limit54 limit { get; set; }
    public Eq54 eq { get; set; }
    public Filter52 filter { get; set; }
    public Dca30 dca { get; set; }
}

public class Gate51 : Gate
{
}

public class Comp54 : Comp
{
}

public class Limit54 : Limit
{
}

public class Eq54 : Eq
{
}

public class Filter52 : Filter
{
}

public class Dca30 : Dca
{
}

public class Ch321 : Channel
{
    public Gate52 gate { get; set; }
    public Comp55 comp { get; set; }
    public Limit55 limit { get; set; }
    public Eq55 eq { get; set; }
    public Filter53 filter { get; set; }
    public Dca31 dca { get; set; }
}

public class Gate52 : Gate
{
}

public class Comp55 : Comp
{
}

public class Limit55 : Limit
{
}

public class Eq55 : Eq
{
}

public class Filter53 : Filter
{
}

public class Dca31 : Dca
{
}

public class Return
{
    public Ch113 ch1 { get; set; }
    public Ch210 ch2 { get; set; }
}

public class Ch113 : Channel
{
    public Dca32 dca { get; set; }
}

public class Dca32 : Dca
{
}

public class Ch210 : Channel
{
    public Dca33 dca { get; set; }
}

public class Dca33 : Dca
{
}

public class Fxreturn
{
    public Ch114 ch1 { get; set; }
    public Ch212 ch2 { get; set; }
    public Ch34 ch3 { get; set; }
    public Ch44 ch4 { get; set; }
}

public class Ch114 : Channel
{
    public Dca34 dca { get; set; }
}

public class Dca34 : Dca
{
}

public class Ch212 : Channel
{
    public Dca35 dca { get; set; }
}

public class Dca35 : Dca
{
}

public class Ch34 : Channel
{
    public Dca36 dca { get; set; }
}

public class Dca36 : Dca
{
}

public class Ch44 : Channel
{
    public Dca37 dca { get; set; }
}

public class Dca37 : Dca
{
}

public class Talkback
{
    public Ch115 ch1 { get; set; }
}

public class Ch115 : Channel
{
}

public class Geq
{
    public Ch116 ch1 { get; set; }
    public Ch213 ch2 { get; set; }
    public Ch35 ch3 { get; set; }
    public Ch45 ch4 { get; set; }
    public Ch52 ch5 { get; set; }
    public Ch62 ch6 { get; set; }
    public Ch72 ch7 { get; set; }
    public Ch82 ch8 { get; set; }
    public Ch92 ch9 { get; set; }
    public Ch102 ch10 { get; set; }
    public Ch117 ch11 { get; set; }
    public Ch122 ch12 { get; set; }
    public Ch132 ch13 { get; set; }
    public Ch142 ch14 { get; set; }
    public Ch152 ch15 { get; set; }
}

public class Ch116 : Channel
{
}

public class Ch213 : Channel
{
}

public class Ch35 
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch45
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch52
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch62
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch72
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch82
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch92
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch102
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch117
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch122
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch132
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch142
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Ch152
{
    public int gain1 { get; set; }
    public int gain2 { get; set; }
    public int gain3 { get; set; }
    public int gain4 { get; set; }
    public int gain5 { get; set; }
    public int gain6 { get; set; }
    public int gain7 { get; set; }
    public int gain8 { get; set; }
    public int gain9 { get; set; }
    public int gain10 { get; set; }
    public int gain11 { get; set; }
    public int gain12 { get; set; }
    public int gain13 { get; set; }
    public int gain14 { get; set; }
    public int gain15 { get; set; }
    public int gain16 { get; set; }
    public int gain17 { get; set; }
    public int gain18 { get; set; }
    public int gain19 { get; set; }
    public int gain20 { get; set; }
    public int gain21 { get; set; }
    public int gain22 { get; set; }
    public int gain23 { get; set; }
    public int gain24 { get; set; }
    public int gain25 { get; set; }
    public int gain26 { get; set; }
    public int gain27 { get; set; }
    public int gain28 { get; set; }
    public int gain29 { get; set; }
    public int gain30 { get; set; }
    public int gain31 { get; set; }
    public int on { get; set; }
    public int ston { get; set; }
    public string name { get; set; }
    public int mem_ab { get; set; }
}

public class Mutegroup
{
    public int allon { get; set; }
}

public class Filtergroup
{
    public Ch118 ch1 { get; set; }
    public Ch214 ch2 { get; set; }
    public Ch36 ch3 { get; set; }
    public Ch46 ch4 { get; set; }
    public Ch53 ch5 { get; set; }
    public Ch63 ch6 { get; set; }
    public Ch73 ch7 { get; set; }
    public Ch83 ch8 { get; set; }
    public Ch93 ch9 { get; set; }
}

public class Ch118
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch214
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch36
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch46
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch53
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch63
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch73
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch83
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Ch93
{
    public string name { get; set; }
    public string iconid { get; set; }
    public double volume { get; set; }
    public double aux1 { get; set; }
    public double aux2 { get; set; }
    public double aux3 { get; set; }
    public double aux4 { get; set; }
    public double aux5 { get; set; }
    public double aux6 { get; set; }
    public double aux7 { get; set; }
    public double aux8 { get; set; }
    public double aux9 { get; set; }
    public double aux10 { get; set; }
    public double aux11 { get; set; }
    public double aux12 { get; set; }
    public double aux13 { get; set; }
    public double aux14 { get; set; }
    public double aux15 { get; set; }
    public double aux16 { get; set; }
    public double fx1 { get; set; }
    public double fx2 { get; set; }
    public double fx3 { get; set; }
    public double fx4 { get; set; }
    public int line1 { get; set; }
    public int line2 { get; set; }
    public int line3 { get; set; }
    public int line4 { get; set; }
    public int line5 { get; set; }
    public int line6 { get; set; }
    public int line7 { get; set; }
    public int line8 { get; set; }
    public int line9 { get; set; }
    public int line10 { get; set; }
    public int line11 { get; set; }
    public int line12 { get; set; }
    public int line13 { get; set; }
    public int line14 { get; set; }
    public int line15 { get; set; }
    public int line16 { get; set; }
    public int line17 { get; set; }
    public int line18 { get; set; }
    public int line19 { get; set; }
    public int line20 { get; set; }
    public int line21 { get; set; }
    public int line22 { get; set; }
    public int line23 { get; set; }
    public int line24 { get; set; }
    public int line25 { get; set; }
    public int line26 { get; set; }
    public int line27 { get; set; }
    public int line28 { get; set; }
    public int line29 { get; set; }
    public int line30 { get; set; }
    public int line31 { get; set; }
    public int line32 { get; set; }
    public int fxreturn1 { get; set; }
    public int fxreturn2 { get; set; }
    public int fxreturn3 { get; set; }
    public int fxreturn4 { get; set; }
    public int return1 { get; set; }
    public int return2 { get; set; }
    public int return3 { get; set; }
    public int return4 { get; set; }
}

public class Mastersection
{
    public int digroute1source { get; set; }
    public int digroute2source { get; set; }
    public int digroute3source { get; set; }
    public int digroute4source { get; set; }
    public int digroute5source { get; set; }
    public int digroute6source { get; set; }
    public int digroute7source { get; set; }
    public int digroute8source { get; set; }
    public int digroute9source { get; set; }
    public int digroute10source { get; set; }
    public int spdifsource { get; set; }
    public int soloPFL { get; set; }
    public int solostyle { get; set; }
    public int mon_tape { get; set; }
    public int mon_solo { get; set; }
    public int mon_main { get; set; }
    public int mon_d { get; set; }
    public int mon_aux { get; set; }
    public int mon_mono { get; set; }
    public int mon_selection { get; set; }
    public int mon_list { get; set; }
    public int remote_mon_list { get; set; }
    public int talk_1_2 { get; set; }
    public int talk_3_8 { get; set; }
    public int talk_9_14 { get; set; }
    public int talk_3_6 { get; set; }
    public int talk_7_10 { get; set; }
    public int talk_3_4 { get; set; }
    public int talk_5_6 { get; set; }
    public int talk_main { get; set; }
    public int talkpressed { get; set; }
    public int solo_level { get; set; }
    public double phones_level { get; set; }
    public int mon_level { get; set; }
}

