using System;

namespace UnitConverter.Library
{
    public struct LengthUnit : IUnit
    {
        public LengthUnit(double value, LengthUnitType type)
        {
            Value = value;
            _type = type;
        }

        private readonly LengthUnitType _type;

        public double Value { get; set; }

        public IUnit To<TEnum>(TEnum type) where TEnum : struct, IConvertible, IComparable, IFormattable
        {
            if (!typeof(TEnum).IsEnum && typeof(TEnum).GetEnumName(type) != "LengthUnitType")
                throw new ArgumentException("Hatalı ölçü birimi seçildi.");

            Enum.TryParse(type.ToString(), out LengthUnitType tempType);
            return new LengthUnit((getMultiplier(_type) * Value) / getMultiplier(tempType), tempType);
        }

        private double getMultiplier(LengthUnitType type)
        {
            switch (type)
            {
                case LengthUnitType.Nanometre:
                    return 1;
                case LengthUnitType.Micrometre:
                    return 1000;
                case LengthUnitType.Milimetre:
                    return 1000000;
                case LengthUnitType.Santimetre:
                    return 10000000;
                case LengthUnitType.Desimetre:
                    return 100000000;
                case LengthUnitType.Metre:
                    return 1000000000;
                case LengthUnitType.Kilometre:
                    return 1000000000000;
                case LengthUnitType.Inc:
                    return 25400000;
                case LengthUnitType.Fut:
                    return 304800000;
                case LengthUnitType.Yarda:
                    return 914400000;
                case LengthUnitType.Mil:
                    return 1609344000000;
                case LengthUnitType.DenizMili:
                    return 1852000000000;
                default:
                    throw new ArgumentException("Hatalı ölçü birimi seçildi.");
            }
        }

        public static LengthUnit operator +(LengthUnit left, LengthUnit right)
        {
            return new LengthUnit(left.To(LengthUnitType.Nanometre).Value + right.To(LengthUnitType.Nanometre).Value, LengthUnitType.Nanometre);
        }

        public static LengthUnit operator -(LengthUnit left, LengthUnit right)
        {
            return new LengthUnit(left.To(LengthUnitType.Nanometre).Value - right.To(LengthUnitType.Nanometre).Value, LengthUnitType.Nanometre);
        }

        public static LengthUnit operator *(LengthUnit left, LengthUnit right)
        {
            return new LengthUnit(left.To(LengthUnitType.Nanometre).Value * right.To(LengthUnitType.Nanometre).Value, LengthUnitType.Nanometre);
        }

        public static LengthUnit operator /(LengthUnit left, LengthUnit right)
        {
            return new LengthUnit(left.To(LengthUnitType.Nanometre).Value / right.To(LengthUnitType.Nanometre).Value, LengthUnitType.Nanometre);
        }

        public static implicit operator double(LengthUnit u)
        {
            return u.To(LengthUnitType.Nanometre).Value;
        }

        public override string ToString()
        {
            return $"{Value} {_type.GetShortDescription()}";
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
    }
}
