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
    public partial class InitPage1 : ContentPage
    {
        int _nextPage;
        Game _game = new Game();
        Entry[] _entries;
        public InitPage1()
        {
            InitializeComponent();
        }
    }
}