using DiamondKataSolver;

namespace DiamondKataSolverTests;

public sealed class DiamondTests
{
    [Fact]
    public void Given_A_CreateDiamond_Returns_Expected_Output()
    {
        // Arrange
        Diamond diamond = new Diamond();
        
        // Act/Assert
        Assert.Equal("A", diamond.CreateDiamond('A'));
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Given_Valid_Letter_CreateDiamond_Returns_Correct_Repeated_Character_Sequence_With_Indented_New_Lines(char girdleLetter, string expectedOutput)
    {
        // Arrange
        Diamond diamond = new Diamond();

        // Act/Assert
        Assert.Equal(expectedOutput, diamond.CreateDiamond(girdleLetter));
    }

    public static IEnumerable<object[]> GetTestData()
    {
        return new List<object[]>
        {
            new object[] { 'a', "a" },
            new object[] { 'A', "A" },
            new object[] { 'b', " a\nbb" },
            new object[] { 'B', " A\nBB" },
            new object[] { 'c', "  a\n bb\ncc" },
            new object[] { 'C', "  A\n BB\nCC" },
            new object[] { 'd', "   a\n  bb\n cc\ndd" },
            new object[] { 'D', "   A\n  BB\n CC\nDD" },
            new object[] { 'e', "    a\n   bb\n  cc\n dd\nee" },
            new object[] { 'E', "    A\n   BB\n  CC\n DD\nEE" },
            new object[] { 'f', "     a\n    bb\n   cc\n  dd\n ee\nff" },
            new object[] { 'F', "     A\n    BB\n   CC\n  DD\n EE\nFF" },
            new object[] { 'g', "      a\n     bb\n    cc\n   dd\n  ee\n ff\ngg" },
            new object[] { 'G', "      A\n     BB\n    CC\n   DD\n  EE\n FF\nGG" },
            new object[] { 'h', "       a\n      bb\n     cc\n    dd\n   ee\n  ff\n gg\nhh" },
            new object[] { 'H', "       A\n      BB\n     CC\n    DD\n   EE\n  FF\n GG\nHH" },
            new object[] { 'i', "        a\n       bb\n      cc\n     dd\n    ee\n   ff\n  gg\n hh\nii" },
            new object[] { 'I', "        A\n       BB\n      CC\n     DD\n    EE\n   FF\n  GG\n HH\nII" },
            new object[] { 'j', "         a\n        bb\n       cc\n      dd\n     ee\n    ff\n   gg\n  hh\n ii\njj" },
            new object[] { 'J', "         A\n        BB\n       CC\n      DD\n     EE\n    FF\n   GG\n  HH\n II\nJJ" },
            new object[] { 'k', "          a\n         bb\n        cc\n       dd\n      ee\n     ff\n    gg\n   hh\n  ii\n jj\nkk" },
            new object[] { 'K', "          A\n         BB\n        CC\n       DD\n      EE\n     FF\n    GG\n   HH\n  II\n JJ\nKK" },
            new object[] { 'l', "           a\n          bb\n         cc\n        dd\n       ee\n      ff\n     gg\n    hh\n   ii\n  jj\n kk\nll" },
            new object[] { 'L', "           A\n          BB\n         CC\n        DD\n       EE\n      FF\n     GG\n    HH\n   II\n  JJ\n KK\nLL" },
            new object[] { 'm', "            a\n           bb\n          cc\n         dd\n        ee\n       ff\n      gg\n     hh\n    ii\n   jj\n  kk\n ll\nmm" },
            new object[] { 'M', "            A\n           BB\n          CC\n         DD\n        EE\n       FF\n      GG\n     HH\n    II\n   JJ\n  KK\n LL\nMM" },
            new object[] { 'n', "             a\n            bb\n           cc\n          dd\n         ee\n        ff\n       gg\n      hh\n     ii\n    jj\n   kk\n  ll\n mm\nnn" },
            new object[] { 'N', "             A\n            BB\n           CC\n          DD\n         EE\n        FF\n       GG\n      HH\n     II\n    JJ\n   KK\n  LL\n MM\nNN" },
            new object[] { 'o', "              a\n             bb\n            cc\n           dd\n          ee\n         ff\n        gg\n       hh\n      ii\n     jj\n    kk\n   ll\n  mm\n nn\noo" },
            new object[] { 'O', "              A\n             BB\n            CC\n           DD\n          EE\n         FF\n        GG\n       HH\n      II\n     JJ\n    KK\n   LL\n  MM\n NN\nOO" },
            new object[] { 'p', "               a\n              bb\n             cc\n            dd\n           ee\n          ff\n         gg\n        hh\n       ii\n      jj\n     kk\n    ll\n   mm\n  nn\n oo\npp" },
            new object[] { 'P', "               A\n              BB\n             CC\n            DD\n           EE\n          FF\n         GG\n        HH\n       II\n      JJ\n     KK\n    LL\n   MM\n  NN\n OO\nPP" },
            new object[] { 'q', "                a\n               bb\n              cc\n             dd\n            ee\n           ff\n          gg\n         hh\n        ii\n       jj\n      kk\n     ll\n    mm\n   nn\n  oo\n pp\nqq" },
            new object[] { 'Q', "                A\n               BB\n              CC\n             DD\n            EE\n           FF\n          GG\n         HH\n        II\n       JJ\n      KK\n     LL\n    MM\n   NN\n  OO\n PP\nQQ" },
            new object[] { 'r', "                 a\n                bb\n               cc\n              dd\n             ee\n            ff\n           gg\n          hh\n         ii\n        jj\n       kk\n      ll\n     mm\n    nn\n   oo\n  pp\n qq\nrr" },
            new object[] { 'R', "                 A\n                BB\n               CC\n              DD\n             EE\n            FF\n           GG\n          HH\n         II\n        JJ\n       KK\n      LL\n     MM\n    NN\n   OO\n  PP\n QQ\nRR" },
            new object[] { 's', "                  a\n                 bb\n                cc\n               dd\n              ee\n             ff\n            gg\n           hh\n          ii\n         jj\n        kk\n       ll\n      mm\n     nn\n    oo\n   pp\n  qq\n rr\nss" },
            new object[] { 'S', "                  A\n                 BB\n                CC\n               DD\n              EE\n             FF\n            GG\n           HH\n          II\n         JJ\n        KK\n       LL\n      MM\n     NN\n    OO\n   PP\n  QQ\n RR\nSS" },
            new object[] { 't', "                   a\n                  bb\n                 cc\n                dd\n               ee\n              ff\n             gg\n            hh\n           ii\n          jj\n         kk\n        ll\n       mm\n      nn\n     oo\n    pp\n   qq\n  rr\n ss\ntt" },
            new object[] { 'T', "                   A\n                  BB\n                 CC\n                DD\n               EE\n              FF\n             GG\n            HH\n           II\n          JJ\n         KK\n        LL\n       MM\n      NN\n     OO\n    PP\n   QQ\n  RR\n SS\nTT" },
            new object[] { 'u', "                    a\n                   bb\n                  cc\n                 dd\n                ee\n               ff\n              gg\n             hh\n            ii\n           jj\n          kk\n         ll\n        mm\n       nn\n      oo\n     pp\n    qq\n   rr\n  ss\n tt\nuu" },
            new object[] { 'U', "                    A\n                   BB\n                  CC\n                 DD\n                EE\n               FF\n              GG\n             HH\n            II\n           JJ\n          KK\n         LL\n        MM\n       NN\n      OO\n     PP\n    QQ\n   RR\n  SS\n TT\nUU" },
            new object[] { 'v', "                     a\n                    bb\n                   cc\n                  dd\n                 ee\n                ff\n               gg\n              hh\n             ii\n            jj\n           kk\n          ll\n         mm\n        nn\n       oo\n      pp\n     qq\n    rr\n   ss\n  tt\n uu\nvv" },
            new object[] { 'V', "                     A\n                    BB\n                   CC\n                  DD\n                 EE\n                FF\n               GG\n              HH\n             II\n            JJ\n           KK\n          LL\n         MM\n        NN\n       OO\n      PP\n     QQ\n    RR\n   SS\n  TT\n UU\nVV" },
            new object[] { 'w', "                      a\n                     bb\n                    cc\n                   dd\n                  ee\n                 ff\n                gg\n               hh\n              ii\n             jj\n            kk\n           ll\n          mm\n         nn\n        oo\n       pp\n      qq\n     rr\n    ss\n   tt\n  uu\n vv\nww" },
            new object[] { 'W', "                      A\n                     BB\n                    CC\n                   DD\n                  EE\n                 FF\n                GG\n               HH\n              II\n             JJ\n            KK\n           LL\n          MM\n         NN\n        OO\n       PP\n      QQ\n     RR\n    SS\n   TT\n  UU\n VV\nWW" },
            new object[] { 'x', "                       a\n                      bb\n                     cc\n                    dd\n                   ee\n                  ff\n                 gg\n                hh\n               ii\n              jj\n             kk\n            ll\n           mm\n          nn\n         oo\n        pp\n       qq\n      rr\n     ss\n    tt\n   uu\n  vv\n ww\nxx" },
            new object[] { 'X', "                       A\n                      BB\n                     CC\n                    DD\n                   EE\n                  FF\n                 GG\n                HH\n               II\n              JJ\n             KK\n            LL\n           MM\n          NN\n         OO\n        PP\n       QQ\n      RR\n     SS\n    TT\n   UU\n  VV\n WW\nXX" },
            new object[] { 'y', "                        a\n                       bb\n                      cc\n                     dd\n                    ee\n                   ff\n                  gg\n                 hh\n                ii\n               jj\n              kk\n             ll\n            mm\n           nn\n          oo\n         pp\n        qq\n       rr\n      ss\n     tt\n    uu\n   vv\n  ww\n xx\nyy" },
            new object[] { 'Y', "                        A\n                       BB\n                      CC\n                     DD\n                    EE\n                   FF\n                  GG\n                 HH\n                II\n               JJ\n              KK\n             LL\n            MM\n           NN\n          OO\n         PP\n        QQ\n       RR\n      SS\n     TT\n    UU\n   VV\n  WW\n XX\nYY" },
            new object[] { 'z', "                         a\n                        bb\n                       cc\n                      dd\n                     ee\n                    ff\n                   gg\n                  hh\n                 ii\n                jj\n               kk\n              ll\n             mm\n            nn\n           oo\n          pp\n         qq\n        rr\n       ss\n      tt\n     uu\n    vv\n   ww\n  xx\n yy\nzz" },
            new object[] { 'Z', "                         A\n                        BB\n                       CC\n                      DD\n                     EE\n                    FF\n                   GG\n                  HH\n                 II\n                JJ\n               KK\n              LL\n             MM\n            NN\n           OO\n          PP\n         QQ\n        RR\n       SS\n      TT\n     UU\n    VV\n   WW\n  XX\n YY\nZZ" }
        };
    }
}
