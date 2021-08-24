using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foo
{

    public class Rootobject
    {
        public string preset_name { get; set; }
        public Mutegroup mutegroup { get; set; }
        public Network network { get; set; }
        public Fx fx { get; set; }
        public Line line { get; set; }
        public Return _return { get; set; }
        public Talkback talkback { get; set; }
        public Uipreview uipreview { get; set; }
        public Aux aux { get; set; }
        public Fxbus fxbus { get; set; }
        public Fxreturn fxreturn { get; set; }
        public Mono mono { get; set; }
        public Main main { get; set; }
        public Geq geq { get; set; }
        public Filtergroup filtergroup { get; set; }
        public Mixersettings mixersettings { get; set; }
        public Fatchannelpages FatChannelPages { get; set; }
    }

    public class Mutegroup
    {
        public int allon { get; set; }
        public string mutegroup1username { get; set; }
        public string mutegroup2username { get; set; }
        public string mutegroup3username { get; set; }
        public string mutegroup4username { get; set; }
        public string mutegroup5username { get; set; }
        public string mutegroup6username { get; set; }
        public string mutegroup7username { get; set; }
        public string mutegroup8username { get; set; }
    }

    public class Network
    {
        public int eth0_cur_asn_mode { get; set; }
        public string eth0_req_ip { get; set; }
        public string eth0_subnet { get; set; }
        public string eth0_gateway { get; set; }
    }

    public class Fx
    {
        public Ch1 ch1 { get; set; }
        public Ch2 ch2 { get; set; }
        public Ch3 ch3 { get; set; }
        public Ch4 ch4 { get; set; }
    }

    public class Ch1
    {
        public int loaded_num { get; set; }
        public int loaded_type { get; set; }
        public float param0_val { get; set; }
        public float param1_val { get; set; }
        public float param2_val { get; set; }
        public float param3_val { get; set; }
        public float param4_val { get; set; }
        public float param5_val { get; set; }
    }

    public class Ch2
    {
        public int loaded_num { get; set; }
        public int loaded_type { get; set; }
        public float param0_val { get; set; }
        public float param1_val { get; set; }
        public float param2_val { get; set; }
        public float param3_val { get; set; }
        public float param4_val { get; set; }
        public float param5_val { get; set; }
    }

    public class Ch3
    {
        public int loaded_num { get; set; }
        public int loaded_type { get; set; }
        public float param0_val { get; set; }
        public float param1_val { get; set; }
        public float param2_val { get; set; }
        public float param3_val { get; set; }
        public float param4_val { get; set; }
        public float param5_val { get; set; }
    }

    public class Ch4
    {
        public int loaded_num { get; set; }
        public int loaded_type { get; set; }
        public float param0_val { get; set; }
        public float param1_val { get; set; }
        public float param2_val { get; set; }
        public float param3_val { get; set; }
        public float param4_val { get; set; }
        public float param5_val { get; set; }
    }

    public class Line
    {
        public Ch11 ch1 { get; set; }
        public Ch21 ch2 { get; set; }
        public Ch31 ch3 { get; set; }
        public Ch41 ch4 { get; set; }
        public Ch5 ch5 { get; set; }
        public Ch6 ch6 { get; set; }
        public Ch7 ch7 { get; set; }
        public Ch8 ch8 { get; set; }
        public Ch9 ch9 { get; set; }
        public Ch10 ch10 { get; set; }
        public Ch111 ch11 { get; set; }
        public Ch12 ch12 { get; set; }
        public Ch13 ch13 { get; set; }
        public Ch14 ch14 { get; set; }
        public Ch15 ch15 { get; set; }
        public Ch16 ch16 { get; set; }
        public Ch17 ch17 { get; set; }
        public Ch18 ch18 { get; set; }
        public Ch19 ch19 { get; set; }
        public Ch20 ch20 { get; set; }
        public Ch211 ch21 { get; set; }
        public Ch22 ch22 { get; set; }
        public Ch23 ch23 { get; set; }
        public Ch24 ch24 { get; set; }
        public Ch25 ch25 { get; set; }
        public Ch26 ch26 { get; set; }
        public Ch27 ch27 { get; set; }
        public Ch28 ch28 { get; set; }
        public Ch29 ch29 { get; set; }
        public Ch30 ch30 { get; set; }
        public Ch311 ch31 { get; set; }
        public Ch32 ch32 { get; set; }
    }

    public class Ch11
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter filter { get; set; }
        public Gate gate { get; set; }
        public Comp comp { get; set; }
        public Eq eq { get; set; }
        public Limit limit { get; set; }
    }

    public class Filter
    {
        public float hpf { get; set; }
    }

    public class Gate
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch21
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter1 filter { get; set; }
        public Gate1 gate { get; set; }
        public Comp1 comp { get; set; }
        public Eq1 eq { get; set; }
        public Limit1 limit { get; set; }
    }

    public class Filter1
    {
        public float hpf { get; set; }
    }

    public class Gate1
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp1
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq1
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit1
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch31
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter2 filter { get; set; }
        public Gate2 gate { get; set; }
        public Comp2 comp { get; set; }
        public Eq2 eq { get; set; }
        public Limit2 limit { get; set; }
    }

    public class Filter2
    {
        public float hpf { get; set; }
    }

    public class Gate2
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp2
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq2
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit2
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch41
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter3 filter { get; set; }
        public Gate3 gate { get; set; }
        public Comp3 comp { get; set; }
        public Eq3 eq { get; set; }
        public Limit3 limit { get; set; }
    }

    public class Filter3
    {
        public float hpf { get; set; }
    }

    public class Gate3
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp3
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq3
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit3
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch5
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter4 filter { get; set; }
        public Gate4 gate { get; set; }
        public Comp4 comp { get; set; }
        public Eq4 eq { get; set; }
        public Limit4 limit { get; set; }
    }

    public class Filter4
    {
        public float hpf { get; set; }
    }

    public class Gate4
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp4
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq4
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit4
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch6
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter5 filter { get; set; }
        public Gate5 gate { get; set; }
        public Comp5 comp { get; set; }
        public Eq5 eq { get; set; }
        public Limit5 limit { get; set; }
    }

    public class Filter5
    {
        public float hpf { get; set; }
    }

    public class Gate5
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp5
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq5
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit5
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch7
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter6 filter { get; set; }
        public Gate6 gate { get; set; }
        public Comp6 comp { get; set; }
        public Eq6 eq { get; set; }
        public Limit6 limit { get; set; }
    }

    public class Filter6
    {
        public float hpf { get; set; }
    }

    public class Gate6
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp6
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq6
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit6
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch8
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter7 filter { get; set; }
        public Gate7 gate { get; set; }
        public Comp7 comp { get; set; }
        public Eq7 eq { get; set; }
        public Limit7 limit { get; set; }
    }

    public class Filter7
    {
        public float hpf { get; set; }
    }

    public class Gate7
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp7
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq7
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit7
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch9
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter8 filter { get; set; }
        public Gate8 gate { get; set; }
        public Comp8 comp { get; set; }
        public Eq8 eq { get; set; }
        public Limit8 limit { get; set; }
    }

    public class Filter8
    {
        public float hpf { get; set; }
    }

    public class Gate8
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp8
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq8
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit8
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch10
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter9 filter { get; set; }
        public Gate9 gate { get; set; }
        public Comp9 comp { get; set; }
        public Eq9 eq { get; set; }
        public Limit9 limit { get; set; }
    }

    public class Filter9
    {
        public float hpf { get; set; }
    }

    public class Gate9
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp9
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq9
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit9
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch111
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter10 filter { get; set; }
        public Gate10 gate { get; set; }
        public Comp10 comp { get; set; }
        public Eq10 eq { get; set; }
        public Limit10 limit { get; set; }
    }

    public class Filter10
    {
        public float hpf { get; set; }
    }

    public class Gate10
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp10
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq10
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit10
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch12
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter11 filter { get; set; }
        public Gate11 gate { get; set; }
        public Comp11 comp { get; set; }
        public Eq11 eq { get; set; }
        public Limit11 limit { get; set; }
    }

    public class Filter11
    {
        public float hpf { get; set; }
    }

    public class Gate11
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp11
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq11
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit11
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch13
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter12 filter { get; set; }
        public Gate12 gate { get; set; }
        public Comp12 comp { get; set; }
        public Eq12 eq { get; set; }
        public Limit12 limit { get; set; }
    }

    public class Filter12
    {
        public float hpf { get; set; }
    }

    public class Gate12
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp12
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq12
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit12
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch14
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter13 filter { get; set; }
        public Gate13 gate { get; set; }
        public Comp13 comp { get; set; }
        public Eq13 eq { get; set; }
        public Limit13 limit { get; set; }
    }

    public class Filter13
    {
        public float hpf { get; set; }
    }

    public class Gate13
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp13
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq13
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit13
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch15
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter14 filter { get; set; }
        public Gate14 gate { get; set; }
        public Comp14 comp { get; set; }
        public Eq14 eq { get; set; }
        public Limit14 limit { get; set; }
    }

    public class Filter14
    {
        public float hpf { get; set; }
    }

    public class Gate14
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp14
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq14
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit14
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch16
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter15 filter { get; set; }
        public Gate15 gate { get; set; }
        public Comp15 comp { get; set; }
        public Eq15 eq { get; set; }
        public Limit15 limit { get; set; }
    }

    public class Filter15
    {
        public float hpf { get; set; }
    }

    public class Gate15
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp15
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq15
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit15
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch17
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter16 filter { get; set; }
        public Gate16 gate { get; set; }
        public Comp16 comp { get; set; }
        public Eq16 eq { get; set; }
        public Limit16 limit { get; set; }
    }

    public class Filter16
    {
        public float hpf { get; set; }
    }

    public class Gate16
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp16
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq16
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit16
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch18
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter17 filter { get; set; }
        public Gate17 gate { get; set; }
        public Comp17 comp { get; set; }
        public Eq17 eq { get; set; }
        public Limit17 limit { get; set; }
    }

    public class Filter17
    {
        public float hpf { get; set; }
    }

    public class Gate17
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp17
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq17
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit17
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch19
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter18 filter { get; set; }
        public Gate18 gate { get; set; }
        public Comp18 comp { get; set; }
        public Eq18 eq { get; set; }
        public Limit18 limit { get; set; }
    }

    public class Filter18
    {
        public float hpf { get; set; }
    }

    public class Gate18
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp18
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq18
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit18
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch20
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter19 filter { get; set; }
        public Gate19 gate { get; set; }
        public Comp19 comp { get; set; }
        public Eq19 eq { get; set; }
        public Limit19 limit { get; set; }
    }

    public class Filter19
    {
        public float hpf { get; set; }
    }

    public class Gate19
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp19
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq19
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit19
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch211
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter20 filter { get; set; }
        public Gate20 gate { get; set; }
        public Comp20 comp { get; set; }
        public Eq20 eq { get; set; }
        public Limit20 limit { get; set; }
    }

    public class Filter20
    {
        public float hpf { get; set; }
    }

    public class Gate20
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp20
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq20
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit20
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch22
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter21 filter { get; set; }
        public Gate21 gate { get; set; }
        public Comp21 comp { get; set; }
        public Eq21 eq { get; set; }
        public Limit21 limit { get; set; }
    }

    public class Filter21
    {
        public float hpf { get; set; }
    }

    public class Gate21
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp21
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq21
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit21
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch23
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter22 filter { get; set; }
        public Gate22 gate { get; set; }
        public Comp22 comp { get; set; }
        public Eq22 eq { get; set; }
        public Limit22 limit { get; set; }
    }

    public class Filter22
    {
        public float hpf { get; set; }
    }

    public class Gate22
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp22
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq22
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit22
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch24
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter23 filter { get; set; }
        public Gate23 gate { get; set; }
        public Comp23 comp { get; set; }
        public Eq23 eq { get; set; }
        public Limit23 limit { get; set; }
    }

    public class Filter23
    {
        public float hpf { get; set; }
    }

    public class Gate23
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp23
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq23
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit23
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch25
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter24 filter { get; set; }
        public Gate24 gate { get; set; }
        public Comp24 comp { get; set; }
        public Eq24 eq { get; set; }
        public Limit24 limit { get; set; }
    }

    public class Filter24
    {
        public float hpf { get; set; }
    }

    public class Gate24
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp24
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq24
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit24
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch26
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter25 filter { get; set; }
        public Gate25 gate { get; set; }
        public Comp25 comp { get; set; }
        public Eq25 eq { get; set; }
        public Limit25 limit { get; set; }
    }

    public class Filter25
    {
        public float hpf { get; set; }
    }

    public class Gate25
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp25
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq25
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit25
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch27
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter26 filter { get; set; }
        public Gate26 gate { get; set; }
        public Comp26 comp { get; set; }
        public Eq26 eq { get; set; }
        public Limit26 limit { get; set; }
    }

    public class Filter26
    {
        public float hpf { get; set; }
    }

    public class Gate26
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp26
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq26
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit26
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch28
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter27 filter { get; set; }
        public Gate27 gate { get; set; }
        public Comp27 comp { get; set; }
        public Eq27 eq { get; set; }
        public Limit27 limit { get; set; }
    }

    public class Filter27
    {
        public float hpf { get; set; }
    }

    public class Gate27
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp27
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq27
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit27
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch29
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter28 filter { get; set; }
        public Gate28 gate { get; set; }
        public Comp28 comp { get; set; }
        public Eq28 eq { get; set; }
        public Limit28 limit { get; set; }
    }

    public class Filter28
    {
        public float hpf { get; set; }
    }

    public class Gate28
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp28
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq28
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit28
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch30
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter29 filter { get; set; }
        public Gate29 gate { get; set; }
        public Comp29 comp { get; set; }
        public Eq29 eq { get; set; }
        public Limit29 limit { get; set; }
    }

    public class Filter29
    {
        public float hpf { get; set; }
    }

    public class Gate29
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp29
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq29
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit29
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch311
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter30 filter { get; set; }
        public Gate30 gate { get; set; }
        public Comp30 comp { get; set; }
        public Eq30 eq { get; set; }
        public Limit30 limit { get; set; }
    }

    public class Filter30
    {
        public float hpf { get; set; }
    }

    public class Gate30
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp30
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq30
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit30
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch32
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public float FXA { get; set; }
        public float FXB { get; set; }
        public float FXC { get; set; }
        public float FXD { get; set; }
        public int digitalin { get; set; }
        public int digitaloption { get; set; }
        public int prepost { get; set; }
        public int _48v { get; set; }
        public int polarity { get; set; }
        public int scdetect { get; set; }
        public float preampgain { get; set; }
        public int assign_fx1 { get; set; }
        public int assign_fx2 { get; set; }
        public int assign_fx3 { get; set; }
        public int assign_fx4 { get; set; }
        public Filter31 filter { get; set; }
        public Gate31 gate { get; set; }
        public Comp31 comp { get; set; }
        public Eq31 eq { get; set; }
        public Limit31 limit { get; set; }
    }

    public class Filter31
    {
        public float hpf { get; set; }
    }

    public class Gate31
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp31
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq31
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit31
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Return
    {
        public Ch110 ch1 { get; set; }
        public Ch210 ch2 { get; set; }
    }

    public class Ch110
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
    }

    public class Ch210
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public int digitalsource { get; set; }
    }

    public class Talkback
    {
        public Ch112 ch1 { get; set; }
    }

    public class Ch112
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
        public int inputsource { get; set; }
        public string storedinputsrc { get; set; }
    }

    public class Uipreview
    {
        public Ch113 ch1 { get; set; }
    }

    public class Ch113
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public Filter32 filter { get; set; }
        public Gate32 gate { get; set; }
        public Comp32 comp { get; set; }
        public Eq32 eq { get; set; }
        public Limit32 limit { get; set; }
    }

    public class Filter32
    {
        public float hpf { get; set; }
    }

    public class Gate32
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp32
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq32
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit32
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Aux
    {
        public Ch114 ch1 { get; set; }
        public Ch212 ch2 { get; set; }
        public Ch33 ch3 { get; set; }
        public Ch42 ch4 { get; set; }
        public Ch51 ch5 { get; set; }
        public Ch61 ch6 { get; set; }
        public Ch71 ch7 { get; set; }
        public Ch81 ch8 { get; set; }
        public Ch91 ch9 { get; set; }
        public Ch101 ch10 { get; set; }
        public Ch115 ch11 { get; set; }
        public Ch121 ch12 { get; set; }
        public Ch131 ch13 { get; set; }
        public Ch141 ch14 { get; set; }
        public Ch151 ch15 { get; set; }
        public Ch161 ch16 { get; set; }
    }

    public class Ch114
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter33 filter { get; set; }
        public Gate33 gate { get; set; }
        public Comp33 comp { get; set; }
        public Eq33 eq { get; set; }
        public Limit33 limit { get; set; }
    }

    public class Filter33
    {
        public float hpf { get; set; }
    }

    public class Gate33
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp33
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq33
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit33
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch212
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter34 filter { get; set; }
        public Gate34 gate { get; set; }
        public Comp34 comp { get; set; }
        public Eq34 eq { get; set; }
        public Limit34 limit { get; set; }
    }

    public class Filter34
    {
        public float hpf { get; set; }
    }

    public class Gate34
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp34
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq34
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit34
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch33
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter35 filter { get; set; }
        public Gate35 gate { get; set; }
        public Comp35 comp { get; set; }
        public Eq35 eq { get; set; }
        public Limit35 limit { get; set; }
    }

    public class Filter35
    {
        public float hpf { get; set; }
    }

    public class Gate35
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp35
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq35
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit35
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch42
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter36 filter { get; set; }
        public Gate36 gate { get; set; }
        public Comp36 comp { get; set; }
        public Eq36 eq { get; set; }
        public Limit36 limit { get; set; }
    }

    public class Filter36
    {
        public float hpf { get; set; }
    }

    public class Gate36
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp36
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq36
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit36
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch51
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter37 filter { get; set; }
        public Gate37 gate { get; set; }
        public Comp37 comp { get; set; }
        public Eq37 eq { get; set; }
        public Limit37 limit { get; set; }
    }

    public class Filter37
    {
        public float hpf { get; set; }
    }

    public class Gate37
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp37
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq37
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit37
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch61
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter38 filter { get; set; }
        public Gate38 gate { get; set; }
        public Comp38 comp { get; set; }
        public Eq38 eq { get; set; }
        public Limit38 limit { get; set; }
    }

    public class Filter38
    {
        public float hpf { get; set; }
    }

    public class Gate38
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp38
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq38
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit38
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch71
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter39 filter { get; set; }
        public Gate39 gate { get; set; }
        public Comp39 comp { get; set; }
        public Eq39 eq { get; set; }
        public Limit39 limit { get; set; }
    }

    public class Filter39
    {
        public float hpf { get; set; }
    }

    public class Gate39
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp39
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq39
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit39
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch81
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter40 filter { get; set; }
        public Gate40 gate { get; set; }
        public Comp40 comp { get; set; }
        public Eq40 eq { get; set; }
        public Limit40 limit { get; set; }
    }

    public class Filter40
    {
        public float hpf { get; set; }
    }

    public class Gate40
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp40
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq40
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit40
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch91
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter41 filter { get; set; }
        public Gate41 gate { get; set; }
        public Comp41 comp { get; set; }
        public Eq41 eq { get; set; }
        public Limit41 limit { get; set; }
    }

    public class Filter41
    {
        public float hpf { get; set; }
    }

    public class Gate41
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp41
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq41
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit41
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch101
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter42 filter { get; set; }
        public Gate42 gate { get; set; }
        public Comp42 comp { get; set; }
        public Eq42 eq { get; set; }
        public Limit42 limit { get; set; }
    }

    public class Filter42
    {
        public float hpf { get; set; }
    }

    public class Gate42
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp42
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq42
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit42
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch115
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter43 filter { get; set; }
        public Gate43 gate { get; set; }
        public Comp43 comp { get; set; }
        public Eq43 eq { get; set; }
        public Limit43 limit { get; set; }
    }

    public class Filter43
    {
        public float hpf { get; set; }
    }

    public class Gate43
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp43
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq43
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit43
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch121
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter44 filter { get; set; }
        public Gate44 gate { get; set; }
        public Comp44 comp { get; set; }
        public Eq44 eq { get; set; }
        public Limit44 limit { get; set; }
    }

    public class Filter44
    {
        public float hpf { get; set; }
    }

    public class Gate44
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp44
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq44
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit44
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch131
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter45 filter { get; set; }
        public Gate45 gate { get; set; }
        public Comp45 comp { get; set; }
        public Eq45 eq { get; set; }
        public Limit45 limit { get; set; }
    }

    public class Filter45
    {
        public float hpf { get; set; }
    }

    public class Gate45
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp45
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq45
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit45
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch141
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter46 filter { get; set; }
        public Gate46 gate { get; set; }
        public Comp46 comp { get; set; }
        public Eq46 eq { get; set; }
        public Limit46 limit { get; set; }
    }

    public class Filter46
    {
        public float hpf { get; set; }
    }

    public class Gate46
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp46
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq46
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit46
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch151
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter47 filter { get; set; }
        public Gate47 gate { get; set; }
        public Comp47 comp { get; set; }
        public Eq47 eq { get; set; }
        public Limit47 limit { get; set; }
    }

    public class Filter47
    {
        public float hpf { get; set; }
    }

    public class Gate47
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp47
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq47
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit47
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch161
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter48 filter { get; set; }
        public Gate48 gate { get; set; }
        public Comp48 comp { get; set; }
        public Eq48 eq { get; set; }
        public Limit48 limit { get; set; }
    }

    public class Filter48
    {
        public float hpf { get; set; }
    }

    public class Gate48
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp48
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq48
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit48
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Fxbus
    {
        public Ch116 ch1 { get; set; }
        public Ch213 ch2 { get; set; }
        public Ch34 ch3 { get; set; }
        public Ch43 ch4 { get; set; }
    }

    public class Ch116
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter49 filter { get; set; }
        public Gate49 gate { get; set; }
        public Comp49 comp { get; set; }
        public Eq49 eq { get; set; }
        public Limit49 limit { get; set; }
    }

    public class Filter49
    {
        public float hpf { get; set; }
    }

    public class Gate49
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp49
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq49
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit49
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch213
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter50 filter { get; set; }
        public Gate50 gate { get; set; }
        public Comp50 comp { get; set; }
        public Eq50 eq { get; set; }
        public Limit50 limit { get; set; }
    }

    public class Filter50
    {
        public float hpf { get; set; }
    }

    public class Gate50
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp50
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq50
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit50
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch34
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter51 filter { get; set; }
        public Gate51 gate { get; set; }
        public Comp51 comp { get; set; }
        public Eq51 eq { get; set; }
        public Limit51 limit { get; set; }
    }

    public class Filter51
    {
        public float hpf { get; set; }
    }

    public class Gate51
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp51
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq51
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit51
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Ch43
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public int auxpremode { get; set; }
        public int busmode { get; set; }
        public int aux2main { get; set; }
        public int aux2mono { get; set; }
        public Filter52 filter { get; set; }
        public Gate52 gate { get; set; }
        public Comp52 comp { get; set; }
        public Eq52 eq { get; set; }
        public Limit52 limit { get; set; }
    }

    public class Filter52
    {
        public float hpf { get; set; }
    }

    public class Gate52
    {
        public int on { get; set; }
        public int keylisten { get; set; }
        public int expander { get; set; }
        public float keyfilter { get; set; }
        public float threshold { get; set; }
        public float range { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
    }

    public class Comp52
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq52
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit52
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Fxreturn
    {
        public Ch117 ch1 { get; set; }
        public Ch214 ch2 { get; set; }
        public Ch35 ch3 { get; set; }
        public Ch44 ch4 { get; set; }
    }

    public class Ch117
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
    }

    public class Ch214
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
    }

    public class Ch35
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
    }

    public class Ch44
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public int lr { get; set; }
        public int mono { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int sub3 { get; set; }
        public int sub4 { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float aux12_pan { get; set; }
        public float aux34_pan { get; set; }
        public float aux56_pan { get; set; }
        public float aux78_pan { get; set; }
        public float aux910_pan { get; set; }
        public float aux1112_pan { get; set; }
        public float aux1314_pan { get; set; }
        public float aux1516_pan { get; set; }
        public float aux12_stpan { get; set; }
        public float aux34_stpan { get; set; }
        public float aux56_stpan { get; set; }
        public float aux78_stpan { get; set; }
        public float aux910_stpan { get; set; }
        public float aux1112_stpan { get; set; }
        public float aux1314_stpan { get; set; }
        public float aux1516_stpan { get; set; }
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
    }

    public class Mono
    {
        public Ch118 ch1 { get; set; }
    }

    public class Ch118
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public Filter53 filter { get; set; }
        public Lpfilter lpfilter { get; set; }
        public Comp53 comp { get; set; }
        public Eq53 eq { get; set; }
        public Limit53 limit { get; set; }
    }

    public class Filter53
    {
        public float hpf { get; set; }
    }

    public class Lpfilter
    {
        public float lpf { get; set; }
    }

    public class Comp53
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq53
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit53
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Main
    {
        public Ch119 ch1 { get; set; }
    }

    public class Ch119
    {
        public string username { get; set; }
        public int color { get; set; }
        public int memab { get; set; }
        public int solo { get; set; }
        public float volume { get; set; }
        public int mute { get; set; }
        public float pan { get; set; }
        public float stereopan { get; set; }
        public int linkmaster { get; set; }
        public string iconid { get; set; }
        public float delay { get; set; }
        public Comp54 comp { get; set; }
        public Eq54 eq { get; set; }
        public Limit54 limit { get; set; }
    }

    public class Comp54
    {
        public int on { get; set; }
        public int softknee { get; set; }
        public int automode { get; set; }
        public float threshold { get; set; }
        public float ratio { get; set; }
        public float attack { get; set; }
        public float release { get; set; }
        public float gain { get; set; }
    }

    public class Eq54
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int eqallon { get; set; }
        public float eqgain1 { get; set; }
        public float eqq1 { get; set; }
        public float eqfreq1 { get; set; }
        public int eqbandon1 { get; set; }
        public int eqbandop1 { get; set; }
        public float eqgain2 { get; set; }
        public float eqq2 { get; set; }
        public float eqfreq2 { get; set; }
        public int eqbandon2 { get; set; }
        public float eqgain3 { get; set; }
        public float eqq3 { get; set; }
        public float eqfreq3 { get; set; }
        public int eqbandon3 { get; set; }
        public float eqgain4 { get; set; }
        public float eqq4 { get; set; }
        public float eqfreq4 { get; set; }
        public int eqbandon4 { get; set; }
        public int eqbandop4 { get; set; }
    }

    public class Limit54
    {
        public int limiteron { get; set; }
        public float threshold { get; set; }
    }

    public class Geq
    {
        public float spectrumRangeLo { get; set; }
        public float spectrumRangeHi { get; set; }
        public int spectrumAveraging { get; set; }
        public Ch120 ch1 { get; set; }
        public Ch215 ch2 { get; set; }
        public Ch36 ch3 { get; set; }
        public Ch45 ch4 { get; set; }
        public Ch52 ch5 { get; set; }
        public Ch62 ch6 { get; set; }
        public Ch72 ch7 { get; set; }
        public Ch82 ch8 { get; set; }
        public Ch92 ch9 { get; set; }
        public Ch102 ch10 { get; set; }
        public Ch1110 ch11 { get; set; }
        public Ch122 ch12 { get; set; }
        public Ch132 ch13 { get; set; }
        public Ch142 ch14 { get; set; }
        public Ch152 ch15 { get; set; }
    }

    public class Ch120
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch215
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch36
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch45
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch52
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch62
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch72
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch82
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch92
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch102
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch1110
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch122
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch132
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch142
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Ch152
    {
        public float gain1 { get; set; }
        public float gain2 { get; set; }
        public float gain3 { get; set; }
        public float gain4 { get; set; }
        public float gain5 { get; set; }
        public float gain6 { get; set; }
        public float gain7 { get; set; }
        public float gain8 { get; set; }
        public float gain9 { get; set; }
        public float gain10 { get; set; }
        public float gain11 { get; set; }
        public float gain12 { get; set; }
        public float gain13 { get; set; }
        public float gain14 { get; set; }
        public float gain15 { get; set; }
        public float gain16 { get; set; }
        public float gain17 { get; set; }
        public float gain18 { get; set; }
        public float gain19 { get; set; }
        public float gain20 { get; set; }
        public float gain21 { get; set; }
        public float gain22 { get; set; }
        public float gain23 { get; set; }
        public float gain24 { get; set; }
        public float gain25 { get; set; }
        public float gain26 { get; set; }
        public float gain27 { get; set; }
        public float gain28 { get; set; }
        public float gain29 { get; set; }
        public float gain30 { get; set; }
        public float gain31 { get; set; }
        public int on { get; set; }
        public int ston { get; set; }
        public string name { get; set; }
        public int mem_ab { get; set; }
    }

    public class Filtergroup
    {
        public Ch123 ch1 { get; set; }
        public Ch216 ch2 { get; set; }
        public Ch37 ch3 { get; set; }
        public Ch46 ch4 { get; set; }
        public Ch53 ch5 { get; set; }
        public Ch63 ch6 { get; set; }
        public Ch73 ch7 { get; set; }
        public Ch83 ch8 { get; set; }
        public Ch93 ch9 { get; set; }
        public Ch103 ch10 { get; set; }
        public Ch1111 ch11 { get; set; }
        public Ch124 ch12 { get; set; }
        public Ch133 ch13 { get; set; }
        public Ch143 ch14 { get; set; }
        public Ch153 ch15 { get; set; }
        public Ch162 ch16 { get; set; }
        public Ch171 ch17 { get; set; }
        public Ch181 ch18 { get; set; }
        public Ch191 ch19 { get; set; }
        public Ch201 ch20 { get; set; }
        public Ch217 ch21 { get; set; }
        public Ch221 ch22 { get; set; }
        public Ch231 ch23 { get; set; }
        public Ch241 ch24 { get; set; }
        public Ch251 ch25 { get; set; }
        public Ch261 ch26 { get; set; }
        public Ch271 ch27 { get; set; }
        public Ch281 ch28 { get; set; }
        public Ch291 ch29 { get; set; }
        public Ch301 ch30 { get; set; }
    }

    public class Ch123
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch216
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch37
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch103
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch1111
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch124
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch133
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch143
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch153
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch162
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch171
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch181
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch191
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch201
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch217
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch221
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch231
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch241
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch251
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch261
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch271
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch281
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch291
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Ch301
    {
        public string name { get; set; }
        public string iconid { get; set; }
        public float volume { get; set; }
        public float aux1 { get; set; }
        public float aux2 { get; set; }
        public float aux3 { get; set; }
        public float aux4 { get; set; }
        public float aux5 { get; set; }
        public float aux6 { get; set; }
        public float aux7 { get; set; }
        public float aux8 { get; set; }
        public float aux9 { get; set; }
        public float aux10 { get; set; }
        public float aux11 { get; set; }
        public float aux12 { get; set; }
        public float aux13 { get; set; }
        public float aux14 { get; set; }
        public float aux15 { get; set; }
        public float aux16 { get; set; }
        public float fx1 { get; set; }
        public float fx2 { get; set; }
        public float fx3 { get; set; }
        public float fx4 { get; set; }
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

    public class Mixersettings
    {
        public int faderlink { get; set; }
        public int faderlocate { get; set; }
        public int showAutoDCAgroups { get; set; }
    }

    public class Fatchannelpages
    {
        public int page { get; set; }
    }

}
