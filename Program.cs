// See https://aka.ms/new-console-template for more information



using System.Text.RegularExpressions;

StreamReader file = File.OpenText("../../../addresses.csv");

List<Address> addresses = new List<Address>();

//Console.WriteLine(file.ReadToEnd());
file.ReadLine();
while (!file.EndOfStream)
{
    
    string line = file.ReadLine();
    if (line.Split(",").Length > 6)
    {
        string str = line;
        Regex regReplace = new Regex(",");
        string res = regReplace.Replace(line, " ", 1);
        line = res;
    }

    string[] strings = line.Split(",");
   
    try
    {
        foreach (string s in strings)
        {
            int i = 0;
            if (strings[i] == "" || strings[i] == " ")
            {
                strings[i] = " - ";
            }
        }
       

        string newName = strings[0].Trim();
        string newSurname = strings[1].Trim();
        string newStreet = strings[2].Trim();
        string newCity = strings[3].Trim();
        string newProvince = strings[4].Trim();
        string newZip = strings[5].Trim();

        
        addresses.Add(new Address(newName, newSurname, newStreet, newCity, newProvince, newZip));
    }
    catch
    {
    }
    
}

file.Close();
foreach(Address address in addresses)
{
    address.Print();
}


public class Address
{
    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }

 
    public void Print()
    {
        Console.WriteLine("---------");
        Console.WriteLine(Name);
        Console.WriteLine(Surname);
        Console.WriteLine(Street);
        Console.WriteLine(City);
        Console.WriteLine(Province);
        Console.WriteLine(Zip);
        Console.WriteLine("---------");


    }
}

