//Funcion anonima: 
//Es una funcion que no necesita declararse, no tiene nombre
//pero si tiene definido que es lo que hace

//Esto es una funcion flecha
//Dentro de los <>, de izquierda a derecha cada tipo de dato especificado corresponde
//al tipo de dato de los parametros que se van a recibir, en este caso a, b, por eso
//donde está (a, b) es opcional indicar el tipo de dato ya que se especifico antes,
//pero el último valor dentro de <> corresponde al tipo de retorno, en este caso int
Func<int, int, int> sub = (a, b) => a - b;
//Que es lo mismo que si escribieramos esto
int sub2(int a, int b)
{
    return a - b;
}

//Cuando solo se recibe un parámetro no es necesario colocar los paréntesis
Func<int, int> mul = a => a * 5;

Func<int, int> some = a =>
{
    a = a + 1;
    return a *5;
};

//La expresion lambda es todo los que está después de "=>"
//El nombre que se le pone a cada función se comporta como una variable
//como lo vimos en funciones de primera clase y funciones de orden superior

Console.WriteLine(some(5));

Sumando((a, b) => a +b, 5);

void Sumando(Func<int, int, int> fn, int number)
{
    var resultado = fn(number, number);
}