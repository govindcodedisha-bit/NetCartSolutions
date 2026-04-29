using NetCart.ConsoleUI;
using NetCart.Core;
using NetCart.Core.Entities;
using System.Reflection.Metadata;
using System.Threading.Channels;


//Product product = new ElectronicProduct("Laptop", "Laptop Desciption", "SKU-OOP-001", 990000m, "Model Name", "00934343434", 2026);
//Product cloth = new ClothProduct("T-Shirt", "Desciption ", "SKU001-909", 199, 40, "red");

//Console.WriteLine("============Electronic Details================");
//Console.WriteLine(product.Id);
//Console.WriteLine(product.Name);
//Console.WriteLine(product.Price);

//Console.WriteLine("============Clothing Details================");
//Console.WriteLine(cloth.Id);
//Console.WriteLine(cloth.Name);
//Console.WriteLine(cloth.Price);


//product.RemoveStock(25);

//product.AddStock(20);
//product.UpdateStock(20);
//product.Deactivate();
//product.Activate();

//cloth.RemoveStock(10);
//cloth.AddStock(20);
//cloth.UpdateStock(20);
//cloth.Deactivate();
//cloth.Activate();


//SuperAdmin superAdmin = new SuperAdmin();
//superAdmin.UserMethod();
////superAdmin.AdminDisplay();
////superAdmin.SuperAdminDisplay();
MethodOverloadingDemo a = new MethodOverloadingDemo();
a.RunDemo();

RuntimePolyMorphism runObj = new RuntimePolyMorphism();
runObj.RunDemo();




