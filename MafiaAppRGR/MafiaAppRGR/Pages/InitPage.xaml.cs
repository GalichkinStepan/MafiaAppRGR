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
        Game _game = null;
        Entry[] _entries = new Entry[10];
        string[] _nicknames = new string[10];
        public InitPage()
        {
            InitializeComponent();
            
            for(int i = 0; i < n; i++)
            {
                var entry = new Entry();

                _entries[i] = entry;

                var label = new Label();

                label.Text = "Игркок " + (i + 1).ToString();
                PlayersEntry.Children.Add(label);
                PlayersEntry.Children.Add(entry);
            }
        }

        private async void SaveNicknames(object sender, EventArgs e)
        {
            bool fl = true;
            for(int i = 0; i < n; i++)
            {
                if (_entries[i].Text == null)
                {
                    _nicknames[i] = _entries[i].Text;
                    fl = false; break;
                }
            }

            if(fl)
            {
                _game = new Game(_nicknames);
                await Navigation.PushAsync(new BlankPage(_game));
            }
            else
            {
                _game = new Game(_nicknames);
                await Navigation.PushAsync(new BlankPage(_game));
            }
        }
    }
}