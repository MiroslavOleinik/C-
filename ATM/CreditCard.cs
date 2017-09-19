using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Masine
{
    class CreditCard
    {
        private string m_pin;
        private int m_failsCount = 0;
        private const int m_maxAttems = 2;
        
        public string CardNumber { get; private set; }
        public CreditCard(string pin, string creditNumber)
        {
            m_pin = pin;
            CardNumber = creditNumber;
        }

        public void Autorisation (string pin)
        {
            if (m_failsCount >= m_maxAttems)
            {
                throw new CreditCardLockedExeption()
                {
                };
            }
            if (m_pin != pin)
            {
                m_failsCount++;
                throw new CreditCardExeption()
                {
                    RemainingAttems = m_maxAttems - m_failsCount
                };
            }
            
        }
    }
}
