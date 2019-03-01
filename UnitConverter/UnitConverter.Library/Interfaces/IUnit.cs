using System;
using System.Collections.Generic;

namespace UnitConverter.Library
{
    public interface IUnit
    {
        double Value { get; set; }
        IUnit To<TEnum>(TEnum type) where TEnum : struct, IConvertible, IComparable, IFormattable;
        string ToStringValueOnly(string format = null);
        string ToStringValueWithShortDesc(string format = null);
        string ToStringValueWithLongDesc(string format = null);
        List<UnitType> GetUnitTypes();
    }
}