using Pizza.Models;
using Pizza.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pizza.ViewModel
{
    public class ZakazListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ViewModelss> pizza { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateZakazCommand { protected set; get; }
        public ICommand DeleteZakazCommand { protected set; get; }
        public ICommand SaveZakazCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        ViewModelss selectedpizeria;

        public INavigation Navigation { get; set; }

        public ZakazListViewModel()
        {
            pizza = new ObservableCollection<ViewModelss>();
            CreateZakazCommand = new Command(CreateZakaz);
            DeleteZakazCommand = new Command(SaveZakaz);
            SaveZakazCommand = new Command(DeleteZakaz);
            BackCommand = new Command(Back);
        }

        public ViewModelss selectEdpizeria
        {
            get { return selectEdpizeria; }
            set
            {
                if (selectEdpizeria != value)
                {
                    ViewModelss tempppizza = value;
                    selectEdpizeria = null;
                    OnPropertyChanged("SelectedPizza");
                    Navigation.PushAsync(new Zakazat(tempppizza));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void CreateZakaz()
        {
            Navigation.PushAsync(new zakazivaet(new ViewModelss() { ListViewModel = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveZakaz(object fdObject)
        {
            ViewModelss klient = fdObject as ViewModelss;
            if (klient != null && klient.IsValid && !pizza.Contains(klient))
            {
                pizza.Add(klient);
            }
            Back();
        }
        private void DeleteZakaz(object fdObject)
        {
            ViewModelss klient = fdObject as ViewModelss;
            if (klient != null)
            {
                pizza.Remove(klient);
            }
            Back();
        }
    }
}