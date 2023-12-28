
//**************************************** Creacion objetos interface
var venta = new Venta();
var cerveza = new Cerveza();
Some(venta);
Some(cerveza);
void Some(IGuardar algo)
{
    algo.Save();
}

//Formas de crear un objeto de una clase
Sale sale1 = new Sale(15);
Sale sale2 = new(16);
//Este "var" no es el mismo que el de javascript
//aquí no puedo asignarle un diferente tipo de dato a cada rato
var sale3 = new Sale(17);

var message = sale1.GetInfo();
Console.WriteLine(message);

message = sale2.GetInfo();
Console.WriteLine(message);

message = sale3.GetInfo();
Console.WriteLine(message);
class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
    }


    //public: todos pueden acceder a el
    //private: solo puedo acceder dentro de la misma clase
    //protected: la misma clase y sus hijos pueden acceder a el, pero no fuera de ellos
    //o sea, los objetos no pueden llamarlo

    //1.1 -- Para que un método pueda ser sobre escrito utilizo "virtual" en el padre...
    public virtual string GetInfo()
    {
        return "El total es: " + Total;
    }

}

class SaleWithTax: Sale
{

    public decimal Tax;

    public SaleWithTax(decimal total, decimal tax): base(total)
    {
        Tax = tax;
    }

    //1.2 -- y "override" en el hijo
    public override string GetInfo()
    {
        return "El total es: " + Total + " y los impuestos: " + Tax;
    }

    //Si quiero sobre cargar un método, puedo crear dos métodos con el mismo nombre
    //y mismo tipo de retorno, pero diferentes tipos de datos en sus parámetros

    public string GetInfo(int algunDato)
    {
        return "Algun dato: " + algunDato;
    }


}


//****************************************Creacion Interface
//Las clases que implementen una interface tienen que incluir/utilizar/contener
//los métodos o atributos declarados en la interface, por eso se dice que es como un contrato,
//porque es obligatorio que los contengan
interface IVenta
{
    decimal Total { get; set; }
}

interface IGuardar
{
    public void Save();
}

public class Venta : IVenta, IGuardar
{
    public decimal Total { get; set; }

    public void Save()
    {
        Console.WriteLine("Guardar en DB");
    }

}

public class Cerveza : IGuardar
{
    public void Save()
    {
        Console.WriteLine("Guardado en Service");
    }
}
