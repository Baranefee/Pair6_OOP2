// See https://aka.ms/new-console-template for more information
using Polymorphism.Example1;
using Polymorphism.Example2;


ILoan farmerLoan = new FarmerLoan();
ILoan businessLoan = new BusinessLoan();


farmerLoan.Calculate();
businessLoan.Calculate();


Console.WriteLine("---------------------------------");

Animal cat  = new Cat();
cat.Voice();
Animal dog  = new Dog();    
dog.Voice();



Console.WriteLine("---------------------------------");

