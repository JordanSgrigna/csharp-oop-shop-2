using csharp_shop_2;

Shop Eurospin = new Shop("Eurospin", "Roma", "Via Paolo", "42");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
Eurospin.AddNewProductToShopList(AcquaSantAnna);



SellingBag Busta1 = new SellingBag("Busta", "Plastica", 0.2f, "Buste", "Plastica", 5);
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicialia", "Agrume");

Eurospin.AddNewProductToShopList(Limone);
Limone.getProductInfo();

Eurospin.PrintShopInfo();




