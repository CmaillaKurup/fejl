using System;

namespace MyBanker
{
    public class Mastercard : Card, ICredit, IUseLimet
    {
        public Mastercard(string name, int age, int accountNumber, int balance, bool internationalUse, DateTime issuedDate, int cardNumber, int ageLimit, DateTime paymentDay) : base(name, age, accountNumber, balance, internationalUse, issuedDate, cardNumber, ageLimit, paymentDay)
        {
        
        }


        public bool Credit()
        {
            throw new NotImplementedException();
        }

        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
    }
}