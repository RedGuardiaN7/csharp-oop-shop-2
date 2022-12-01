﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharpShop2
{
    public class Water : Product
    {
        //Attributi

        public double Litres { get; set; }

        public double Ph { get; }

        public string Source { get; set; }

        private double MaxCapacity;

        //------------ COSTRUTTORI ------------ //

        public Water(string name,string description, double price, double Litres, double Ph, string Source, double MaxCapacity = 1.5) : base(name, description, price)
        {
            this.Litres = Litres;
            this.Ph = Ph;
            this.Source = Source;
        }

        //---------- Definizioni dei metodi ---------- //

        //metodo bevi, che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti

        public void Drink(double DrinkLitres)
        {
            if (DrinkLitres > this.Litres)
            {

                Console.WriteLine("Impossibile bere più acqua di quanta ne è presente!");
            }
            else
            {
                this.Litres = this.Litres - DrinkLitres;
                Console.WriteLine("Dopo aver bevuto " + DrinkLitres + " l dalla bottiglia, ne sono rimasti " + this.Litres + " l");
            }
        }

        //metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua

        public void Fill(double Fill_Litres)
        {
            if ((Fill_Litres + this.Litres) > MaxCapacity)
            {
                Console.WriteLine("Wow, hai riempito troppo la bottiglia! (Max capacità: 1.5 l");
            }
            else
            {
                this.Litres += Fill_Litres;
                Console.WriteLine("Hai riempito la bottiglia di " + Fill_Litres + " l, ora la bottiglia ha " + this.Litres + " l");
            }
        }

        //metodo svuota che rimuove tutta l’acqua dalla bottiglia

        public void Empty()
        {
            this.Litres = 0;
            Console.WriteLine("La bottiglia è stata svuotata");
        }

        //Metodo che stampa a video tutte le informazioni del prodotto (override del product.cs)
        public virtual void Print(int num)
        {
            Console.WriteLine("-------------------- Bottiglia " + num + " ---------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + this.Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + this.Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Litri presenti nella bottiglia: " + this.Litres);
            Console.WriteLine();
            Console.WriteLine("PH: " + this.Ph);
            Console.WriteLine();
            Console.WriteLine("Sorgente: " + this.Source);
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Prezzo: " + FullPrice + "€");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

        }
    }
}


