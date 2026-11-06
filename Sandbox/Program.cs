
using Sandbox;

int edad = 15;
double altura = 1.80;
string nombre = "Juan";
bool esEstudiante = false;
const double PI = 3.1416;
const string NOMBRE_PAIS = "México";

string[] nombres = { "Juan", "María", "Pedro" };


persona juan = new persona(nombre, edad, 1);
persona maria = new persona("María", 20, 2);

Console.WriteLine("Nombre: " + juan.nombre +" Edad: " + juan.edad);
Console.WriteLine("Altura: " + juan.calculaAltura());

Console.WriteLine("*****************/n");

Console.WriteLine("Nombre: " + maria.nombre + " Edad: " + maria.edad);
Console.WriteLine("Altura: " + maria.calculaAltura());

Console.WriteLine("*****************/n");
Console.WriteLine("*****************/n");

if (edad >= 18)
{
    Console.WriteLine("Nombre: " + nombre);
}
else
{
    Console.WriteLine("Eres estudiante: " + esEstudiante);
}

Console.WriteLine("*****************/n");

for (int i = 0; i < NOMBRE_PAIS.Length; i++)
{
    Console.WriteLine(NOMBRE_PAIS.Substring(i, 1));
}

Console.WriteLine("*****************");
foreach (var nom in nombres)
{
    Console.WriteLine("Nombre: " + nom);   
}

///while (true) 
/// Listas (list<>)
/// 

//Metodos 

Console.WriteLine("*****************");
void Saludar(string nombre)
{
    Console.WriteLine( nombre);
}

string Saludar2(string nombre)
{
    return "Hola " + nombre;
}

Saludar(Saludar2("María"));

//Console.WriteLine(nombres[0]);

//Console.WriteLine("Hola Mundo!!");
