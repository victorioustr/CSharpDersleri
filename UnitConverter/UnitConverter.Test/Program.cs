using System;
using UnitConverter.Library;

namespace UnitConverter.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MassUnit a = new MassUnit(12, MassUnitType.Kilogram);
            MassUnit b = new MassUnit(20, MassUnitType.Kilogram);
            MassUnit c = a + b;
            Console.WriteLine(c.To(MassUnitType.Dekagram));
            Console.WriteLine(c.To(MassUnitType.Karat).ToStringValueWithShortDesc("0.000"));
            Console.WriteLine(c.To(MassUnitType.Kilopound));
            Console.WriteLine(c.To(MassUnitType.Ons));
            Console.WriteLine(c.To(MassUnitType.Ton));

            LengthUnit la = new LengthUnit(12, LengthUnitType.Metre);
            LengthUnit lb = new LengthUnit(20, LengthUnitType.Metre);
            LengthUnit lc = la + lb;
            Console.WriteLine(lc.To(LengthUnitType.Micrometre));
            Console.WriteLine(lc.To(LengthUnitType.Yarda));
            Console.WriteLine(lc.To(LengthUnitType.Mil));
            Console.WriteLine(lc.To(LengthUnitType.Inc));
            Console.WriteLine(lc.To(LengthUnitType.DenizMili));

            foreach (UnitType item in c.GetUnitTypes())
            {
                Console.WriteLine($"{item.EnumType} {item.EnumName} {item.ShortDescription} {item.LongDescription}");
            }
            Console.ReadLine();
        }
    }
}
