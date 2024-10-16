using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizator_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag != false)
            {
                Console.WriteLine("Добро пожаловать в блек джек");
                if (flag == true)
                {
                    Deck deck = new Deck();
                    Player player = new Player();
                    DealerAttack dealerAttack = new DealerAttack();
                    dealerAttack.Hand();
                    player.Hand();
                    Console.Write("Ваша рука:");
                    player.ShowPlaersHandPrice();
                    Console.Write("Рука аттакуещего диллера рука:");
                    dealerAttack.ShowDealerAttackHandPrice();
                    string flag1 = "";
                    string flag2 = "yes";
                    while (flag1 != "no" && player.GetPlaersHandPrice() <= 21 && flag2 != "no" && dealerAttack.GetDealerAttackHandPrice() <= 21)
                    {
                        Console.WriteLine("Введите yes , если xотите добрать карту, и no ,если не хотите");
                        flag1 = Console.ReadLine();
                        if (flag1 == "yes")
                        {
                            player.AddCard();
                            Console.Write("Ваша рука:");
                            player.ShowPlaersHandPrice();
                        }
                        if (dealerAttack.GetDealerAttackHandPrice() >= 18)
                        {
                            flag2 = "no";
                        }
                        if (flag2 == "yes")
                        {
                            dealerAttack.AddCard();
                            Console.Write("рука аттакуещего дилера:");
                            dealerAttack.ShowDealerAttackHandPrice();
                        }
                    }
                    if (dealerAttack.GetDealerAttackHandPrice() > 21)
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука аттакуещего дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Диллер проиграл,его рука больше 21");

                    }
                    else if (player.GetPlaersHandPrice() > dealerAttack.GetDealerAttackHandPrice())
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Вы выйграли,рука дилера меньше");
                    }
                    else if (player.GetPlaersHandPrice() > dealerAttack.GetDealerAttackHandPrice())
                    {
                        if (player.GetPlaersHandPrice() != 21)
                        {

                        }
                        else
                            Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука атакуещего дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Вы Проиграли");
                    }
                    if (player.GetPlaersHandPrice() > 21)
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука аттакуещего дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Вы проиграли,ваша рука больше 21");

                    }
                    else if (player.GetPlaersHandPrice() < dealerAttack.GetDealerAttackHandPrice())
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Вы проиграли,рука дилера больше");
                    }
                    else if (player.GetPlaersHandPrice() > dealerAttack.GetDealerAttackHandPrice())
                    {
                        if (player.GetPlaersHandPrice() != 21)
                        {

                        }
                        else
                            Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Вы Выиграли");

                    }
                    else
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealerAttack.ShowDealerAttackHandPrice();
                        Console.WriteLine("Ничья");
                    }
                }
                else
                {
                    flag = false;
                }
            }
        }
    }
    
}
