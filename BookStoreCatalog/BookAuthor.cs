namespace BookStoreCatalog
{
    /// <summary>
    /// Represents a book author.
    /// </summary>
    // Add class declaration.
#pragma warning disable
    public class BookAuthor
    {
        private string authorName;
        private bool hasIsni;
        private NameIdentifier isni;
        /// <summary>
        /// Initializes a new instance of the <see cref="BookAuthor"/> class with the specified author name and 16-digit ISNI code.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <exception cref="ArgumentNullException">name is null.</exception>
        public BookAuthor(string authorName)
        {
            if (authorName is null)
            {
                throw new ArgumentNullException(nameof(authorName));
            }

            authorName = authorName.Trim();
            if (string.IsNullOrEmpty(authorName))
            {
                throw new ArgumentException("An author's name cannot be empty or consist of white-space only characters.", nameof(authorName));
            }

            this.authorName = authorName;
            hasIsni = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookAuthor"/> class with the specified author name and 16-digit ISNI code.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="isniCode">A 16-digit ISNI code that uniquely identifies a book author.</param>
        /// <exception cref="ArgumentNullException">name is null or isniCode is null.</exception>
        /// <exception cref="ArgumentException">name is empty or consists of white-space only characters.</exception>
        // TODO Add constructor.
        public BookAuthor(string authorName, string isniCode) : this(authorName)
        {
            if (isniCode is null)
            {
                throw new ArgumentNullException(nameof(isniCode));
            }

            Isni = new NameIdentifier(isniCode);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BookAuthor"/> class with the specified author name and 16-digit ISNI code.
        /// </summary>
        /// <param name="authorName">A book author name.</param>
        /// <param name="nameIdentifier">An International Standard Name Identifier that uniquely identifies a book author.</param>
        /// <exception cref="ArgumentNullException">name is null or nameIdentifier is null.</exception>
        /// <exception cref="ArgumentException">name is empty or consists of white-space only characters.</exception>
        // TODO Add constructor.
        public BookAuthor(string authorName, NameIdentifier nameIdentifier) : this(authorName)
        {
            if (nameIdentifier is null)
            {
                throw new ArgumentNullException(nameof(nameIdentifier));
            }

            Isni = nameIdentifier;
        }

        /// <summary>
        /// Gets a book author's name.
        /// </summary>
        // Add property.
        public string AuthorName { get; private set; }

        /// <summary>
        /// Gets a value indicating whether an author has an International Standard Name Identifier (ISNI).
        /// </summary>
        // Add property.
        public bool HasIsni { get; private set; }

        /// <summary>
        /// Gets an International Standard Name Identifier (ISNI) that uniquely identifies a book author.
        /// </summary>
        // Add property.
        public NameIdentifier Isni { get; private set; }

        /// <summary>
        /// Returns the string that represents a current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        // Add method.
        public override string ToString()
        {
            if (HasIsni)
            {
                return $"{AuthorName} (ISNI:{Isni.Code})";
            }
            else
            {
                return AuthorName;
            }
        }

        public static implicit operator BookAuthor(string v)
        {
            throw new NotImplementedException();
        }
    }
}
