using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAThunderNAT.Models
{
    public static class ThunderChange
    {
        /// <summary>
        /// Takes in an amount of money and breaks it into the most optimal coin amounts.
        /// </summary>
        /// <param name="value">A specific dollar value to be broken into change.</param>
        /// <returns>A Dictionary of name and coin count items</returns>
        public static Dictionary<string, int> MakeChange(string value)
        {
            Dictionary<string, int> MonetaryValues = new Dictionary<string, int>();
            MonetaryValues.Add("silver-dollar", 0);
            MonetaryValues.Add("half-dollar", 0);
            MonetaryValues.Add("quarter", 0);
            MonetaryValues.Add("dime", 0);
            MonetaryValues.Add("nickel", 0);
            MonetaryValues.Add("penny", 0);

            //Attempt to convert the value to a dollar amount
            decimal enteredAmount = 0m;

            try { enteredAmount = Convert.ToDecimal(value); }
            catch(FormatException ex) { throw new FormatException("Could not convert value to proper dollar amount."); }
            
            //run the while statement iterating through the change amounts
            while (enteredAmount > 0)
            {
                if(enteredAmount / 1 >= 1)
                {
                    MonetaryValues["silver-dollar"] += 1;
                    enteredAmount -= 1.0m;
                }
                else if(enteredAmount / .5m >= 1)
                {
                    MonetaryValues["half-dollar"] += 1;
                    enteredAmount -= .5m;
                }
                else if(enteredAmount / .25m >= 1)
                {
                    MonetaryValues["quarter"] += 1;
                    enteredAmount -= .25m;
                }
                else if(enteredAmount / .1m >= 1)
                {
                    MonetaryValues["dime"] += 1;
                    enteredAmount -= .10m;
                }
                else if(enteredAmount / .05m >= 1)
                {
                    MonetaryValues["nickel"] += 1;
                    enteredAmount -= .05m;
                }
                else if(enteredAmount / .01m >= 1)
                {
                    MonetaryValues["penny"] += 1;
                    enteredAmount -= .01m;
                }
                else
                {
                    enteredAmount = 0m;
                }
            }

            return MonetaryValues;
        }
    }
}