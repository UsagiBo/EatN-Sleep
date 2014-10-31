using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using TouristAppV3.Annotations;
using TouristAppV3.Model;

namespace TouristAppV3.ViewModel
{
    internal class ListHotelViewModel : INotifyPropertyChanged

{
        private Hotel _selectedHotel;

        public ListHotelViewModel()
        {
            #region Hotels

            Hotel h1 = new Hotel()
            {
                Name = "Bed & Breakfast",
                Address = "Skomagergade 10, Roskilde 4000, Denmark",
                TelephoneNumber = "+45 40 44 60 04",
                ImageUrl = @"Assets\Hotels\h1_0.jpg"
            };
            Hotel h2 = new Hotel()
            {
                Name = "Hotel Prindsen",
                Address = "AlGade 13, Roskilde 4000, Denmark",
                TelephoneNumber = "+45 46 30 91 00",
                ImageUrl = @"Assets\Hotels\h2_0.jpg"
            };
            Hotel h3 = new Hotel()
            {
                Name = "Comwell Roskilde",
                Address = "Vestre Kirkevej 12, 4000 Roskilde, Denmark",
                TelephoneNumber = "+45 46 32 31 31",
                ImageUrl = @"Assets\Hotels\h3_0.jpg"
            };
            Hotel h4 = new Hotel()
            {
                Name = "Scandic Roskilde",
                Address = "	Søndre Ringvej 33, 4000 Roskilde, Denmark",
                TelephoneNumber = "+45 46 32 46 32",
                ImageUrl = @"Assets\Hotels\h4_0.jpg"
            };
            #endregion

            Hotels = new ObservableCollection<Hotel>() { h1, h2, h3, h4 };

        }
       
        public ObservableCollection<Hotel> Hotels { get; set; }

        public Hotel SelectedHotel
        {
            get { return _selectedHotel; }
            set
            {
                _selectedHotel = value;
                OnPropertyChanged("SelectedHotel");
            }
        }   
        #region
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
