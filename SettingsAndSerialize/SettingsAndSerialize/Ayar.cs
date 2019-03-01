using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SettingsAndSerialize
{
    [Serializable]
    public class Ayar
    {
        public DateTime Tarih1 { get; set; }
        public DateTime Tarih2 { get; set; }
        public string Kalan { get; set; }
    }
}
