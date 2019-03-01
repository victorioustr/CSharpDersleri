using System;

namespace UnitConverter.Library
{
    public interface IUnit
    {
        double Value { get; set; }
        IUnit To<TEnum>(TEnum type) where TEnum : struct, IConvertible, IComparable, IFormattable;
        string ToValueOnly(string format = null);
        string ToValueWithShortDesc(string format = null);
        string ToValueWithLongDesc(string format = null);
    }
}