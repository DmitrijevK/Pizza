using Pizza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pizza.ViewModel
{
    public class ViewModelss : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ZakazListViewModel lvm;

        public pizza Otprav { get; private set; }

        public ViewModelss()
        {
            Otprav = new pizza();
        }

        public ZakazListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Otprav.Name; }
            set
            {
                if (Otprav.Name != value)
                {
                    Otprav.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Zakaz
        {
            get { return Otprav.Zakaz; }
            set
            {
                if (Otprav.Zakaz != value)
                {
                    Otprav.Zakaz = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Phone
        {
            get { return Otprav.Phone; }
            set
            {
                if (Otprav.Phone != value)
                {
                    Otprav.Phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Phone.Trim())) ||
                    (!string.IsNullOrEmpty(Zakaz.Trim())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
