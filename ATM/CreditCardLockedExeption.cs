using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Masine
{

    [Serializable]
    public class CreditCardLockedExeption : Exception
    {
        public CreditCardLockedExeption() { }
        public CreditCardLockedExeption(string message) : base(message) { }
        public CreditCardLockedExeption(string message, Exception inner) : base(message, inner) { }
        protected CreditCardLockedExeption(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
