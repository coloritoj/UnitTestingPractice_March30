using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockUnitPractice
{
    public class Stock
    {
        public string CheckIfMemeStock(string entry)
        {
            string message = "";

            if (string.IsNullOrEmpty(entry))
            {
                message = "You did not enter anything";
            }
            else if (entry == "GameStop" || entry == "AMC Entertainment")
            {
                message = "Stonks only go up";
            }
            else
            {
                message = "This is not a memestock";
            }

            return message;
        }
        
        public string ValidateTicker(string ticker)
        {
            string message = "";

            if (string.IsNullOrEmpty(ticker))
            {
                return "You did not enter anything";
            }

            char[] charArray = new char[ticker.Length];

            // Good thing to refactor would be making "i" be more readable according to UWM standards, such as "charIterator"
            for (int charIterator = 0; charIterator < charArray.Length; charIterator++)
            {
                charArray[charIterator] = ticker[charIterator];
            }

            List<int> numberChecker = new List<int>();

            for (int charIterator = 0; charIterator < charArray.Length; charIterator++)
            {
                if (int.TryParse(charArray[charIterator].ToString(), out int result))
                {
                    numberChecker.Add(result);
                }
            }

            if (numberChecker.Count > 1)
            {
                message = "Ticker cannot contain numbers";
            }
            else if (ticker.Length > 5)
            {
                message = "Your ticker is too long";
            }
            else
            {
                message = "This is a valid ticker";
            }

            return message;
        }

        public string DescribePrice(double price)
        {
            string message = "";

            if (price < 0)
            {
                message = "Invalid price";
            }
            else if (price >= 0.00 && price <= 0.99)
            {
                message = "This is a penny stock";
            }
            else if (price >= 1.00 && price <= 9000.00)
            {
                message = "This is an averagely priced stock";
            }
            else if (price > 9000.00)
            {
                message = "TO THE MOON!";
            }
            

            return message;
        }
    }
}
