using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal struct Money
    {
        public int UAH { get; }
        public byte Penny { get; }


        public Money ()
        {
            
        }
        private Money (int uah, byte penny)
        {
            UAH = uah;
            Penny = penny;
        }
        public static Money operator + (Money money, Money money1)
        {
            int uah = money.UAH + money1.UAH;
            int penny = money.Penny + money1.Penny;
            if (penny >= 1 ) 
            {
                uah += 1;
                penny -= 100;
            }
            return new Money (uah, (byte)penny);
        }
        public static Money operator +(Money money, decimal money1)
        {
            int b = (int)((money1 - (int)money1) * 100);
            int uah = money.UAH + (int)money1;
            int penny = money.Penny + b;
            if (penny >= 100)
            {
                uah += 1;
                penny -= 100;
            }
            return new Money(uah, (byte)penny);
        }
        public static Money operator - (Money money, decimal money1)
        {
            int b = (int)((money1 - (int)money1) * 100);
            int uah = money.UAH - (int)money1;
            int penny = money.Penny - b;

            if (penny <= 0)
            {
                uah -= 1;
                penny += 100;
            }
            return new Money(uah, (byte)penny);
        }
        public static Money operator -(Money money, Money money1)
        {
            int uah = money.UAH - money1.UAH;
            int penny = money.Penny - money1.Penny;

            if (penny < 0)
            {
                uah -= 1;
                penny += 1;
            }

            return new Money(uah, (byte)penny);
        }
        public static explicit operator decimal(Money money)
        {
            return money.UAH + money.Penny * 0.01m;
        }
        public static bool operator ==(Money money, Money money1) => money.UAH == money1.UAH && money.Penny == money1.Penny;
        public static bool operator !=(Money money, Money money1) => !(money.UAH == money1.UAH && money.Penny == money1.Penny);
        public static bool operator > (Money money, Money money1)
        {
            if (money.UAH > money1.UAH )
                return true;
            if ( money.UAH == money1.UAH && money.Penny > money1.Penny )
                return true;
            return false;
        }
        public static bool operator < (Money money, Money money1)
        {
            if (money.UAH < money1.UAH)
                return true;
            if (money.UAH == money1.UAH && money.Penny < money1.Penny)
                return true;
            return false;
        }
        public static bool operator >= (Money money, Money money1)
        {
            if (money.UAH >= money1.UAH)
                return true;
            if (money.UAH == money1.UAH && money.Penny >= money1.Penny)
                return true;
            return false;
        }
        public static bool operator <= (Money money, Money money1)
        {
            if (money.UAH <= money1.UAH)
                return true;
            if (money.UAH == money1.UAH && money.Penny <= money1.Penny)
                return true;
            return false;
        }
        public static bool operator >= (Money money, decimal money1)
        {
            int b = (int)((money1 - (int)money1) * 100);

            if (money.UAH >= (int)money1)
                return true;
            if (money.UAH == (int)money1 && money.Penny >= b)
                return true;
            return false;
        }
        public static bool operator <= (Money money, decimal money1)
        {
            int b = (int)((money1 - (int)money1) * 100);
            if (money.UAH <= (int)money1)
                return true;
            if (money.UAH == (int)money1 && money.Penny <= b)
                return true;
            return false;
        }

    }
}
