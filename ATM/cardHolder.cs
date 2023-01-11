using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class cardHolder
    {
        public string? CardNum { get;  set; }
        public int Pin { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double Balance { get;  set; }

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.CardNum = cardNum;
            this.Pin = pin;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Balance = balance;
        }     
    }
}
