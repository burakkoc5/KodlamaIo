using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
