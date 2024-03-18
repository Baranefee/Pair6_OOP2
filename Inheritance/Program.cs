// See https://aka.ms/new-console-template for more information
using Inheritance.Example1;
using Inheritance.Example2;


Student student = new Student();
student.Id = 1;
student.FirstName = "Baran";
student.LastName = "efe";
student.Status = true;
student.Department = "Computer Science";
student.GPA = 2.76;

Instructor instructor = new Instructor();
instructor.Id = 2;
instructor.FirstName = "Muhammed";
instructor.LastName = "Inan";
instructor.Status = false;
instructor.Title = "Kidemli egitmen";
instructor.Branch = "Computer Science";

Console.WriteLine("Egitmen  bilgileri \n" +instructor.Id +" \n"+ instructor.FirstName + " \n" + instructor.LastName + " \n" + instructor.Status + " \n" + instructor.Title + " \n" + instructor.Branch);
Console.WriteLine("---------------------");
Console.WriteLine("Ogrenci bilgileri \n" +student.Id + " \n" + student.FirstName + " \n" + student.LastName + " \n" + student.Status + " \n" + student.Department + " \n" + student.GPA);

Car car = new Car();
car.Id = 1;
car.TopSpeed = 250;
car.WheelNumber = 4;
car.TrunkVolume = 55.60;

Bus bus = new Bus();    
bus.Id = 2;
bus.TopSpeed = 150;
bus.WheelNumber = 6;
bus.PassengerCapacity = 40;


