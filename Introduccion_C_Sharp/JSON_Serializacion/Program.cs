using System.Text.Json;

var kirby = new People()
{
    Name = "Kirby",
    Age = 200
};

string json = JsonSerializer.Serialize(kirby);
Console.WriteLine(json);

string myJson = @"{
    ""Name"":""Poyo"",
    ""Age"":200
}";

People poyo = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(poyo.Name);
Console.WriteLine(poyo.Age);
//Puedo proteger las excepciones sobre null con un ?
//Ejemplo:
/*
People? poyo = null;
Console.WriteLine(poyo?.Name);
Console.WriteLine(poyo?.Age); 
 */


public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}