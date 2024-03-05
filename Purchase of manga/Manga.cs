using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_of_manga
{
    internal class Manga:Book
    {
		private string genre;

		public string Genre
        {
			get { return genre; }
			set { genre = value; }
		}

		private string volume;

		public string Volume
		{
			get { return volume; }
			set { volume = value; }
		}

        public Manga():base()
        {
			genre = "";
			volume = "";
			price = 149.5;
        }
    }
}
