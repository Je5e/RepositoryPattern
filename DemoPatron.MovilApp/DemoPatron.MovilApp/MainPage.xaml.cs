using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DemoPatron.BLL;
using DemoPatron.Entities;

namespace DemoPatron.MovilApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BLL.CategoryManager Bll = new CategoryManager();
            ListViewCategories.ItemsSource = Bll.GetCategories();
        }
    }
}
