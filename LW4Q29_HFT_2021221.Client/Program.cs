using ConsoleTools;
using LW4Q29_HFT_2021221.Models;
using LW4Q29_HFT_2021221.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LW4Q29_HFT_2021221.Client
{
    class Program
    {
        static RestService rest = new RestService("http://localhost:45168");
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(3000);

            var SeriesMenu = new ConsoleMenu(args, level: 1)
                .Add("List Series", () => List<Series>("Series"))
                .Add("Add Series", () => AddSeries())
                .Add("Update Series", () => UpdateSeries())
                .Add("Delete Series", () => Delete<Series>("Series"))
            .Add("Exit", ConsoleMenu.Close);
            var GenerationMenu = new ConsoleMenu(args, level: 1) 
                .Add("List Generations", () => List<Generation>("Generation"))
                .Add("Add Generation", () => AddGeneration())
                .Add("Update Generation", () => UpdateGeneration())
                .Add("Delete Generation", () => Delete<Generation>("Generation"))
            .Add("Exit", ConsoleMenu.Close);

            var GraphicCardMenu = new ConsoleMenu(args, level: 1)
                .Add("List GraphicCards", () => List<GraphicCard>("GraphicCard"))
                .Add("Add GraphicCard", () => AddGraphicCard())
                .Add("Update GraphicCard", () => UpdateGraphicCard())
                .Add("Delete GraphicCard", () => Delete<GraphicCard>("GraphicCard"))
            .Add("Exit", ConsoleMenu.Close);




            var noncrud_menu = new ConsoleMenu(args, level: 1)
                .Add("CheapestLHRSeries", () => CheapestLHRSeries())
                .Add("HugeGpuFactory", () => HugeGpuFactory())
                .Add("NvidiaGpus", () => NvidiaGpus())
                .Add("MinerCard", () => MinerCard())
                .Add("NvidiaSamsungRam", () => NvidiaSamsungRam())
            .Add("Exit", ConsoleMenu.Close);


            var menu = new ConsoleMenu(args, level: 0)
                                       .Add("Seriess", SeriesMenu.Show)
                                       .Add("Generations", GenerationMenu.Show)
                                       .Add("GraphicCards", GraphicCardMenu.Show)
                                       .Add("Noncruds", noncrud_menu.Show)
                                       .Add("Exit", () => Environment.Exit(0)) 
              .Configure(config =>
              {
                  config.Selector = ">> ";
                  config.EnableFilter = false;
                  config.ClearConsole = true;
                  config.Title = "Main menu";
                  config.EnableWriteTitle = true;
                  config.EnableBreadcrumb = false;
              });

            menu.Show();
        }
        static void CheapestLHRSeries()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "CheapestLHRSeries".Length) / 2, Console.CursorTop);
            Console.WriteLine("CheapestLHRSeries");
            var List = rest.Get<Generation>("stat/CheapestLhr");
            foreach (var item in List)
            {
                Console.WriteLine("\t>>Cheapest: " + item.Name+"\n");
            }
            Console.ReadLine();
        }
        static void HugeGpuFactory()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "HugeGpuFactory".Length) / 2, Console.CursorTop);
            Console.WriteLine("HugeGpuFactory");
            var List = rest.Get<KeyValuePair<string, int>>("stat/HugeGpuFactory");
            foreach (var item in List)
            {
                Console.WriteLine("\t>>Factory: " + item.Key + "\n\tCount: " + item.Value + "\n");
            }
            Console.ReadLine();
        }
        static void NvidiaGpus()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "NvidiaGpus".Length) / 2, Console.CursorTop);
            Console.WriteLine("NvidiaGpus");
            var List = rest.Get<KeyValuePair<string, int>>("stat/NvidiaGpus");
            foreach (var item in List)
            {
                Console.WriteLine("\t>>Nvidias: " + item.Key + "\n\t" + item.Value + "\n");
            }
            Console.ReadLine();
        }
        static void MinerCard()
        {

            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "MinerCard".Length) / 2, Console.CursorTop);
            Console.WriteLine("MinerCard");
            var q = rest.Get<KeyValuePair<string, int>>("stat/MinerCard");
            foreach (var item in q)
            {
                Console.WriteLine("\t>>GraphicCard: " + item.Key + "\n\t>>Price: " + item.Value + "\n");
            }
            Console.ReadLine();
        }
        static void NvidiaSamsungRam()
        {

            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "NvidiaSamsungRam".Length) / 2, Console.CursorTop);
            Console.WriteLine("NvidiaSamsungRam");
            var GenerationList = rest.Get<KeyValuePair<string, int>>("stat/NvidiaSamsungRam");
            foreach (var item in GenerationList)
            {
                Console.WriteLine("\t>>Name: " + item.Key + " " + item.Value + "\n");
            }
            Console.ReadLine();
        }
        static void List<T>(string path)
        {
            MenuLayout("List");
            var List = rest.Get<T>(path);
            foreach (var item in List)
            {
                Console.WriteLine(item.ToString() + "\n") ;
            }
            Console.ReadLine();
        }
        static void Delete<T>(string path)
        {
            MenuLayout("Delete");
            Console.WriteLine("enter the id: ");
            int id = int.Parse(Console.ReadLine());
            rest.Delete(id, path);
        }
        static void AddSeries()
        {
            MenuLayout("AddSeries");
            Console.WriteLine("Series Name:");
            string name = Console.ReadLine();
            Console.WriteLine("This card is miner true/false:");
            string miner = Console.ReadLine();
            bool isM = false;
            if (miner == "true")
            {
                isM = true;
            }
            else { isM = false; };
            rest.Post<Series>(new Series { Name = name, isMiner = isM }, "Series");
            Console.WriteLine("Series has been added...");
            Console.ReadLine();
        }
        static void AddGeneration()
        {
            MenuLayout("AddGeneration");
            Console.WriteLine("Graphic Card name:");
            string name = Console.ReadLine();
            Console.WriteLine("This card is LHR version ? true/false:");
            string isLhr = Console.ReadLine();
            bool isL = false;
            if (isLhr == "true")
            {
                isL = true;
            }
            else { isL = false; };
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Memory type of this card:");
            string memtype = Console.ReadLine();
            Generation Generation = new Generation() { Name = name, LHR = isL, Price = price,MemoryType = memtype };
            rest.Post<Generation>(Generation, "Generation");
            Console.WriteLine("Generation has been added...");
            Console.ReadLine();
        }
        static void AddGraphicCard()
        {
            MenuLayout("AddGraphicCard");
            Console.Write("GraphicCard Brand:");
            string brand = Console.ReadLine();
            Console.Write("Amd or Nvidia ?:");
            string type = Console.ReadLine();
            int cardId;
            if (type == "Amd") { cardId = 1; }
            else { cardId = 2; }           
            Console.Write("Employees: ");
            int empl = int.Parse(Console.ReadLine());
            GraphicCard GraphicCard = new GraphicCard() { Name = brand, Employees = empl,Id =cardId}; 
            rest.Post<GraphicCard>(GraphicCard, "GraphicCard");
            Console.WriteLine("GraphicCard has been added...");
            Console.ReadLine();
        }
        static void UpdateSeries()
        {
            MenuLayout("UpdateSeries");
            Console.Write("Enter the Id: ");
            int id = int.Parse(Console.ReadLine());
            var Series = rest.Get<Series>("Series");
            var newSer = new Series();
            foreach (var item in Series)
            {
                if (item.Id == id)
                {
                    newSer = item;
                    break;
                }
            }
            if (newSer.Id == id)
            {
                ;
                Console.WriteLine("Series Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Is miner: ");
                string isMiner = Console.ReadLine();
                bool isM = false;
                if (isMiner == "true") { isM = true; }             
                else { isM = false; };
                newSer.Name = Name;
                newSer.isMiner = isM;
                rest.Put<Series>(newSer, "Series");
                ;
            }
            else
            {
                throw new IndexOutOfRangeException($"There is no {id} in the Seriess database!");
            }

        }
        static void UpdateGeneration()
        {
            MenuLayout("UpdateGeneration");
            Console.WriteLine("Please enter the Generation's id: ");
            int id = int.Parse(Console.ReadLine());
            var Gens = rest.Get<Generation>("Generation");
            var newGen = new Generation();
            foreach (var item in Gens)
            {
                if (item.Id == id)
                {
                    newGen = item;
                    break;
                }
            }
            if (newGen.Id == id)
            {

                Console.Clear();
                Console.WriteLine("Generation Name:");
                string newName = Console.ReadLine();
                Console.WriteLine("Price:");
                int newPrice = int.Parse(Console.ReadLine());
                Console.Write("Memory type: ");
                string memtype = Console.ReadLine();
                Console.WriteLine("Is Lhr (0/1):");
                int isLhr = int.Parse(Console.ReadLine());
                if (newName != "")
                {
                    newGen.Name = newName;
                }
                if (isLhr ==1)
                {
                    newGen.LHR = true;
                }
                else
                {
                    newGen.LHR = false;
                }
                if (memtype != "")
                {
                    newGen.MemoryType = "Samsung";
                }
                if (newPrice > 0)
                {
                    newGen.Price = newPrice;
                }
                rest.Put<Generation>(newGen, "Generation");
            }
            else
            {
                throw new IndexOutOfRangeException($"There is no {id} in the Generations database!");
            }
        }
        
        static void UpdateGraphicCard()
        {
            MenuLayout("UpdateGraphicCard");
            Console.WriteLine("Please enter a valid GraphicCard id:");
            int id = int.Parse(Console.ReadLine());
            var GraphicCard = rest.Get<GraphicCard>("GraphicCard");
            var newGraphicCard = new GraphicCard();
            foreach (var item in GraphicCard)
            {
                if (item.Id == id)
                {
                    newGraphicCard = item;
                }
            }
            if (newGraphicCard.Id == id)
            {
                Console.WriteLine("New gpu brand:");
                newGraphicCard.Name = Console.ReadLine();
                Console.Write("New Employees count:");
                newGraphicCard.Employees = int.Parse(Console.ReadLine());
                rest.Put<GraphicCard>(newGraphicCard, "GraphicCard");
            }
            else
            {
                throw new IndexOutOfRangeException($"There is no {id} in the GraphicCards database!");
            }
        }
        static void MenuLayout(string menutype)
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth + menutype.Length) / 2, Console.CursorTop);
            Console.WriteLine(menutype + "\n");

        }
    }
}