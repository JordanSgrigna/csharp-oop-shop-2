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
		private float maxCapacity;
		private float initialLiters;
		private float pH;
		private string source;

		//CONSTRUCTOR
		public Water(string name, string description, float price, string categoryName, string brand, float maxCapacity, float initialLiters, float pH, string source, int tax = 22) : base(name, description, price, categoryName, tax)
		{
			this.brand = brand;
			this.maxCapacity = maxCapacity;
			this.initialLiters = initialLiters;
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

		public float GetMaxCapacity()
		{
			return this.maxCapacity;
		}

		public float GetInitialLiters()
		{
			return this.initialLiters;
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

		//METHODS
		public void Drink(float litersDrunk)
		{
			if (litersDrunk < this.maxCapacity && litersDrunk < initialLiters)
			{
				this.initialLiters = this.initialLiters - litersDrunk;
				Console.WriteLine("Hai bevuto: " + litersDrunk + "L" + " ora ne rimangono " + this.initialLiters);
			}
			else
			{
				throw new ArgumentException("Non puoi bere così tanto");
			}
			
		}

		public void Fill(float litersToPutIntoBottle)
		{
			if ((litersToPutIntoBottle + initialLiters) <= this.maxCapacity)
			{
				this.initialLiters += litersToPutIntoBottle;
				Console.WriteLine("Hai aggiunto: " + litersToPutIntoBottle + "L" + " ora ci sono " + this.initialLiters);

			}
			else
			{
				throw new ArgumentException("Non puoi riempire così tanto");
			}
		}

		public override string getProductInfo()
		{
			string infoProduct =
			$"Nome: {this.name} \n" +
			$"Marca: {this.brand} \n" +
			$"pH: {this.pH} \n" +
			$"Descrizione: {this.Description} \n" +
			$"Codice: {this.code} \n" +
			$"Prezzo: {this.Price} \n" +
			$"Categoria: \n";

			return infoProduct;

		}




	}
}
