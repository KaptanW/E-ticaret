using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ticaret.Classes
{
    internal class Ürünclass
    {
		private int Id;

		public int ID
		{
			get { return Id; }
			set { Id = value; }
		}

		private string productName;

		public string PRODUCTNAME
		{
			get { return productName; }
			set { productName = value; }
		}

		private string productPrice;

		public string PRODUCTPRİCE
		{
			get { return productPrice; }
			set { productPrice = value; }
		}

		private string productCategory;

		public string PRODUCTCATEGORY
		{
			get { return productCategory; }
			set { productCategory = value; }
		}

        public Ürünclass(string name, string price, string category, int id)
        {
			ID = id;
            PRODUCTNAME = name;
			PRODUCTPRİCE = price;
			PRODUCTCATEGORY = category;
        }



    }
}
