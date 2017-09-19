using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Masine
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new CreditCard("1234", "1234567891234");
            Console.Write("Entre pin-code: ");
            var pin = "0";
            var authorisation = false;
            while (authorisation == false)
            {
                pin = Console.ReadLine();
                try
                {
                    card.Autorisation(pin);
                    authorisation = true;
                    Console.WriteLine("Sucsess");
                }
                catch (CreditCardExeption ex)
                {
                    Console.WriteLine("Incorrect pin-code! Left {0} attemps.", ex.RemainingAttems + 1);

                }
                catch (CreditCardLockedExeption)
                {
                    Console.WriteLine("Your card was blocked. Contact with bank support.");
                    break;
                }
                
            }
            
        }
    }
}
