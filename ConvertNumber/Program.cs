// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



    Console.WriteLine("Donner un chiffre");
int nb = int.Parse(Console.ReadLine());
int valeur = 0;
int i = 0;
String valeurhexadecimal = "";

while (nb != 0)
{
    valeur = nb % 16;
    if(valeur < 10)
        //converti en sa valeur ascii pour avoir un char 
        valeur = valeur + 48;
    else
        valeur = valeur + 55;
    valeurhexadecimal +=  Convert.ToChar(valeur);
    nb = nb / 16;
}

Console.Write("La valeur est: ");
for (i = valeurhexadecimal.Length - 1; i >= 0; i--)
{
    Console.Write(valeurhexadecimal[i]+" ");
}
Console.WriteLine();