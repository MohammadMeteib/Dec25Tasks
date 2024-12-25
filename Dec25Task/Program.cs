using Dec25Task.Models;
Demo info = new Demo();

Console.WriteLine("Enter Username");
info.Username = Console.ReadLine();
info.GetUsername();

Console.WriteLine("Enter Salary");
info.Salary = Convert.ToInt32(Console.ReadLine());
