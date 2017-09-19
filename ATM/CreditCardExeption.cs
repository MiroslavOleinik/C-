using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Masine
{

    [Serializable]
    public class CreditCardExeption : Exception
    {
        public int RemainingAttems
        {
            get;
            set;
        }

        public CreditCardExeption() { }
        public CreditCardExeption(string message) : base(message) { }
        public CreditCardExeption(string message, Exception inner) : base(message, inner) { }
        protected CreditCardExeption(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
