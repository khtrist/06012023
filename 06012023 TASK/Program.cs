using System;
using System.Threading;

namespace _06012023_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nt1 = new Notebook { Name = "Acer ", Price = 1200, RAM = 2, Storage = 500 };
            var nt5 = new Notebook { Name = "MacBook", Price = 5200, RAM = 2, Storage = 300 };
            var nt6 = new Notebook { Name = "Samsung ", Price = 2200, RAM = 2, Storage = 1000 };
            var nt7 = new Notebook { Name = "Asus", Price = 3200, RAM = 2, Storage = 500 };
            var nt2 = new Notebook { Name = "Huawei ", Price = 4400, RAM = 2, Storage = 500 };
            var nt3 = new Notebook { Name = "Lenovo ", Price = 2600, RAM = 2, Storage = 400 };
            var ph1 = new Phone { Name = "Iphone 1", Price = 500, Camera = 4, SimCount = 1 };
            var ph2 = new Phone { Name = "Iphone 11", Price = 1500, Camera = 14, SimCount = 1 };
            var ph3 = new Phone { Name = "Iphone 12", Price = 2500, Camera = 4, SimCount = 1 };
            var ph4 = new Phone { Name = "Iphone 13", Price = 3500, Camera = 4, SimCount = 2 };
            var ph5 = new Phone { Name = "Iphone 14", Price = 3000, Camera = 4, SimCount = 3 };
            var ph6 = new Phone { Name = "Iphone 14 pro", Price = 3600, Camera = 4, SimCount = 1 };

            Product[] products = { nt1, ph1, nt2, ph2, nt3, ph3, ph4 ,nt5 ,nt6 , nt7 ,ph5,ph6 };

            string opt;
            do
            {
                Console.WriteLine("\n=================== MENU =====================\n");

                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax bax");
                Console.WriteLine("5. Telefonlarin sayina bax bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\n=================== PRODUCTS =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }
                        Console.Beep(466, 125);
                        Thread.Sleep(125);

                        break;
                    case "2":
                        Console.WriteLine("\n=================== NOTEBOOKS =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {

                                var nt = products[i] as Notebook;
                                Console.WriteLine(nt.Name + " - " + nt.Price + " " + nt.RAM);
                            }
                        }
                        Console.Beep(466, 125);
                        Thread.Sleep(125);
                        break;
                    case "3":
                        Console.WriteLine("\n=================== PHONES =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }

                        break;
                    case "4":
                        int notebookCount = 0;
                        Console.WriteLine("\n=================== NOTEBOOK count =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                                notebookCount++;
                        }

                        Console.WriteLine("Notebook say: " + notebookCount);
                        Console.Beep(466, 125);
                        Thread.Sleep(125);
                        break;
                    case "5":
                        int phoneCount = 0;
                        Console.WriteLine("\n=================== PHONE count =====================\n");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                phoneCount++;
                        }

                        Console.WriteLine("Phone say: " + phoneCount);
                        Console.Beep(466, 125);
                        Thread.Sleep(125);
                        break;
                    case "6":
                        int count = 0;
                        int sum = 0;
                        int orta = 0;
                        Console.WriteLine("\n ===================== NOTEBOOKS ORTALAMA QIYMET  =====================\n");
                        Product[] nts = products;
                        
                        for (int i = 0; i < nts.Length; i++)
                        {
                            if (nts[i] is Notebook)
                            {
                                count++;
                                sum += nts[i].Price;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Notebook yoxdur");
                            Console.Beep(466, 125);
                            Thread.Sleep(125);
                        }
                        else
                        {
                            orta = sum / count;
                        }

                        Console.WriteLine($"Notebooks Ortalama Qiymet: {orta}");
                        Console.Beep(466, 125);
                        Thread.Sleep(125); ;
                        break;
                    case "7":
                        int count2 = 0;
                        int sum2 = 0;
                        int orta2 = 0;
                        Console.WriteLine("\n ===================== PHONES Ortalama Qiymet  =====================\n");
                        Product[] phns = products;
                        for (int i = 0; i < phns.Length; i++)
                        {
                            if (phns[i] is Phone)
                            {
                                count2++;
                                sum2 += phns[i].Price;
                            }
                        }
                        if (count2 == 0)
                        {
                            Console.WriteLine("Telefon yoxdur");
                            Console.Beep(264, 125);
                        }
                        else
                        {
                            orta2 = sum2 / count2;
                        }

                        Console.WriteLine($"Phones Ortalama Qiymet: {orta2}");
                        Console.Beep(264, 125);
                        Thread.Sleep(125);
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi!");
                        Console.Beep(440, 500);
                        Thread.Sleep(125);
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin!");
                        Thread.Sleep(125);
                        Console.Beep(352, 1000);
                        break;
                }

            } while (opt != "0");



            

           
        }
    }
}
