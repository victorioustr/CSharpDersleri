using System;

namespace UnitConverter.Library
{
    public class EnumInformation : Attribute
    {
        public EnumInformation(string ShortDescription, string LongDescription)
        {
            this.ShortDescription = ShortDescription;
            this.LongDescription = LongDescription;
        }

        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
