﻿// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System;

/*Esercizio:
In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover chiedere all’utente nessun input) tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code") per poi stamparne una piccola sintesi fatta bene.
Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
Titolo
Autore
ISBN
Numero pagine
Peso del libro
Larghezza, Altezza e Profondità del libro
Valutazione media
Numero di recensioni
se è disponibile in versione Kindle
se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
Un esempio è il seguente:
---------------IL LIBRO DI OGGI: << titolo >> di << autore >> ----------------
Informazioni generiche:
ISBN: << isbn >>
Numero delle pagine: << numeroPagine >> pagine
Peso del libro: << pesoLibro >> kg
Dimensioni del libro: << larghezza >> cm x << lunghezza >> cm x << profondita >> cm
Informazioni Amazon:
Numero di recensioni: << numeroRecensioni >> recensioni
Valutazione media: << valutazioneMedia >> stelline
Kindle disponibile: Si o No
Copertina flessibile disponibile: Si o No
*/

string titolo = "TITOLO";
string autore = "AUTORE";
long isbn = 1234567890123;
int nPagine = 200;
int peso = 10;
int larghezza = 10;
int altezza = 16;
int profondità = 4;
int valutazioneMedia = 0;
int recensioni = 0;
bool kindle = true;
bool flessibile = false;


Console.WriteLine("----IL LIBRO DI OGGGI: " + titolo + " di " + autore + "----");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero pagine: " + nPagine + " pagine");
Console.WriteLine("Peso del libro: " + peso + " kg");
Console.WriteLine("Dimensioni del libro: " + larghezza+ "cm x " + altezza + "cm x "+ profondità + "cm");
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






