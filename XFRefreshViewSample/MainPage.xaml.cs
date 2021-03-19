using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFRefreshViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
        {
            await Task.Delay(3000);
            myRefreshView.IsRefreshing = false;
        }
    }
}
