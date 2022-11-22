// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System;

/*
BONUS:
Per chi di voi che se la sente può poi modificare questo programma, creando un nuovo progetto BONUS dove può cimentarsi nel rendere le variabili non più “hardcoded” nel codice e provare invece a chiedere le informazioni del libro direttamente all’utente tramite l’input della console.
*/

// mancano molti controlli sui dati in ingresso...
// soprattutto sui boolean

Console.WriteLine("Inserisci titolo");
string titolo = Console.ReadLine();
Console.WriteLine("Inserisci autore");
string autore = Console.ReadLine();
Console.WriteLine("Inserisci ISBN");
long isbn = long.Parse(Console.ReadLine());
Console.WriteLine("Inserisci numero pagine");
int nPagine = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci peso");
int peso = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci larghezza");
int larghezza = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci altezza");
int altezza = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci profondità");
int profondità = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci media delle valutazioni");
int valutazioneMedia = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci numero delle recensioni");
int recensioni = int.Parse(Console.ReadLine());
Console.WriteLine("C'è in formato kindle? true o false");
bool kindle = bool.Parse(Console.ReadLine());
Console.WriteLine("C'è in copertina flessibile? true o false");
bool flessibile = bool.Parse(Console.ReadLine());


Console.WriteLine("----IL LIBRO DI OGGGI: " + titolo + " di " + autore + "----");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero pagine: " + nPagine + " pagine");
Console.WriteLine("Peso del libro: " + peso + " kg");
Console.WriteLine("Dimensioni del libro: " + larghezza + "cm x " + altezza + "cm x " + profondità + "cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero recensioni: " + recensioni + " recensioni");
Console.WriteLine("valutazione media : " + valutazioneMedia + " stelle");

if (kindle)
{
    Console.WriteLine("Formato kindle: SI");
}
else
{
    Console.WriteLine("Formato kindle: NO");
}
if (flessibile)
{
    Console.WriteLine("Copertina flessibile: SI");
}
else
{
    Console.WriteLine("Copertina flessibile: NO");
}






