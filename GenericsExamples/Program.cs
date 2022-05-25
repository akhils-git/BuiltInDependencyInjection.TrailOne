using GenericsExamples;
using System.Text.Json;

Console.WriteLine("Generics exmples & JSON handling");

// Dynamic model setup
Responce<Student> responce1 = new Responce<Student>();
responce1.ErrorMessage = "No error";
responce1.ErrorNumber = 123;
responce1.Model= new Student();
responce1.Model.Name = "Ann";
responce1.Model.Age = 23;

// Dynamic model setup
Responce<Car> responce2 = new Responce<Car>();
responce2.ErrorMessage = "No error";
responce2.ErrorNumber = 123;
responce2.Model = new Car();
responce2.Model.PlateNumber = "KL 03 AE 5315";
responce2.Model.Color = "Green";

// C# object to JSON string
string jsonData= JsonSerializer.Serialize<Responce<Student>>(responce1);


// Data read from a JSON File
Responce<Car> responceObject = new Responce<Car>();
responceObject = JsonSerializer.Deserialize<Responce<Car>>(
    File.ReadAllText(@"C:\Users\Akhil\source\repos\BuiltInDependencyInjection.TrailOne\GenericsExamples\DemoData.json"))!;

Console.ReadKey();




