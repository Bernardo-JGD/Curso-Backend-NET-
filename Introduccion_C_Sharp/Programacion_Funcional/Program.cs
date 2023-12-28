

Console.WriteLine(Sub(2, 1));
Console.WriteLine(GetTomorrow());
//1.2 Aquí es pura porque siempre recibe el mismo valor y va a retornar lo mismo
Console.WriteLine(GetTomorrow2(new DateTime(2023, 12, 27)));

var cerveza = new Cerveza1()
{
    Name = "Probando"
};

Console.WriteLine(ToUpper(cerveza).Name);
Console.WriteLine(cerveza.Name);
Console.WriteLine("---");
cerveza.Name = "probando";

Console.WriteLine(ToUpperPura(cerveza).Name);
Console.WriteLine(cerveza.Name);


//Funcion pura: Siempre recibe lo mismo y retorna lo mismo, no altera la entrada
int Sub(int a, int b)
{
    return a - b;
}

//Funcion impura
//En este caso está va a retornar valores distintos cada vez que se ejecute
DateTime GetTomorrow()
{
    return DateTime.Now.AddDays(1);
}

//1.1 Aquí podría parecer función impura, pero si en su llamado
//recibe una fecha en específico, siempre va retornar lo mismo
DateTime GetTomorrow2(DateTime date)
{
    return date.AddDays(1);
}


Cerveza1 ToUpper(Cerveza1 cerveza)
{
    //Aquí estoy modificando el atributo del objeto
    //por lo que deja de ser una función pura
    cerveza.Name = cerveza.Name.ToUpper();
    return cerveza;
}

Cerveza1 ToUpperPura(Cerveza1 cerveza)
{
    //Creo un objeto nuevo y lo retorno pero no altero el original
    var cerveza2 = new Cerveza1()
    {
        Name = cerveza.Name.ToUpper()
    };
    return cerveza2;
}

public class Cerveza1
{
    public string Name { get; set; }
}

