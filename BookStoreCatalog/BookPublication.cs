using System.Globalization;

namespace BookStoreCatalog
{
    /// <summary>
    /// Represents a book publication.
    /// </summary>
    // Add class declaration.
#pragma warning disable
    public class BookPublication
    {
        private string authorName;
        private string isbnCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookPublication"/> class with the specified publisher, publication date, kind of book binding and an International Standard Book Number.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="isni">A 16-digit ISNI code that uniquely identifies a book author.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="published">A book publication date.</param>
        /// <param name="bookBinding">A kind of book binding.</param>
        /// <param name="isbnCode">A 10-digit International Standard Book Number (ISBN) code assigned to a book publication.</param>
        /// <exception cref="ArgumentNullException"><paramref name="publisher"/> or <paramref name="bookNumber"/> or <paramref name="isbnCode"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="publisher"/> is empty or consists of white-space only characters.</exception>
        // Add constructor.
        public BookPublication(string authorName, string isni, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbnCode)
        {
            if (authorName == null)
            {
                throw new ArgumentNullException(nameof(authorName));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty or contain only white-space characters.", nameof(title));
            }

            if (string.IsNullOrWhiteSpace(publisher))
            {
                throw new ArgumentException("Publisher cannot be empty or contain only white-space characters.", nameof(publisher));
            }

            if (isbnCode == null)
            {
                throw new ArgumentNullException(nameof(isbnCode));
            }

            // Assign properties
            Author = authorName;
            Title = title;
            Publisher = publisher;
            Published = published;
            BookBinding = bookBinding;
            Isbn = isbnCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BookPublication"/> class with the specified publisher, publication date, kind of book binding and an International Standard Book Number.
        /// </summary>
        /// <param name="authorName">A book author's name.</param>
        /// <param name="isni">A 16-digit ISNI code that uniquely identifies a book author.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="published">A book publication date.</param>
        /// <param name="bookBinding">A kind of book binding.</param>
        /// <param name="isbnCode">A 10-digit International Standard Book Number (ISBN) code assigned to a book publication.</param>
        /// <exception cref="ArgumentNullException"><paramref name="publisher"/> or <paramref name="bookNumber"/> or <paramref name="code"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="publisher"/> is empty or consists of white-space only characters.</exception>
        // TODO Add constructor.
        public BookPublication(string authorName, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode)
        {
            Author = authorName;
            isniCode = isniCode;
            Title = title;
            publisher = Publisher;
            published = Published;
            bookBinding = BookBinding;
            isbnCode = isbnCode;
        }

        //new BookPublication(authorName: authorName, title: title, publisher: publisher, published: published, bookBinding: bookBinding, isbnCode: isbnCode);
        /// <summary>
        /// Initializes a new instance of the <see cref="BookPublication"/> class with the specified publisher, publication date, kind of book binding and an International Standard Book Number.
        /// </summary>
        /// <param name="author">A book author.</param>
        /// <param name="title">A book title.</param>
        /// <param name="publisher">A book publisher.</param>
        /// <param name="published">A book publication date.</param>
        /// <param name="bookBinding">A kind of book binding.</param>
        /// <param name="isbn">An International Standard Book Number assigned to a book publication.</param>
        /// <exception cref="ArgumentNullException"><paramref name="publisher"/> or <paramref name="isbn"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="publisher"/> is empty or consists of white-space only characters.</exception>
        // TODO Add constructor.
        public BookPublication(BookAuthor author, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbn)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be empty or contain only white-space characters.", nameof(title));
            }

            if (string.IsNullOrWhiteSpace(publisher))
            {
                throw new ArgumentException("Publisher cannot be empty or contain only white-space characters.", nameof(publisher));
            }

            if (isbn == null)
            {
                throw new ArgumentNullException(nameof(isbn));
            }

            // Assign properties
            Author = author;
            Title = title;
            Publisher = publisher;
            Published = published;
            BookBinding = bookBinding;
            Isbn = isbn;
        }

        public BookPublication(string authorName, string title, string publisher, DateTime published, BookBindingKind bookBinding, string isbnCode)
        {
            this.authorName = authorName;
            Title = title;
            Publisher = publisher;
            Published = published;
            BookBinding = bookBinding;
            this.isbnCode = isbnCode;
        }

        public BookPublication(BookAuthor authorName1, string isniCode, string title, string publisher, DateTime published, BookBindingKind bookBinding, BookNumber isbn)
        {
            AuthorName = authorName1;
            IsniCode = isniCode;
            Title = title;
            Publisher = publisher;
            Published = published;
            BookBinding = bookBinding;
            Isbn = isbn;
        }

        /// <summary>
        /// Gets a book author.
        /// </summary>
        // Add property.
        public BookAuthor Author { get; set; }

        /// <summary>
        /// Gets a book title.
        /// </summary>
        // Add property.
        public string Title { get; init; }

        /// <summary>
        /// Gets a book publisher.
        /// </summary>
        // Add property.
        public string Publisher { get; init; }

        /// <summary>
        /// Gets a book publishing date.
        /// </summary>
        // Add property.
        public DateTime Published { get; init; }

        /// <summary>
        /// Gets a book binding kind.
        /// </summary>
        // Add property.
        public BookBindingKind BookBinding { get; init; }

        /// <summary>
        /// Gets a book International Standard Book Number (ISBN).
        /// </summary>
        // Add property.
        public BookNumber Isbn { get; init; }

        public BookAuthor AuthorName { get; }

        public string IsniCode { get; }

        /// <summary>
        /// Gets a publication date as a string.
        /// </summary>
        /// <returns>A publication date as a string.</returns>
        // TODO Add method.
        public string GetPublicationDateString()
        {
            return Published.ToString("MMMM, yyyy");
        }

        /// <summary>
        /// Returns the string that represents a current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        // TODO Add method.
        public override string ToString()
        {
            return $"{Title} by {Author.AuthorName}";
        }
    }
}
