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
    internal class ListRestaurantsViewModel : INotifyPropertyChanged
    {
        private Restaurant _r1;
        private Restaurant _r2;
        private Restaurant _r3;
        private Restaurant _r4;

        public static Restaurant ActualRestaurant { get; set; }

        #region properties
        public Restaurant r1
        {
            get { return _r1; }
            set { _r1= value; }
        }

        public Restaurant r2
        {
            get { return _r2; }
            set { _r2 = value; }
        }

        public Restaurant r3
        {
            get { return _r3; }
            set { _r3 = value; }
        }

        public Restaurant r4
        {
            get { return _r4; }
            set { _r4 = value; }
        }
        #endregion
        public ListRestaurantsViewModel()
        {
            _r1 = new Restaurant("Mumm", "Karen Olsdatter Straede 9, Roskilde 4000, Denmark", "+45 4637-2201", "French, Danish", "Mon - Sat 17:30 - 21:30", "../Assets/Restaurants/RestMumm.jpg");
            _r2 = new Restaurant("Skank", "Hestetorvet 10, Roskilde 4000, Denmark", "+45 3214-3204", "Tapas", "Mon - Sun 11:00 - 23:00", "../Assets/Restaurants/RestSkank.jpg");
            _r3 = new Restaurant("Gusto Giusto", "Jernbanegade 19, Roskilde 4000, Denmark", "+45 4632-7377", "Italian", "Mon - Sat 14:00 - 23:00", "../Assets/Restaurants/RestGusto.jpg");
            _r4 = new Restaurant("Vigen", "Baunehojve 5, 4000 Roskilde, Denmark", "+45 6475-5008", "European-Danish", "Sun - Sat 12:00 - 22:00", "../Assets/Restaurants/RestVigen.jpg");
        }
        #region InotifyPropertyChanged
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
