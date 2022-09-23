// See https://aka.ms/new-console-template for more information



StreamReader file = File.OpenText("../../../addresses.csv");

List<Address> addresses = new List<Address>();

//Console.WriteLine(file.ReadToEnd());

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    Console.WriteLine(line);
    
}


file.Close();


public class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }


}

