//A partire da quanto già fatto con csharp-oop-shop dove vi era stato chiesto di creare una classe Prodotto generica per gestire un generico prodotto dello Shop
//vi chiedo ora di essere più specifichi e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare nel nostro shop.

using СSharpShop2;

//Viene usato l'encoding per vedere correttamente il prezzo in console (€)


Console.OutputEncoding = System.Text.Encoding.UTF8;

Water Guizza = new Water("Acqua_Guizza", "Acqua naturale, povera di sodio.",  0.24, 1.5, 7.5, "Scorzè");

Guizza.Print(1);
Guizza.Drink(1);
Guizza.Fill(1);
Console.WriteLine();

FruitSnack ZIG = new FruitSnack("ZIG_Crunchy", "Frutta secca di provenienza certificata", 0.59, 30, 5, false, true);

ZIG.Print(1);
ZIG.EcoFriendly();
ZIG.Healthy();
Console.WriteLine();

LEGO Millenium_Falcon = new LEGO("Millenium_Falcon", "L'astronave più famosa della galassia, tutta da costruire!", 693.99, 75192, 7500, 1700, 18, false, false);

Millenium_Falcon.Print(1);
Millenium_Falcon.BuyBatteries();
Millenium_Falcon.ChildFriendly();
Console.WriteLine();

Blender Bosch = new Blender("Bosch_MultiTalent", "Il frullatore multi-funzione", 200, 1250, 220, 5.7, 3.9, "Rosso");

Bosch.Print(1);
