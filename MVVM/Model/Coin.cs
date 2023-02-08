using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCryptApp.MVVM.Model
{
    sealed class Coin
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public int Rank { get; set; }

        public double VolumeUsd { get; set; }

        public double PriceUsd { get; set; }

        public double PriceChange { get; set; }

        public string? WebSite { get; set; }
    }
}
