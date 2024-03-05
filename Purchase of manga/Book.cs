using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_of_manga
{
    internal class Book
    {
		protected double price;

		public double Price
		{
			get { return price; }
		}

		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private string editorial;

		public string Editorial
		{
			get { return editorial; }
			set { editorial = value; }
		}

		private string autor;

		public string Autor
		{
			get { return autor; }
			set { autor = value; }
		}


		public Book()
        {
			title = "";
            autor = "";
            editorial = "";
			price = 250;
        }

		public double CalculateTotal(int quantity)
		{
			return (price*quantity);
		}
    }
}
