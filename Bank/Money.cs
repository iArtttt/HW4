using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal struct Money
    {
        public int UAH { get; set; }
        public float Penny { get; set; }


        public Money ()
        {
            
        }
        public Money (int uah, int penny)
        {
            UAH = uah;
            Penny = penny * 0.01f;
        }
        public Money (int uah, float penny)
        {
            UAH = uah;
            Penny = penny;
        }
        public static Money operator + (Money money, Money money1)
        {
            int uah = money.UAH + money1.UAH;
            float penny = money.Penny + money1.Penny;
            if (penny >= 1 ) 
            {
                uah += 1;
                penny -= 1;
            }
            return new Money (uah, penny);
        }
        public static Money operator + (Money money, float money1)
        {
            float uahf = money1 - (int)money1;
            int uah = money.UAH + (int)money1;
            float penny = money.Penny + uahf;
            if (penny >= 1 ) 
            {
                uah += 1;
                penny -= 1;
            }
            return new Money (uah, penny);
        }
        public static Money operator - (Money money, float money1)
        {
            float uahf = money1 - (int)money1;
            int uah = money.UAH - (int)money1;
            float penny = money.Penny - uahf;
            if (penny <= 1 ) 
            {
                uah -= 1;
                penny += 1;
            }
            return new Money (uah, penny);
        }
        public static Money operator - (Money money, Money money1)
        {
            int uah = money.UAH - money1.UAH;
            float penny = money.Penny * 0.01f - money1.Penny * 0.01f;

            if(penny < 0)
            {
                uah -= 1;
                penny += 1;
            }

            return new Money (uah, penny);
        }
        public static bool operator == (Money money, Money money1)
        {
            if (money.UAH == money1.UAH && money.Penny == money1.Penny)
                return true;
            return false;

        }
        public static bool operator != (Money money, Money money1)
        {
            if (money.UAH == money1.UAH && money.Penny == money1.Penny)
                return false;
            return true;
        }
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
        public static bool operator >= (Money money, float money2)
        {



            if (money.UAH >= money2)
                return true;
            if (money.UAH == money2 && money.Penny >= money2)
                return true;
            return false;
        }
        public static bool operator <= (Money money, float money2)
        {
            if (money.UAH <= money2)
                return true;
            if (money.UAH == money2 && money.Penny <= money2)
                return true;
            return false;
        }

    }
}
