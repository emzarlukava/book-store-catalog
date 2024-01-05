using System.Globalization;

namespace BookStoreCatalog
{
    /// <summary>
    /// Represents a book price.
    /// </summary>
    // Add class declaration.
#pragma warning disable
    public class BookPrice
    {
        // Add fields.
        private decimal amount;
        private string currency;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookPrice"/> class.
        /// </summary>
        // Add constructor.
        public BookPrice()
        {
            this.amount = 0;
            this.currency = "USD";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookPrice"/> class with specified <paramref name="amount"/> and <paramref name="currency"/>.
        /// </summary>
        /// <param name="amount">An amount of money of a book.</param>
        /// <param name="currency">A price currency.</param>
        // Add constructor.
        public BookPrice(decimal amount, string currency)
        {
            ThrowExceptionIfAmountIsNotValid(amount);
            ThrowExceptionIfCurrencyIsNotValid(currency);
            this.amount = amount;
            this.currency = currency;
        }

        /// <summary>
        /// Gets or sets an amount of money that a book costs.
        /// </summary>
        // Add property.
        public decimal Amount
        {
            get => amount;
            set
            {
                ThrowExceptionIfAmountIsNotValid(value);
                amount = value;
            }
        }

        /// <summary>
        /// Gets a book price currency.
        /// </summary>
        // Add property.
        public string Currency
        {
            get => currency;
            set
            {
                ThrowExceptionIfCurrencyIsNotValid(value);
                currency = value;
            }
        }

        /// <summary>
        /// Returns the string that represents a current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{this.amount:N2} {this.currency}";
        }


        // Add method.
        private static void ThrowExceptionIfAmountIsNotValid(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cant be less tahn 0");
            }
        }

        // Add method.
        private static void ThrowExceptionIfCurrencyIsNotValid(string currency)
        {
            // Implement the currency validation logic if needed
            // For simplicity, assuming any non-null or non-empty currency is valid
            if (string.IsNullOrEmpty(currency))
            {
                throw new ArgumentException("Currency cannot be null or empty.");
            }
        }

        // Add method.
    }
}
