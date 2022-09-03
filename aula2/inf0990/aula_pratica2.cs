/*
var o = new Octopus("Jack");
Console.WriteLine(o.Name); 
o.Legs = 20;
class Octopus{
    public readonly string Name;
    public readonly int Legs = 8;

    public Octopus(string name){
        Name = name;
    }
}
*/

/*
Console.WriteLine(Test.Message); //hello world

public class Test{
    public const string Message = "Hello World";
    public const double twoPI = 2 * System.Math.PI; //Computação execuada em tempo de compilaçao
}
*/

/*
int x = 3;
Foo();

//Foo é um metodo local
void Foo() => Console.WriteLine(x); //Podemos acessar x
*/

/*
Octopus o = new Octopus();

o.Foo(123);         // int
o.Foo(123.0);       // double
o.Foo(123, 123F);   // int, float
o.Foo(123F, 123);   // float, int

class Octopus
{
    public void Foo(int x)         { Console.WriteLine("int"); }
    public void Foo(double x)      { Console.WriteLine("double"); }
    public void Foo(int x, float y) { Console.WriteLine("int, float"); }
    public void Foo(float x, int y) { Console.WriteLine("float, int"); }
}
*/

/*
class Octopus
{
  void Foo(int x) {}
  float Foo(int x) {}      // Erro de compilação
}
//Tipo "Octopus" já define um membro chamado "Foo" 
//com os mesmos tipos de parâmetro 
//[C:\Users\msft57\aula2\inf0990\aula2\inf0990\inf 0990.csproj]
*/

/*
Panda p = new Panda("Petey");   // Chamada de construtor

public class Panda
{
  string name;                 
  public Panda(string n)        // Definição do Construtor: observe que o método não tem um tipo de retorno
  {
    name = n;                   // Código de inicialização da variável name 
  }
}
*/


/*
new Wine(78);
new Wine(78, 2001);

public class Wine
{
  public decimal Price;
  public int Year;

  public Wine(decimal price)    // Construtor
  { 
    Price = price;
  }

  public Wine(decimal price, int year) : this (price)  // Construtor
  { 
    Year = year; 
  }
}
*/

/*
Class1 c1 = Class1.Create();  // OK
Class1 c2 = new Class1();    // Erro: Não irá compilar

public class Class1
{
  Class1() { }        // Construtor privado
  
  public static Class1 Create()
  {
    // Execução de alguma lógica para configurar a instanciação da classe Class1
    return new Class1();
  }
}

//"Class1.Class1()" é inacessível devido ao seu nível de proteção 
*/



/*
var rect = new Rectangle(3, 4);              // Criação de objeto do tipo Rectangle

(float width, float height) = rect;            // Desconstrução
Console.WriteLine(width + " " + height);    // 3 4

// O uso de tipagem implícita é usada com a palavra-chave var:  
var (x, y) = rect;                           // Desconstrução
Console.WriteLine(x + " " + y);

// Se as variáveis já foram declaradas, podemos apenas chamar o desconstrutor
(x, y) = rect; 
Console.WriteLine(x + " " + y);

// A partir do C#, é permitido o uso de sintaxe mista
double x1 = 0;
(x1, double y2) = rect;
Console.WriteLine(x + " " + y);

class Rectangle
{
  public readonly float Width, Height;

  public Rectangle(float width, float height)
  {
    Width = width;
    Height = height;
  }

  public void Deconstruct(out float width, out float height)    // Declaração do método desconstrutor
  {
    width = Width;
    height = Height;
  }
}
*/


/*
Bunny b1 = new Bunny { Name="Bo", LikesCarrots=true, LikesHumans=false }; // Inicialização em conjunto, com a nomeação das propriedades e campos
Bunny b2 = new Bunny ("Bo")     { LikesCarrots=true, LikesHumans=false }; // Inicialização após a chamada do construtor

Console.WriteLine(b1.Name);   // Bo
Console.WriteLine(b2.Name);   // Bo

public class Bunny
{
  public string Name;
  public bool LikesCarrots;
  public bool LikesHumans;
  
  public Bunny () {}
  public Bunny (string n) { Name = n; }
}
*/



/*
Widget w = new Widget();
w.Foo();                        // Widget's implementation of I1.Foo
((I1)w).Foo();                  // Widget's implementation of I1.Foo
((I2)w).Foo();                  // Widget's implementation of I2.Foo

interface I1 { void Foo(); }
interface I2 { int Foo(); }

public class Widget : I1, I2    // Implementação de múltiplas interfaces
{
  public void Foo ()
  {
    Console.WriteLine("Widget's implementation of I1.Foo");
  }
  
  int I2.Foo()                  // Implementação explicita de método da interface
  {
    Console.WriteLine("Widget's implementation of I2.Foo");
    return 42;
  }
}
*/
