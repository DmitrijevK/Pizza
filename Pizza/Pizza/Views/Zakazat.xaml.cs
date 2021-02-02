using Pizza.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizza.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zakazat : ContentPage
    {
        public Zakazat()
        {
        }

        public Zakazat(ViewModelss tempppizza)
        {
            InitializeComponent();
            BindingContext = new ZakazListViewModel() { Navigation = this.Navigation };
        }
    }
}