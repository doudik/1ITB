namespace 1ITB;

using System.Collections.Generic;

class Pruvodce{

    List<BankovniUcet> ucty = new List<BankovniUcet>();

    void UvodniPrivitani(){
        System.Console.WriteLine("Dobrý den, přihlašte se, prosím");
        System.Console.WriteLine("1. Přihlášení");
        System.Console.WriteLine("2. Registrace");
        switch(Console.ReadLine()){
            case 1:
                Prihlaseni();
                break;
            case 2:
                Registrace();
                break;
            default:
                System.Console.WriteLine("Tuto variantu neznám, zkuste to znovu!");
                UvodniPrivitani();
                break;
        }
    bool Prihlaseni(){
        System.Console.WriteLine("Zadejte svůj login: ");
        string log = Console.ReadLine();
        System.Console.WriteLine("Zadejte své heslo: ");
        string pw = Console.ReadLine();
    }
    void Registrace(){
        string jmeno, prijmeni, login, heslo;

        System.Console.WriteLine("Zadejte své jméno: ");
        jmeno = Console.ReadLine();
        System.Console.WriteLine("Zadejte své příjmení: ");
        prijmeni = Console.ReadLine();
        login = jmeno+prijmeni;
        System.Console.WriteLine("Zadejte své heslo: ");
        heslo = Console.ReadLine();
        
        foreach(BankovniUcet b in ucty){
            if(b == login){
                System.Console.WriteLine("Váš účet nemůžeme vytvořit.");
            }else{
                BankovniUcet login = new BankovniUcet(jmeno, prijmeni, login, heslo);
                System.Console.WriteLine("Vytvoření účtu bylo úspěšné!");
            }
        }
        BankovniUcet  = new BankovniUcet("miroslav", "douda", "douda", "passw");
        uc1.ucet = uc1.VytvorUcet();
    }
    }

}