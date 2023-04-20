using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class Fruit: Product
	{
		//ATTRIBUTES
		string origin;
		string typeOfFruit;
		bool packed;

		//CONSTRUCTOR
		public Fruit(string name, string description, float price, string categoryName, string origin, string typeOfFruit, int tax = 22, bool packed = false) :base(name, description, price, categoryName, tax)
		{
			this.origin = origin;
			this.typeOfFruit = typeOfFruit;
			this.packed = packed;
		}

		//GETTERS
		public string GetOrigin()
		{
			return origin;
		}

		public string GetTypeOfFruit()
		{
			return typeOfFruit;
		}

		public bool GetPackedInfo()
		{
			return packed;
		}

		//SETTERS
		public bool SetPacked(bool newPacked)
		{
			packed = newPacked;
			return packed;
		}


	}
}
