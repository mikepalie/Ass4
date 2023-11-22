using DesktopApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public class MyDatabase
    {
        public List<TShirt> TShirts { get; set; }

        public MyDatabase()
        {
            TShirt s1 = new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            TShirt s2 = new TShirt(Color.BLUE, Size.M, Fabric.COTTON);
            TShirt s3 = new TShirt(Color.YELLOW, Size.XS, Fabric.RAYON);
            TShirt s4 = new TShirt(Color.VIOLET, Size.M, Fabric.SILK);
            TShirt s5 = new TShirt(Color.BLUE, Size.S, Fabric.WOOL);
            TShirt s6 = new TShirt(Color.RED, Size.XXXL, Fabric.COTTON);
            TShirt s7 = new TShirt(Color.OFANGE, Size.XXL, Fabric.LINEN);
            TShirt s8 = new TShirt(Color.GREEN, Size.XXXL, Fabric.POLYESTER);
            TShirt s9 = new TShirt(Color.INDIGO, Size.L, Fabric.CASHMERE);
            TShirt s10 = new TShirt(Color.OFANGE, Size.S, Fabric.WOOL);
            TShirt s11 = new TShirt(Color.YELLOW, Size.M, Fabric.SILK);
            TShirt s12 = new TShirt(Color.INDIGO, Size.XL, Fabric.RAYON);
            TShirt s13 = new TShirt(Color.BLUE, Size.S, Fabric.CASHMERE);
            TShirt s14 = new TShirt(Color.GREEN, Size.M, Fabric.COTTON);
            TShirt s15 = new TShirt(Color.YELLOW, Size.M, Fabric.LINEN);
            TShirt s16 = new TShirt(Color.INDIGO, Size.S, Fabric.COTTON);
            TShirt s17 = new TShirt(Color.BLUE, Size.XL, Fabric.COTTON);
            TShirt s18 = new TShirt(Color.RED, Size.XS, Fabric.WOOL);
            TShirt s19 = new TShirt(Color.VIOLET, Size.XXL, Fabric.CASHMERE);
            TShirt s20 = new TShirt(Color.BLUE, Size.L, Fabric.WOOL);
            TShirt s21 = new TShirt(Color.GREEN, Size.S,Fabric.COTTON);
            TShirt s22 = new TShirt(Color.INDIGO, Size.M, Fabric.POLYESTER);
            TShirt s23 = new TShirt(Color.INDIGO, Size.XXXL, Fabric.LINEN);
            TShirt s24 = new TShirt(Color.VIOLET, Size.XXL, Fabric.CASHMERE);
            TShirt s25 = new TShirt(Color.GREEN, Size.S, Fabric.COTTON);
            TShirt s26 = new TShirt(Color.YELLOW, Size.XL, Fabric.SILK);

            TShirts = new List<TShirt> { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26 };
        }
    }
}
