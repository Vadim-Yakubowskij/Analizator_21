using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizator_21
{
    internal class DealerAttack: Deck
    {
        private List<string> dealerAttackhand = new List<string>();
        private int dealerAttackhandprice;
        public void Hand()
        {
            dealerAttackhand.Add(GiveCard());
            dealerAttackhand.Add(GiveCard());
            for (int i = 0; i < 2; i++)
            {
                int cardprice;
                if (int.TryParse(dealerAttackhand[i], out cardprice))
                {
                    dealerAttackhandprice += cardprice;
                }
                else
                {
                    if (dealerAttackhand[i] != "a")
                    {
                        dealerAttackhandprice += 10;
                    }
                    else
                    {
                        if (dealerAttackhandprice == 11)
                        {
                            dealerAttackhandprice = 2;
                        }
                        else
                        {
                            dealerAttackhandprice += 11;
                        }
                    }
                }
            }
        }
        public void ShowDealerAttackHandPrice()
        {
            Console.WriteLine(dealerAttackhandprice);
        }
        public void AddCard()
        {
            dealerAttackhand.Add(GiveCard());
            int cardprice;
            if (int.TryParse(dealerAttackhand[dealerAttackhand.Count - 1], out cardprice))
            {
                dealerAttackhandprice += cardprice;
            }
            else
            {
                if (dealerAttackhand[dealerAttackhand.Count - 1] != "a")
                {
                    dealerAttackhandprice += 10;
                }
                else
                {
                    dealerAttackhandprice += 11;
                }
            }
        }
        public int GetDealerAttackHandPrice()
        {
            return dealerAttackhandprice;
        }
    }
}
