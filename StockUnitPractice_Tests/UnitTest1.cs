using NUnit.Framework;
using StockUnitPractice;

// PART 1
// Create a method called CheckIfMemeStock that takes in a stock name and returns a string
    // If the stock name is null or empty, return "You did not enter anything"
    // If the stock name is GameStop or AMC Entertainment, return "Stonks only go up"
    // If the stock name is anything else, return "This is not a memestock"

// PART 2
// Create a method called ValidateTicker that takes in a ticker and returns a string
    // If the ticker contains any numbers, return "Ticker cannot contain numbers"
    // If the ticker is null or empty, return "You did not enter anything"
    // If the ticker is greater than 5 characters, return "Your ticker is too long"
    // If the ticker is between 1 and 5 characters, return "This is a valid ticker"

// PART 3
// Created a method called DescribePrice that takes in a price and returns a string
    // If the ticker price is less than 0.00, return "Invalid price"
    // If the ticker is between 0.00 and 0.99, return "This is a penny stock"
    // If the ticker is between 1.00 and 9,000.00, return "This is an averagely priced stock"
    // If the ticker is greater than 9,000.00, return "TO THE MOON!"

// HELLO WORLD

namespace StockUnitPractice_Tests
{
    public class CheckIfMemeStock_Tests
    {
        Stock stock;

        [SetUp]
        public void Setup()
        {
            stock = new Stock();
        }

        // If the stock name is null or empty, return "You did not enter anything"
        [TestCase("", "You did not enter anything")]
        [TestCase(null, "You did not enter anything")]
        public void CheckIfMemeStock_WhenStringPassedIsNullOrEmpty_ReturnsYouDidNotEnterAnything(string entry, string expected)
        {
            // ARRANGE
            // ACT
            string actual = stock.CheckIfMemeStock(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the stock name is GameStop or AMC Entertainment, return "Stonks only go up"
        [TestCase("GameStop", "Stonks only go up")] // Important note, if you are doing a testcase, the final value has to be the output. You can't just have ("GameStop") as a test case. It needs to be ("GameStop", "Stonks only go up") as the TestCase
        [TestCase("AMC Entertainment", "Stonks only go up")]
        public void CheckIfMemeStock_WhenValueIsGameStopOrAMCEntertainment_ReturnsStonksOnlyGoUp(string entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.CheckIfMemeStock(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the stock name is anything else, return "This is not a memestock"
        [TestCase("Microsoft", "This is not a memestock")]
        [TestCase("Apple", "This is not a memestock")]
        [TestCase("Google", "This is not a memestock")]
        public void CheckIfMemeStock_WhenValueIsAnythingButGameStopOrAMCEntertainment_ReturnsThisIsNotAMemeStock(string entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.CheckIfMemeStock(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }

    public class ValidateTicker_Tests
    {
        Stock stock;

        [SetUp]
        public void Setup() => stock = new Stock(); // This is just another way of doing the Setup() function by using a lambda expression

        // If the ticker contains any numbers, return "Ticker cannot contain numbers"
        [TestCase("GME123", "Ticker cannot contain numbers")]
        [TestCase("AMC456", "Ticker cannot contain numbers")]
        public void ValidateTicker_WhenTickerContainsNumbers_ReturnsTickerCannotContainNumbers(string entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.ValidateTicker(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the ticker is null or empty, return "You did not enter anything"
        [TestCase("", "You did not enter anything")]
        [TestCase(null, "You did not enter anything")]
        public void ValidateTicker_WhenTickerIsNullOrEmpty_ReturnsYouDidNotEnterAnything(string entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.ValidateTicker(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the ticker is greater than 5 characters, return "Your ticker is too long"
        [TestCase("GMELOL", "Your ticker is too long")]
        public void ValidateTicker_WhenTickerIsGreaterThan5Characters_ReturnsYourTickerIsTooLong(string entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.ValidateTicker(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the ticker is between 1 and 5 characters, return "This is a valid ticker"
        [TestCase("F", "This is a valid ticker")]
        [TestCase("BB", "This is a valid ticker")]
        [TestCase("GME", "This is a valid ticker")]
        [TestCase("BBBY", "This is a valid ticker")]
        [TestCase("GOOGL", "This is a valid ticker")]
        public void ValidateTicker_WhenTickerIsBetween1And5Characters_ReturnsThisIsAValidTicker(string entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.ValidateTicker(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }

    public class DescribePriceTests
    {
        Stock stock;

        [SetUp]
        public void Setup() => stock = new Stock();

        // If the ticker price is less than 0.00, return "Invalid price"
        [Test]
        public void DescribePrice_WhenPriceLessThanZero_ReturnInvalidPrice()
        {
            // ARRANGE
            double price = -0.01;
            string expected = "Invalid price";

            // ACT
            string actual = stock.DescribePrice(price);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the ticker is between 0.00 and 0.99, return "This is a penny stock"
        [TestCase(0.00, "This is a penny stock")]
        [TestCase(0.01, "This is a penny stock")]
        [TestCase(0.99, "This is a penny stock")]
        public void DescribePrice_WhenPriceBetween0_00And0_99_ReturnThisIsAPennyStock(double entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.DescribePrice(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the ticker is between 1.00 and 9,000.00, return "This is an averagely priced stock"
        [TestCase(1.00, "This is an averagely priced stock")]
        [TestCase(500.00, "This is an averagely priced stock")]
        [TestCase(9000.00, "This is an averagely priced stock")]
        public void DescribePrice_WhenPriceBetween1_00And9000_00_ReturnThisIsAnAveragelyPricedStock(double entry, string expected)
        {
            // ARRANGE

            // ACT
            string actual = stock.DescribePrice(entry);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        // If the ticker is greater than 9,000.00, return "TO THE MOON!"
        [Test]
        public void DescribePrice_WhenPriceGreaterThan9000_00_ReturnToTheMoon()
        {
            // ARRANGE
            double price = 9000.01;
            string expected = "TO THE MOON!";

            // ACT
            string actual = stock.DescribePrice(price);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}