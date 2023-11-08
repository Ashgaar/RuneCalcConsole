using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneCalcConsole
{
    public class Graphic
    {
        public void Introduction() {
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("/                               /");
            Console.WriteLine("/      Welcome to runecalc      /");
            Console.WriteLine("/                               /");
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("");
        }

 

        public void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("--- Main menu ---");
            Console.WriteLine("");
            Console.WriteLine("1. Show XP table");

            Console.WriteLine("0. Exit");
        }

        public void XPTable()
        {
            Console.WriteLine("");
            Console.WriteLine("Lvl | XP | Diff");
            Console.WriteLine("1  | 0          | 0");
            Console.WriteLine("2  | 83         | 83");
            Console.WriteLine("3  | 174        | 91");
            Console.WriteLine("4  | 276        | 102");
            Console.WriteLine("5  | 388        | 112");
            Console.WriteLine("6  | 512        | 124");
            Console.WriteLine("7  | 650        | 138");
            Console.WriteLine("8  | 801        | 151");
            Console.WriteLine("9  | 969        | 168");
            Console.WriteLine("10 | 1,154      | 185");
            Console.WriteLine("11 | 1,358      | 204");
            Console.WriteLine("12 | 1,584      | 226");
            Console.WriteLine("13 | 1,833      | 249");
            Console.WriteLine("14 | 2,107      | 274");
            Console.WriteLine("15 | 2,411      | 304");
            Console.WriteLine("16 | 2,746      | 335");
            Console.WriteLine("17 | 3,115      | 369");
            Console.WriteLine("18 | 3,523      | 408");
            Console.WriteLine("19 | 3,973      | 450");
            Console.WriteLine("20 | 4,470      | 497");
            Console.WriteLine("21 | 5,018      | 548");
            Console.WriteLine("22 | 5,624      | 606");
            Console.WriteLine("23 | 6,291      | 667");
            Console.WriteLine("24 | 7,028      | 737");
            Console.WriteLine("25 | 7,842      | 814");
            Console.WriteLine("26 | 8,740      | 898");
            Console.WriteLine("27 | 9,730      | 990");
            Console.WriteLine("28 | 10,824     | 1,094");
            Console.WriteLine("29 | 12,031     | 1,207");
            Console.WriteLine("30 | 13,363     | 1,332");
            Console.WriteLine("31 | 14,833     | 1,470");
            Console.WriteLine("32 | 16,456     | 1,623");
            Console.WriteLine("33 | 18,247     | 1,791");
            Console.WriteLine("34 | 20,224     | 1,977");
            Console.WriteLine("35 | 22,406     | 2,182");
            Console.WriteLine("36 | 24,815     | 2,409");
            Console.WriteLine("37 | 27,473     | 2,658");
            Console.WriteLine("38 | 30,408     | 2,935");
            Console.WriteLine("39 | 33,648     | 3,240");
            Console.WriteLine("40 | 37,224     | 3,576");
            Console.WriteLine("41 | 41,171     | 3,947");
            Console.WriteLine("42 | 45,529     | 4,358");
            Console.WriteLine("43 | 50,339     | 4,810");
            Console.WriteLine("44 | 55,649     | 5,310");
            Console.WriteLine("45 | 61,512     | 5,863");
            Console.WriteLine("46 | 67,983     | 6,471");
            Console.WriteLine("47 | 75,127     | 7,144");
            Console.WriteLine("48 | 83,014     | 7,887");
            Console.WriteLine("49 | 91,721     | 8,707");
            Console.WriteLine("50 | 101,333    | 9,612");
            Console.WriteLine("51 | 111,945    | 10,612");
            Console.WriteLine("52 | 123,660    | 11,715");
            Console.WriteLine("53 | 136,594    | 12,934");
            Console.WriteLine("54 | 150,872    | 14,278");
            Console.WriteLine("55 | 166,636    | 15,764");
            Console.WriteLine("56 | 184,040    | 17,404");
            Console.WriteLine("57 | 203,254    | 19,214");
            Console.WriteLine("58 | 224,466    | 21,212");
            Console.WriteLine("59 | 247,886    | 23,420");
            Console.WriteLine("60 | 273,742    | 25,856");
            Console.WriteLine("61 | 302,288    | 28,546");
            Console.WriteLine("62 | 333,804    | 31,516");
            Console.WriteLine("63 | 368,599    | 34,795");
            Console.WriteLine("64 | 407,015    | 38,416");
            Console.WriteLine("65 | 449,428    | 42,413");
            Console.WriteLine("66 | 496,254    | 46,826");
            Console.WriteLine("67 | 547,953    | 51,699");
            Console.WriteLine("68 | 605,032    | 57,079");
            Console.WriteLine("69 | 668,051    | 63,019");
            Console.WriteLine("70 | 737,627    | 69,576");
            Console.WriteLine("71 | 814,445    | 76,818");
            Console.WriteLine("72 | 899,257    | 84,812");
            Console.WriteLine("73 | 992,895    | 93,638");
            Console.WriteLine("74 | 1,096,278  | 103,383");
            Console.WriteLine("75 | 1,210,421  | 114,143");
            Console.WriteLine("76 | 1,336,443  | 126,022");
            Console.WriteLine("77 | 1,475,581  | 139,138");
            Console.WriteLine("78 | 1,629,200  | 153,619");
            Console.WriteLine("79 | 1,798,808  | 169,608");
            Console.WriteLine("80 | 1,986,068  | 187,260");
            Console.WriteLine("81 | 2,192,818  | 206,750");
            Console.WriteLine("82 | 2,421,087  | 228,269");
            Console.WriteLine("83 | 2,673,114  | 252,027");
            Console.WriteLine("84 | 2,951,373  | 278,259");
            Console.WriteLine("85 | 3,258,594  | 307,221");
            Console.WriteLine("86 | 3,597,792  | 339,198");
            Console.WriteLine("87 | 3,972,294  | 374,502");
            Console.WriteLine("88 | 4,385,776  | 413,482");
            Console.WriteLine("89 | 4,842,295  | 456,519");
            Console.WriteLine("90 | 5,346,332  | 504,037");
            Console.WriteLine("91 | 5,902,831  | 556,499");
            Console.WriteLine("92 | 6,517,253  | 614,422");
            Console.WriteLine("93 | 7,195,629  | 678,376");
            Console.WriteLine("94 | 7,944,614  | 748,985");
            Console.WriteLine("95 | 8,771,558  | 826,944");
            Console.WriteLine("96 | 9,684,577  | 913,019");
            Console.WriteLine("97 | 10,692,629 | 1,008,052");
            Console.WriteLine("98 | 11,805,606 | 1,112,977");
            Console.WriteLine("99 | 13,034,431 | 1,228,825");
            Console.WriteLine("");
        }
    }
}
