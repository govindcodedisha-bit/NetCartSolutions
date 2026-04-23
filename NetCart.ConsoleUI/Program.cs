using NetCart.Core;
using NetCart.Core.Entities;
using System.Threading.Channels;

//ElectronicProduct product = new ("Laptop", 550000m, "Dell", "ADUDD56565", 2026);
//ClothProduct cloth = new("T-Shirt", 199, 40, "red");
try
{

    ElectronicProduct product = new ElectronicProduct("Laptop", "Laptop Desciption", "SKU-OOP-001", 990000m, "Model Name", "00934343434", 2026);
    Product cloth = new ClothProduct("T-Shirt", "Desciption ", "SKU001-909", 199, 40, "red");

    Console.WriteLine("============Electronic Details================");
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Brand);
    Console.WriteLine(product.ModelNumber);
    Console.WriteLine(product.ManifacturingYear);

    Console.WriteLine("============Clothing Details================");
    Console.WriteLine(cloth.Id);
    Console.WriteLine(cloth.Name);
    Console.WriteLine(cloth.Price);


    product.UpdateDetails("Dell Laptop", "Dell Laptop with 16 gb ram 256 gb storage.");

    product.RemoveStock(25);

    product.AddStock(20);
    product.UpdateStock(20);
    product.Deactivate();
    product.Activate();
}
catch (Exception ex)
{
    Console.WriteLine("Error", ex);
}


