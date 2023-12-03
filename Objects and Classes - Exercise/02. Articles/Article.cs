using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Articles
{
    class Article
    {
        private string title;
        private string content;
        private string author;

        // Constructor
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        //Getter and setters
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        // Edit method to change the content
        public void Edit(string newContent)
        {
            Content = newContent;
        }

        // ChangeAuthor method to change the author
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        // Rename method to change the title
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        // Override ToString method to print the article in the specified format
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
