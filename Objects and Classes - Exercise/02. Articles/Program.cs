using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Articles
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Read the initial article information
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            // Create an Article object
            Article article = new Article(title, content, author);

            // Read the number of commands
            int n = int.Parse(Console.ReadLine());

            // Process commands
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                string parameter = command[1];

                // Perform the corresponding action based on the command
                switch (action)
                {
                    case "Edit":
                        article.Edit(parameter);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(parameter);
                        break;
                    case "Rename":
                        article.Rename(parameter);
                        break;
                }
            }

            // Print the final state of the article
            Console.WriteLine(article);
        }
    }
}