using System;
using System.Collections.Generic;
using System.Text;

namespace MafiaAppRGR
{
    public class Game
    {
        public string[] Nicknames = new string[10];
        public string _lawer = null;
        public int[] _fouls = new int[10];
        public Game(string[] nicknames) 
        {
            Nicknames = nicknames;
        }

        public Game(string[] nicknames, string lawer)
        {
            Nicknames = nicknames;
            _lawer = lawer;
        }
    }
}
