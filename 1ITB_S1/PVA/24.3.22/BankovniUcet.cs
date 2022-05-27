namespace 1ITB;

class BankovniUcet{
    string jmeno, prijmeni, login, heslo;
    public string ucet;
    Random rnd = new Random();

    public BankovniUcet(string jmeno, string prijmeni, string login, string heslo){
        this.jmeno = jmeno;
        this.prijmeni = prijmeni;
        this.login = login;
        this.heslo = heslo;
    }

    public string VytvorUcet(){
        string vysl = "";
        for (int i = 0; i < 8; i++)
        {
            int tmp = rnd.Next(1,10);
            while(tmp == 0 && i == 0){
                tmp = rnd.Next(1,10);
            }
            vysl += tmp.ToString();
        }
        vysl += "/3030";
        return vysl;
    }

}