using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class SellingBag: Product
	{
		//ATTRIBUTES
		private string typeOfBag;
		private int maxNumberOfFruits;
		private List<Fruit> fruitsInBag;

		//COSTRUCTOR
		public SellingBag(string name, string description, float price, string categoryName, string typeOfBag, int maxNumberOfFruits, int tax = 22) : base(name, description, price, categoryName, tax)
		{
			this.typeOfBag = typeOfBag;
			this.maxNumberOfFruits = maxNumberOfFruits;
			this.fruitsInBag = new List<Fruit>();
		}

		//GETTERS
		public string GetTypeOfBag()
		{
			return this.typeOfBag;
		}

		public int GetMaxNumberOfFruits()
		{
			return this.maxNumberOfFruits;
		}

		public List<Fruit> getFruitsInBag()
		{
			return this.fruitsInBag;
		}

		//METHODS
		public void GetFruitInBag(Fruit newFruit)
		{
			if (this.fruitsInBag.Count < maxNumberOfFruits)
			{
				this.fruitsInBag.Add(newFruit);
			}
		}

		public void GetListOfFruitInbag(List<Fruit> newFruitList)
		{
			foreach(Fruit newFruitListToAdd in newFruitList)
			{
				this.fruitsInBag.Add(newFruitListToAdd);
			}
		}

		


	}
}
