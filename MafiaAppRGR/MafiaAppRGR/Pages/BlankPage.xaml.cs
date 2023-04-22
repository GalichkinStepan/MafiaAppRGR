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

    public partial class BlankPage : ContentPage
    {
        Game _game = null;
        public BlankPage(Game game)
        {
            InitializeComponent();
            _game = game;

            for(int i = 0; i < 10; i++)
            {
                var stack = new StackLayout();
                stack.Orientation = StackOrientation.Horizontal;

                var nick = new Label();
                nick.Text = _game.Nicknames[i];
                stack.Children.Add(nick);

                var foul = new Label();
                foul.Text = "0";
                stack.Children.Add(foul);

                var button = new Button();
                button.Text = "Фолл";
                stack.Children.Add(button);

                PlayersSV.Children.Add(stack);
            }
        }
    }
}