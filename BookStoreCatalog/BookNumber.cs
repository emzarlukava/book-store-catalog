namespace BookStoreCatalog
{
    /// <summary>
    /// Represents an International Standard Book Number (ISBN).
    /// </summary>
    // Add class declaration.
#pragma warning disable
    public class BookNumber
    {
        // Add fields.
        private readonly string code;
        /// <summary>
        /// Initializes a new instance of the <see cref="BookNumber"/> class with the specified 10-digit ISBN <paramref name="isbnCode"/>.
        /// </summary>
        /// <param name="isbnCode">A 10-digit ISBN code.</param>
        /// <exception cref="ArgumentNullException">a code argument is null.</exception>
        /// <exception cref="ArgumentException">a code argument is invalid or a code has wrong checksum.</exception>
        // Add constructor.
        public BookNumber(string isbnCode)
        {
            if (isbnCode == null)
            {
                throw new ArgumentNullException(nameof(isbnCode));
            }

            if (!ValidateCode(isbnCode) || !ValidateChecksum(isbnCode))
            {
                throw new ArgumentException("Invalid ISBN code.", nameof(isbnCode));
            }

            this.code = isbnCode;
        }

        /// <summary>
        /// Gets a 10-digit ISBN code.
        /// </summary>
        // Add property.
        public string Code => this.code;
        /// <summary>
        /// Gets an <see cref="Uri"/> to the publication page on the isbnsearch.org website.
        /// </summary>
        /// <returns>an <see cref="Uri"/> to the publication page on the isbnsearch.org website.</returns>
        // Add method.
        public Uri GetSearchUri()
        {
            // Replace with the actual search URL format
            string searchUrl = $"https://www.isbnsearch.org/search?s={this.code}";
            return new Uri(searchUrl);
        }

        /// <summary>
        /// Returns the string that represents a current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        // Add method.
        public override string ToString()
        {
            return this.code;
        }

        public static bool ValidateCode(string isbnCode)
        {
            if (!string.IsNullOrEmpty(isbnCode))
            {
                throw new ArgumentNullException(nameof(isbnCode));
            }

            return true;
        }

        // Add method.
        public static bool ValidateChecksum(string isbnCode)
        {
            if (!string.IsNullOrEmpty(isbnCode))
            {
                throw new ArgumentNullException(nameof(isbnCode));
            }

            return true;
        }

        // Add method.

    }
}
