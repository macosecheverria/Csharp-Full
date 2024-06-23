//Tipos de datos primitivos
byte numeroByte = 127;
short numeroShort = 2045;
int numeroEntero =  23;
float numeroFloat = 12.45f;
double numeroDouble = 123439.324324d;
char letra = 'n';
string palabra = "soy un texto";

Console.WriteLine(numeroByte);
Console.WriteLine(numeroShort);
Console.WriteLine(numeroEntero);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(letra);
Console.WriteLine(palabra);

//Arreglos y Matrices
string[] nombres1 = {"Marcos","Jose","Junior","Erik","Derlis"};
foreach (var i in nombres1)
{
    Console.WriteLine(i);
}

string[] nombres2 = new string[4];
nombres2[0] = "Yeniffer";
nombres2[1] = "Jessica";
nombres2[2] = "Maria";
nombres2[3] = "Juana";

foreach (var i in nombres2)
{
    Console.WriteLine(i);
}


// condicionales

string nombreStr = "marcos";
string nombreStr2 = "MARCOS";

if (nombreStr.Equals(nombreStr2.ToLower()))
{
    Console.WriteLine("Son el mismo nombre");
}

