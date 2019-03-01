using System;

namespace UnitConverter.Library
{
    public struct MassUnit : IUnit
    {
        public MassUnit(double value, MassUnitType type)
        {
            Value = value;
            _type = type;
        }

        private readonly MassUnitType _type;

        public double Value { get; set; }

        public IUnit To<TEnum>(TEnum type) where TEnum : struct, IConvertible, IComparable, IFormattable
        {
            if (!typeof(TEnum).IsEnum && typeof(TEnum).GetEnumName(type) != "MassUnitType")
                throw new ArgumentException("Hatalı ölçü birimi seçildi.");

            Enum.TryParse(type.ToString(), out MassUnitType tempType);
            return new MassUnit((getMultiplier(_type) * Value) / getMultiplier(tempType), tempType);
        }

        private double getMultiplier(MassUnitType type)
        {
            switch (type)
            {
                case MassUnitType.Miligram:
                    return 1;
                case MassUnitType.Santigram:
                    return 10;
                case MassUnitType.Desigram:
                    return 100;
                case MassUnitType.Gram:
                    return 1000;
                case MassUnitType.Dekagram:
                    return 10000;
                case MassUnitType.Hektogram:
                    return 100000;
                case MassUnitType.Kilogram:
                    return 1000000;
                case MassUnitType.Ton:
                    return 10000000;
                case MassUnitType.Kiloton:
                    return 100000000;
                case MassUnitType.Pound:
                    return 453592.37d;
                case MassUnitType.Kilopound:
                    return 453592370;
                case MassUnitType.Karat:
                    return 200;
                case MassUnitType.Ons:
                    return 28349.523125d;
                default:
                    throw new ArgumentException("Hatalı ölçü birimi seçildi.");
            }
        }

        public static MassUnit operator +(MassUnit left, MassUnit right)
        {
            return new MassUnit(left.To(MassUnitType.Miligram).Value + right.To(MassUnitType.Miligram).Value, MassUnitType.Miligram);
        }

        public static MassUnit operator -(MassUnit left, MassUnit right)
        {
            return new MassUnit(left.To(MassUnitType.Miligram).Value - right.To(MassUnitType.Miligram).Value, MassUnitType.Miligram);
        }

        public static MassUnit operator *(MassUnit left, MassUnit right)
        {
            return new MassUnit(left.To(MassUnitType.Miligram).Value * right.To(MassUnitType.Miligram).Value, MassUnitType.Miligram);
        }

        public static MassUnit operator /(MassUnit left, MassUnit right)
        {
            return new MassUnit(left.To(MassUnitType.Miligram).Value / right.To(MassUnitType.Miligram).Value, MassUnitType.Miligram);
        }

        public static implicit operator double(MassUnit u)
        {
            return u.To(MassUnitType.Miligram).Value;
        }

        public string ToValueOnly(string format = null)
        {
            return Value.ToString(format);
        }

        public string ToValueWithShortDesc(string format = null) => $"{Value.ToString(format)} {_type.GetShortDescription()}";

        public string ToValueWithLongDesc(string format = null)
        {
            return $"{Value.ToString(format)} {_type.GetLongDescription()}";
        }

        public override string ToString() => $"{Value} {_type.GetShortDescription()}";
    }
}
