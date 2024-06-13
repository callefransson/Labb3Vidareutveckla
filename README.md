# Labb3Vidareutveckla
Denna labb gick ut på att vidarutveckla en applikation genom att lägga till funktioner för att tillaga/förbereda kaffe, cappuccino och choklad.
Vi skulle fortsätta utveckla dessa funktioner med samma designmönster som var implementerat innan i koden, utan att lägga till fler designmönster eller sluta att använda dem.
I denna labb så var det Factory Method mönstret som var implementerat och för att fortsätta använda samma designmönster för att lägga till fler drycker i programmet
så skapade jag först tre olika klasser, Coffee, HotChocolate och Cappuccino där alla ärver gränsnittet IWarmDrink för att sedan kunna skriva ut konsumtion av drycken
Sedan skapade jag tre olika factoryklasser för dessa drycker som ärver IWarmDrinkFactory gränsittet där vi skapar nya instanser av dessa drycker.
I WarmDrinkMachine klassen la jag till dessa factoryklasser i konstruktorn för att registrera fabrikerna. 
