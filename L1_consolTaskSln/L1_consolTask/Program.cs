using System.Reflection;

namespace L1_consolTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Company About
            string company = "Samsung";
            Console.WriteLine("Information about the company \nOur mission and values \n" + company + " executives and employees are convinced that adhering to the right values is the key to business success. Therefore, Samsung is guided by core corporate values ​​and a strict code of business ethics in every decision it makes. \n");
            //Company official partners
            string officialPartnersKontackt = "Kontackt";
            string officialPartnersBakuElectronics = "Baku Electronics";
            string officialPartnersIrshad = "Irşad";
            string officialPartnersSoliton = "Soliton";
            string officialPartnersWorldTelecom = "World Telecom";
            Console.WriteLine("Meet our official partners: " + officialPartnersKontackt + ", " + officialPartnersBakuElectronics + ", " + officialPartnersIrshad + ", " + officialPartnersSoliton + ", " + officialPartnersWorldTelecom);
            //Baku Electronics Location and Phone Number
            string bakuElectronicsLocation = "Baku";
            string bakuElectronicsPhoneNumber = "143";
            string test = officialPartnersBakuElectronics + "\tLoaction: " + bakuElectronicsLocation + "\tPhone Number: " + bakuElectronicsPhoneNumber;
            Console.WriteLine(test);
            //Console.WriteLine("\n-" + officialPartnersBakuElectronics + "\tLoaction: " + bakuElectronicsLocation + "Phone Number: " + bakuElectronicsPhoneNumber);
            //Smart Phones Brands
            string smartPhonesBrandsApple = "Apple";
            string smartPhonesBrandsSamsung = "Samsung";
            string smartPhonesBrandsXiaomi = "Xiaomi";
            Console.WriteLine("\nBaku Electronics -> Smart Phones Brands: " + smartPhonesBrandsApple + ", " + smartPhonesBrandsSamsung + ", " + smartPhonesBrandsXiaomi);
            //Smart Phone
            string smartPhoneBrand = "Apple";
            string smartPhoneModel = "IPHONE 15 PRO MAX 256GB BLUE TITANIUM";
            string smartPhoneColor = "Black";
            ushort smartPhoneMemoryGb = 512;
            ushort smartPhonePrice = 3400;
            bool isBuyCredit = true;
            byte time = 1;
            Console.WriteLine("Smart Phone Brand: " + smartPhoneBrand + "\nSmart Phone Model: " + smartPhoneModel + "\nSmart Phone Color: " + smartPhoneColor + "\nSmart Phone Memory Gb: " + smartPhoneMemoryGb + "\nSmart Phone Price: " + smartPhonePrice + "\nCredit: " + isBuyCredit + "\nTime: " + time);
            //Computer Brands
            string computerBrandsMSI = "MSI";
            string computerBrandsLenova = "Lenova";
            string computerBrandsHp = "HP";
            Console.WriteLine("\nBaku Electronics -> Computer Brands: " + computerBrandsMSI + ", " + computerBrandsLenova + ", " + computerBrandsHp);
            //Computer MSI
            string computerBrand = "MSI";
            string computerModel = "Katana 15/ASPECT RATIO IPS 144HZ I7-13620H 16GB 1TB NV R";
            string computerColor = "Black";
            string computerCPU = "2.4 GHz - 4.9 GHz";
            string computerProcessorType = "Core i7";
            ushort computerRamGb = 16;
            ushort computerRom = 1;
            ushort computerVramGb = 8;
            float computerScreenSize = 15.6F;
            ushort computerPrice = 3700;
            bool isOS = false;
            bool isMicrophone = true;
            bool isWlan = true;
            bool isBluetooth = true;
            Console.WriteLine("\nComputer Brand: " + computerBrand + "\nComputer Model: " + computerModel + "\nComputer Color: " + computerColor + "\nComputer Screen Size (\"): " + computerScreenSize + "\nComputer CPU: " + computerCPU + "\nComputer Processor Type: " + computerProcessorType + "\nComputer RAM (GB): " + computerRamGb + "\nComputer ROM (GB): " + computerRom + "\nComputer Video card memory (GB): " + computerVramGb + "\nComputer Price: " + computerPrice + "\nCredit: " + isBuyCredit + "\nTime: " + time + "\nOS: " + isOS + "\nBuilt-in Microphone: " + isMicrophone + "\nWLAN: " + isWlan + "\nBluetooth: " + isBluetooth);
        }
    }
}
