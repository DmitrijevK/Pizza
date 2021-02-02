using Pizza.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizza.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class zakazivaet : ContentPage
    {
        public ViewModelss ViewModel { get; private set; }
        public zakazivaet(ViewModelss vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}