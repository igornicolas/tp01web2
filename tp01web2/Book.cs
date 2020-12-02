using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.IO;

namespace tp01web2
{
    class Book
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public Author[] Authors { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string name,Author[] author,double price)
        {
            Name = name;
            Authors = author;
            Price = price;
            Qty = 0;
           
        }
        public Book(string name, Author[] author, double price,int qty)
        {
            Name = name;
            Authors = author;
            Price = price;
            Qty = qty;
        }

        public override string ToString()
        {

            string authors = "";

            foreach (Author a in Authors)
            {
                authors = authors+$"[name={a.Name},email={a.Email},gender={a.Gender}]";

                if (a == Authors.Last())
                {
                }

                else
                {
                    authors += ",";
                }
            }
  
            string stringFinal = "Book[" + Name + ",authors={Author"+ authors + "},price="+ Price + ",qty=" + Qty + "]";

            return stringFinal;
        }
        public string getAuthorNames()
        {
            string author = "";
            
            foreach (Author a in Authors)
            {
                author += a.Name;

                if (a == Authors.Last())
                {
                }

                else
                {
                    author += ",";
                }

            }
            return author;
                  

        }
    }
}
