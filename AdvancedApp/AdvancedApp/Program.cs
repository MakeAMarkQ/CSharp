using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace AdvancedApp
{
    // Delegate STEP 1: declare delegate
    public delegate void MyDelegate(string text);
    public class Cat
    {
        public string name { get; set; }
        public MyDelegate mydel;
        public void CatWalks(string arg)
        {
            Console.WriteLine(name + " walks " + arg);
        }
        public void SayMessage(string message)
        {
            if (mydel != null)
            {
                mydel.Invoke(message);
            }
        }
        public void ReadMessage(string message)
        {
            Console.WriteLine(name + " received message: " + message);
        }
        public void AddListener(Cat arg)
        {
            mydel += arg.ReadMessage;
        }
        public void DeleteListener(Cat arg)
        {
            mydel -= arg.ReadMessage;
        }
    }
    //
    // EVENT HANDLING!
    //
    // 1) Create delegate that handles price change...
    public delegate void PriceChangeHandler(string message, int oldprice, int newprice);
    public class Stock
    {
        // 2) use delegate in this class as event handler
        public event PriceChangeHandler myhandler;
        // use handler
        private int price;
        public int Price
        {
            get { return price; }
            // 3) fire event whenever price changes
            set
            {
                int oldprice = price;
                price = value;
                // event is fired if myhandler is not empty
                string message = (price > oldprice) ? "STOCK_RISE" : "STOCK_DOWN";
                myhandler?.Invoke(message, oldprice, price); // fire event!
            }
        }
        public void PriceCrash()
        {
            // event can also be fired directly from broadcaster!
            myhandler?.Invoke("STOCK_CRASH", 0, 0); // fire event!
        }
    }
    public class StockBroker
    {
        public void Subscribe(Stock arg)
        {
            arg.myhandler += this.handleMessage;
        }
        public void UnSubscribe(Stock arg)
        {
            arg.myhandler -= this.handleMessage;
        }
        public void handleMessage(string message, int oldprice, int newprice)
        {
            switch (message)
            {
                case "STOCK_RISE":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Stock is rising to " + newprice);
                    break;
                case "STOCK_DOWN":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Stock is falling from " + oldprice + " to " + newprice);
                    break;
                case "STOCK_CRASH":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("STOCK CRASHED!");
                    break;
            }
        }
    }
    class Program
    {
        static void MyMethod(string text)
        {
            Console.WriteLine("MyMethod says " + text);
        }
        static void MyMethodToo(string text)
        {
            Console.WriteLine("MyMethodToo says " + text);
        }
        public static MyDelegate mydelegate;
        static void Main(string[] args)
        {
            // tehdään oma delegaatti, joka osoittaa haluttuun metodiin
            // MyDelegate kertoo että sen on oltava sama signature
            // void <mettodin nimi>(string text) 
            mydelegate = new MyDelegate(MyMethod);
            mydelegate.Invoke("message");
            mydelegate("another message");
            // multicastaus tehdään += syntaxilla!
            mydelegate += MyMethodToo;
            // multicasting to multiple methods
            mydelegate("multicast!");
            // poistetaan metodit delegaatilta
            mydelegate -= MyMethod;
            mydelegate -= MyMethodToo;
            // Cat is a class with CatWalks()
            Cat jenny = new Cat();
            jenny.name = "Jenny";
            Cat kalle = new Cat();
            kalle.name = "Kalle";
            mydelegate += jenny.CatWalks;
            mydelegate += kalle.CatWalks;
            mydelegate("PRETTY!");
            // Tehkää muutokset niin, että saatte
            // jennyn sanomaan tämän viestin kallelle.
            mydelegate -= jenny.CatWalks;
            mydelegate -= kalle.CatWalks;
            jenny.AddListener(kalle);
            jenny.SayMessage("PUTTEPOSSU");
            jenny.AddListener(jenny);
            jenny.SayMessage("VIRVE");
            jenny.DeleteListener(jenny);
            jenny.SayMessage("SAARA");
            // kallella ei ole kuuntelijaa, joten viesti EI mene läpi
            kalle.SayMessage("RIKKI");
            // tehdään eventtejä

            Stock myStock = new Stock();
            myStock.Price = 10;
            myStock.Price = 20;
            StockBroker terhi = new StockBroker();
            terhi.Subscribe(myStock);
            myStock.Price = 30;
            myStock.Price = 35;
            myStock.Price = 32;
            myStock.PriceCrash();
            terhi.UnSubscribe(myStock);
            myStock.Price = 40;
            Console.BackgroundColor = ConsoleColor.Black;
            // tehdään lambda funktioita.
            Func<int, int> myfunc = x => x * x;
            Func<int, int, int> myfuncToo = (x, y) => x + y;
            Func<int> myfuncTooToo = () => 123;
            Func<int, int, bool> myTernaryTest = (a, b) => (a > b) ? true : false;
            // nyt funktioita voidaan kutsua
            Console.WriteLine(myTernaryTest(10, 2));
            // vit tehdä funktion, jota kutsut tästä
            MySpecialDelegate myDelegate = delegate (int x, int y) { return x * y; };
            int res1 = myDelegate(2, 2);
            int res2 = myDelegate(2, 4);
            try
            {
                // avataan rajapinnan takana olevia resursseja
                // tehdään jotain rajapinnan kanssa...
                GenerateError(null);
            }
            catch (ArgumentNullException ex)
            {
                // jos toiminto kaatuu mennään tänne
                // Ilmoitus käyttäjälle + logitus
                Console.WriteLine("Oh dear! Argument Null found! ");
                Console.WriteLine("paramname is " + ex.ParamName + " with " + ex.Message);
            }
            catch (Exception exception)
            {
                // this gets ALL errors
                // jos toiminto kaatuu mennään tänne
                // Ilmoitus käyttäjälle + logitus
                Console.WriteLine("Teacher Generated This!");
                Console.WriteLine(exception);
            }
            finally
            {
                // ja tänne mennään joka tapauksessa
                // (täällä suljet KAIKKI rajapinnan yli menevät resurssit)
            }
            Console.ReadLine();
        }
        public delegate int MySpecialDelegate(int i, int y);
        public static void GenerateError(string argument)
        {
            if (argument == null)
                throw new ArgumentNullException("GenerateError", "DEBUG_GENERATED_ERROR");
        }
    }
}
