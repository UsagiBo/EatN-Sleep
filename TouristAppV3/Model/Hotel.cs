﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TouristAppV3.Annotations;

namespace TouristAppV3.Model
{
    class Hotel : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string Prices { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
