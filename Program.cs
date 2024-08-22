// See https://aka.ms/new-console-template for more information
using Aquarium;

AquariumSystem system = new AquariumSystem();

Main();

void Main()
{
    system.MainSystem();
}

/*
 Skal lage en C# konsollapplikasjon som imiterer et akvarium,
med masse instanser av fisker. Hver "art" av fisk skal arve fra en
felles klasse Fisk. 
Interface, Arv og Enum. INNKAPSLING

Plan :

- lage arv av forskjellige fiskearter,
- lage interface av forskjellige akvarier, typ goTo ferskvannsakvarie, eller tapGlass på et spesifikt et
- lage enum av forksjellige steder fiskene eksisterer
 */
