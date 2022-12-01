//A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe Prodotto generica per gestire un generico prodotto dello Shop
//vi chiedo ora di essere più specifichi e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare nel nostro shop.

using СSharpShop2;

//Viene usato l'encoding per vedere correttamente il prezzo in console (€)


Console.OutputEncoding = System.Text.Encoding.UTF8;

Water Guizza = new Water("Acqua_Guizza", "Acqua naturale, povera di sodio.",  0.44, 1.5, 7.5, "Scorzè");

Guizza.Drink(1);
Guizza.Fill(1);
Console.WriteLine();
Guizza.Print(1);

FruitSnack ZIG = new FruitSnack("ZIG_Crunchy", "Frutta secca di provenienza certificata", 1.99, 30, 7, false, true);

ZIG.EcoFriendly();
ZIG.Healthy();
Console.WriteLine();
ZIG.Print(1);

