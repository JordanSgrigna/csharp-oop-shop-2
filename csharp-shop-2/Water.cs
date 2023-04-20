using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class Water : Product
	{
		//ATTRIBUTES
		private string name;
		private string brand;
		private int maxCapacity;
		private float pH;
		private string source;

		//CONSTRUCTOR
		public Water(string name, string brand, int maxCapacity, float pH, string source) : base(name)
		{
			this.brand = brand;
			this.maxCapacity = maxCapacity;
			this.pH = pH;
			this.source = source;
		}



		//GETTERS
		public string GetName()
		{
			return this.name;
		}
		
		public string GetBrand()
		{
			return this.brand;
		}

		public int MaxCapacity()
		{
			return this.maxCapacity;
		}

		public float GetpH()
		{
			return this.pH;
		}

		public string getSource()
		{
			return this.source;
		}

		//SETTERS
		public void setBrand(string newBrand)
		{
			this.brand = newBrand;
		}
		
	}
}
