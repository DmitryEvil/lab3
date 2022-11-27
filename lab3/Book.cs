using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace lab3 
{
    class Book
    {

        static void Main(string[] args)
        {

            Title title = new()
            {
                TitleName = "Five"
            };


            Content content = new()
            {
                ContentName = "C # 9 programming language and .NET 5 platform."
            };


            Author author = new()
            {
                AuthorName = "Andrew Troelsen"
            };

            title.Show();
            content.Show();
            author.Show();
        }
    }
}
