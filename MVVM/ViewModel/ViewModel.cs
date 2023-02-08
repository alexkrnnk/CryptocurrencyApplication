using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WpfCryptApp.MVVM.Model;

namespace WpfCryptApp.MVVM.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        private Coin? coin;

        public string? Id
        {
            get { return coin.Id; }
            set
            {
                if (coin.Id != value)
                {
                    coin.Id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public string? Name
        {
            get { return coin.Name; }
            set
            {
                if (coin.Name != value)
                {
                    coin.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public int Rank
        {
            get { return coin.Rank; }
            set
            {
                if (coin.Rank != value)
                {
                    coin.Rank = value;
                    OnPropertyChanged(nameof(Rank));
                }
            }
        }

        public double VolumeUsd
        {
            get { return coin.VolumeUsd; }
            set
            {
                if (coin.VolumeUsd != value)
                {
                    coin.VolumeUsd = value;
                    OnPropertyChanged(nameof(VolumeUsd));
                }
            }
        }

        public double PriceUsd
        {
            get { return coin.PriceUsd; }
            set
            {
                if (coin.PriceUsd != value)
                {
                    coin.PriceUsd = value;
                    OnPropertyChanged(nameof(PriceUsd));
                }
            }
        }

        public double PriceChange
        {
            get { return coin.PriceChange; }
            set
            {
                if (coin.PriceChange != value)
                {
                    coin.PriceChange = value;
                    OnPropertyChanged(nameof(PriceChange));
                }
            }
        }

        public string? WebSite
        {
            get { return coin.WebSite; }
            set
            {
                if (coin.WebSite != value)
                {
                    coin.WebSite = value;
                    OnPropertyChanged(nameof(WebSite));
                }
            }
        }

        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://cryptingup.com/api/"),
        };

        //static async Task GetAsync(HttpClient httpClient)
        //{
        //    using HttpResponseMessage response = await httpClient.GetAsync("exchanges");

        //    response.EnsureSuccessStatusCode();

        //    var jsonResponse = await response.Content.ReadAsStringAsync();
        //    Console.WriteLine($"{jsonResponse}\n");

            
        //}

        public ViewModel()
        {

        }
    }
}
