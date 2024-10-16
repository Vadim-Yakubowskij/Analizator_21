using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizator_21
{
    internal class Player : Deck
    {
        private List<string> playershand = new List<string>();
        private int playershandprice;

        public void Hand()
        {
            playershand.Add(GiveCard());
            playershand.Add(GiveCard());
            for (int i = 0; i < 2; i++)
            {
                int cardprice;
                if (int.TryParse(playershand[i], out cardprice))
                {
                    playershandprice += cardprice;
                }
                else
                {
                    if (playershand[i] != "a")
                    {
                        playershandprice += 10;
                    }
                    else
                    {
                        if (playershandprice == 11)
                        {
                            playershandprice = 2;
                        }
                        else
                        {
                            playershandprice += 11;
                        }
                    }
                }
            }
        }
        public void ShowPlaersHandPrice()
        {
            Console.WriteLine(playershandprice);
        }
        public void AddCard()
        {
            playershand.Add(GiveCard());
            int cardprice;
            if (int.TryParse(playershand[playershand.Count - 1], out cardprice))
            {
                playershandprice += cardprice;
            }
            else
            {
                if (playershand[playershand.Count - 1] != "a")
                {
                    playershandprice += 10;
                }
                else
                {
                    playershandprice += 11;
                }
            }
        }
        public int GetPlaersHandPrice()
        {
            return playershandprice;
        }
    }
}
