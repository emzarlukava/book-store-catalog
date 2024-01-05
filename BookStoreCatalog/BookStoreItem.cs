namespace BookStoreCatalog
{
    /// <summary>
    /// Represents the an item in a book store.
    /// </summary>
    // Add class declaration.
    public class BookStoreItem
#pragma warning disable
    {
        // Add fields.
        private BookPublication publication;
        private BookPrice price;
        private int amount;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="authorName"/>, <paramref name="isniCode"/>, <paramref name="title"/>, <paramref name="publisher"/>, <paramref name="published"/>, <paramref name="bookBinding"/>, <paramref name="bookBinding"/>, <paramref name="isbn"/>, <paramref name="priceAmount"/>, <paramref name="priceCurrency"/> and <paramref name="amount"/>.
        /// </summary>
        // Add constructor.
        public BookStoreItem(BookAuthor authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbn, decimal priceAmount, string priceCurrency, int amount)
        {
            // Guard clauses
            if (authorName == null)
            {
                throw new ArgumentNullException(nameof(authorName));
            }

            publication = new BookPublication(authorName, isniCode, title, publisher, published, bookBinding, isbn);
            price = new BookPrice(priceAmount, priceCurrency);

            // Guard clause
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be less than zero.");
            }

            this.amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookStoreItem"/> class with the specified <paramref name="publication"/>, <paramref name="price"/> and <paramref name="amount"/>.
        /// </summary>
        // Add constructor.
        public BookStoreItem(BookPublication publication, BookPrice price, int amount)
        {
            // Guard clauses
            if (publication == null)
            {
                throw new ArgumentNullException(nameof(publication));
            }

            if (price == null)
            {
                throw new ArgumentNullException(nameof(price));
            }

            // Guard clause
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be less than zero.");
            }


            this.publication = publication;
            this.price = price;
            this.amount = amount;
        }

        public BookStoreItem(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbn, decimal priceAmount, string priceCurrency, int amount)
        {
            AuthorName = authorName;
            IsniCode = isniCode;
            Title = title;
            Publisher = publisher;
            Published = published;
            BookBinding = bookBinding;
            Isbn = isbn;
            PriceAmount = priceAmount;
            PriceCurrency = priceCurrency;
            this.amount = amount;
        }

        /// <summary>
        /// Gets or sets a <see cref="BookPublication"/>.
        /// </summary>
        // Add property.
        public BookPublication Publication
        {
            get => this.publication;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                this.publication = value;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="BookPrice"/>.
        /// </summary>
        // Add property.
        public BookPrice Price
        {
            get => price;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                price = value;
            }
        }
        /// <summary>
        /// Gets or sets an amount of books in the store's stock.
        /// </summary>
        // Add property.
        public int Amount
        {
            get => amount;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Amount cannot be less than zero.");
                }

                amount = value;
            }
        }

        public string Isni { get; private set; }
        public string AuthorName { get; }
        public string IsniCode { get; }
        public string Title { get; }
        public string Publisher { get; }
        public DateTime Published { get; }
        public BookBindingKind BookBinding { get; }
        public string Isbn { get; }
        public decimal PriceAmount { get; }
        public string PriceCurrency { get; }

        /// <summary>
        /// Returns the string that represents a current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        // TODO Add method.
        public override string ToString()
        {
            string isniInfo = string.IsNullOrWhiteSpace(Isni) ? " " : $" (ISNI:{publication.Author.Isni})";
            string priceString = price.Amount.ToString("C");
            if (priceString.Contains(","))
            {
                // Wrap the price string with quotation marks
                priceString = $"\"{priceString}\"";
            }

            return $"{publication.Title}, {publication.Author.AuthorName}{isniInfo}, {priceString}, {amount}";
        }
    }
}
