

//Una funcion de primera clase puede ser asignada a una variable
var show = Show;
show("Hola");
Console.WriteLine("----------");
//Una funcion de orden superior puede recibir otras funciones como parámetros
Some(show, "Hola como estas");

//Funcion de primera clase
//Funcion de tipo Action: recibe elementos pero no retorna nada
void Show(string message)
{
    Console.WriteLine(message);
}

//Esta es una funcion de orden superior ya que recibe funciones como parámetro
void Some(Action<string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    fn(message);
    Console.WriteLine("Hace algo al final");
}

var show2 = Show2;
Some2(show2, "Hola como estas 2");

string Show2(string message)
{
    //string aquí no modifica la variable original,
    //crea uno nuevo y lo muestra/retorna segun sea el caso
    return message.ToUpper();
}

//Func, a diferencia de Action, trabaja con funciones que retornan algo
//Entre los <> el ultimo tipo es el de retorno
void Some2(Func<string, string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio 2");
    Console.WriteLine(fn(message));
    Console.WriteLine("Hace algo al final 2");
}