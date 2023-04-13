using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MafiaAppRGR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitPage : ContentPage
    {
        int n = 10;
        public InitPage()
        {
            InitializeComponent();

            for(int i = 0; i < n; i++)
            {
                var entry = new Entry();
                var label = new Label();
                label.Text = "Игркок " + (i + 1).ToString();
                PlayersEntry.Children.Add(label);
                PlayersEntry.Children.Add(entry);
            }
        }
    }
}