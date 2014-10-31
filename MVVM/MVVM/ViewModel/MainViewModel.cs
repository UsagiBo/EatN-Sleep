using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVM.Annotations;
using MVVM.Model;

namespace MVVM.ViewModel
{
    
    class MainViewModel : INotifyPropertyChanged //<-- DO IT, NO QUESTIONS AXED.
    {
        private RestaurantModel _restaurant;
        private ObservableCollection<RestaurantModel> _restaurants; 

        public MainViewModel()
        {
            //this is only for testing - things should come from a database
            _restaurants = new ObservableCollection<RestaurantModel>()
            {
                new RestaurantModel() {name = "Cafe Vivaldi", adress = "Staendart 1", phoneNumber = "+45 12 34 56 78"},
                new RestaurantModel() {name = "La Fiesta", adress = "Hestetorvet 13", phoneNumber = "+45 66 66 55 44"}
            };
        }

        public ObservableCollection<RestaurantModel> Restaurants //a list of restaurants made for the view
        {
            get
            {
                return _restaurants;
            }

            set
            {
                _restaurants = value;  //set my restaurnats user variable to what ever the user wants
                OnPropertyChanged("Restaurants"); //tell the view that it's changed.
            }
        }

        public RestaurantModel Restaurant
        {
            get
            {
                return _restaurant;
            }

            set
            {
                _restaurant = value;  //set my restaurnats user variable to what ever the user wants
                OnPropertyChanged("Restaurant");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
