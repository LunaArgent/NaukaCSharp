Gracz gracz = new Gracz();
gracz.nazwa = "Bohater";
Console.WriteLine("Nazwa gracza" + gracz.nazwa);
gracz.poziom = 1;
gracz.hp = 100;
Console.WriteLine("Poziom" + gracz.poziom);
Console.WriteLine("HP" + gracz.hp);
Gracz drugiGracz = new Gracz();
drugiGracz.nazwa = "Wojownik";
Console.WriteLine("Drugi gracz" + drugiGracz.nazwa);
int doswiadczenie = 0;
int poziom = 1;
int wymaganeXP = 500;
int maksymalneHP = 100;
int mikstury = 3;

while (true)
{
    Console.WriteLine("===================");
    Console.WriteLine("    ARENA");
    Console.WriteLine("===================");
    Console.WriteLine();
    Console.WriteLine("Poziom" + poziom);
    int wypelnieniePaskaXP = doswiadczenie * 10 / wymaganeXP;
    Console.Write("XP: [");
    for (int i = 0; i < 10; i++)
    {
        if (i < wypelnieniePaskaXP)
        {
            Console.Write("#");
        }
        else
        {
            Console.Write("-");
        }
    }
    Console.WriteLine("]" + doswiadczenie + "/" + wymaganeXP);
    Console.WriteLine("XP" + doswiadczenie + "/" + wymaganeXP);
    Console.WriteLine();
    Console.WriteLine("1 - rozpocznij walke");
    Console.WriteLine("2 - wyjdź z gry");
    string wybor = Console.ReadLine();
    switch (wybor)
    {
    case "1":
        RozpocznijWalke();
        break;
    case " 2 ":
        Console.WriteLine("Do zobaczenia");
        break;
    default:
        Console.WriteLine("Nieprawidłowy wybór");
        break;
    }
    void RozpocznijWalke()
    {
        Random losowanie = new Random();
        string nazwaPrzeciwnika = "";
        int poziomPrzeciwnika = 0;
        int doswiadczenieZaPrzeciwnika = 0;
        int maksymalneHPPrzeciwnika = 100;
        int zycieGracza = maksymalneHP;
        int zyciePrzeciwnika = 100;
        int minimalneObrazeniaPrzeciwnika = 0;
        int obrazeniaPrzeciwnika = 25;
        int szansaNaUnik = 10 + (poziom - 1) * 2;
        int leczenieMikstury = 30 + (poziom - 1) * 5;
        int szerokoscPaskaHP = 10;
       
        int szerokoscPaskaHPPrzeciwnika = 10;
       
        bool przeciwnikOgłuszony = false;
 Console.WriteLine("Wybierz przeciwnika");
            Console.WriteLine("1 - Goblin");
            Console.WriteLine("2 - Ork");
            Console.WriteLine("3 - Rycerz");
                string wyborPrzeciwnika = Console.ReadLine();
            switch (wyborPrzeciwnika)
        {
                case "1":
                    nazwaPrzeciwnika = "Goblin";
                    zyciePrzeciwnika = 100;
                maksymalneHPPrzeciwnika = 100;
                minimalneObrazeniaPrzeciwnika = 10;
                poziomPrzeciwnika = 1;
                doswiadczenieZaPrzeciwnika = 50;
                 break;
                case "2":
                    nazwaPrzeciwnika = "Ork";
                    zyciePrzeciwnika = 150;
                maksymalneHPPrzeciwnika = 150;
                minimalneObrazeniaPrzeciwnika = 15;
                poziomPrzeciwnika = 2;
                doswiadczenieZaPrzeciwnika = 100;
                break;
                case "3":
                    nazwaPrzeciwnika = "Rycerz";
                    zyciePrzeciwnika = 200;
                maksymalneHPPrzeciwnika = 200;
                minimalneObrazeniaPrzeciwnika = 20;
                poziomPrzeciwnika = 3;
                doswiadczenieZaPrzeciwnika = 150;
                break;
            }
            Console.WriteLine();
            Console.WriteLine("wybrałeś przeciwnika" + nazwaPrzeciwnika);
            Console.WriteLine("Przeciwnik ma" + zyciePrzeciwnika + "HP");
        Console.WriteLine("Poziom przeciwnika" + poziomPrzeciwnika);
                Console.WriteLine();
        while (zycieGracza > 0 && zyciePrzeciwnika > 0)
           
        {
            int wypelnieniePaskaHPPrzeciwnika = zyciePrzeciwnika * szerokoscPaskaHPPrzeciwnika / maksymalneHPPrzeciwnika;
            Console.Write("HP przeciwnika: [");
            for (int i = 0; i < szerokoscPaskaHPPrzeciwnika; i++)
            {
                if (i < wypelnieniePaskaHPPrzeciwnika)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("]" + zyciePrzeciwnika + "/" + maksymalneHPPrzeciwnika);
            int wynikLosowania = losowanie.Next(1, 101);
            Console.WriteLine();
            Console.WriteLine("Twoje Hp" + zycieGracza);
            Console.WriteLine("HP przeciwnika" + zyciePrzeciwnika + "| Poziom" + poziomPrzeciwnika);
            Console.WriteLine("Mikstury" + mikstury);
            int wypelnieniePaskaHP = zycieGracza * szerokoscPaskaHP / maksymalneHP;
            Console.Write("HP: [");
            for (int i = 0; i < szerokoscPaskaHP; i++)
            {
                if (i < wypelnieniePaskaHP)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("]" + zycieGracza + "/" + maksymalneHP);
           Console.WriteLine("Wybierz broń");
            Console.WriteLine("1 - Pięść (10 obrażeń)");
            Console.WriteLine("2 - Miecz (20 obrażeń)");
            Console.WriteLine("3 - Topór (30 obrażeń0)");
            Console.WriteLine("4 -  Mikstura lecznicza");
            string wyborBroni = Console.ReadLine();
            int obrazenia;
            string nazwaBroni;
            switch (wyborBroni)
            {
                case "1":
                    nazwaBroni = "Pięść";
                    obrazenia = 10;
                    break;
                case "2":
                    nazwaBroni = "Miecz";
                    obrazenia = 20;
                    break;
                case "3":
                    nazwaBroni = "Topór";
                    obrazenia = 30;
                    break;
                case "4":
                    if (zycieGracza < 100 && mikstury > 0)
                    {
                        Console.WriteLine("Wypiłeś miksture");
                        zycieGracza = zycieGracza + leczenieMikstury;
                        if (zycieGracza > maksymalneHP)
                        {
                            zycieGracza = maksymalneHP;
                        }
                        mikstury = mikstury - 1;
                    }
                    else
                    {
                        Console.WriteLine("nie możesz użyć mikstury");
                    }
                    continue;
                default:
                    Console.WriteLine(" Nieprawidłowy wybór");
                    continue;
            }
            int bonusZaPoziom = (poziom - 1) * 5;
            obrazenia = obrazenia + (poziom - 1) * 5;
            Console.WriteLine("wybrałeś" + nazwaBroni);
            if (nazwaBroni == "Topór" && wynikLosowania <= 20)
            {
                Console.WriteLine("Mocny cios");
                obrazenia = obrazenia * 2;
                if (nazwaBroni == "Miecz" && wynikLosowania <= 25)
                {
                    Console.WriteLine("Celne cięcie");
                    obrazenia = obrazenia + 10;
                }
                if (nazwaBroni == "Pięść" && +wynikLosowania <= 20)
                {
                    Console.WriteLine("Ogłuszyłeś przeciwnika");
                    przeciwnikOgłuszony = true;
                }
            }
            zyciePrzeciwnika = zyciePrzeciwnika - obrazenia;
            if (zyciePrzeciwnika < 0)
            {
                zyciePrzeciwnika = 0;
            }
            Console.WriteLine("zadałeś" + obrazenia + "obrażeń");
            Console.WriteLine("Przeciwnikowi zostało" + zyciePrzeciwnika + "HP");
            if (zyciePrzeciwnika <= 0)
            {
                break;
            }
            if (przeciwnikOgłuszony)
            {
                Console.WriteLine("Przeciwnik jest ogłuszony i nie może zaatakować!");
                przeciwnikOgłuszony = false;
            }
            else
            {
                obrazeniaPrzeciwnika = losowanie.Next( minimalneObrazeniaPrzeciwnika, minimalneObrazeniaPrzeciwnika + 11);
                if (losowanie.Next(1, 101) <= 10)
                {
                    Console.WriteLine("KRYTYCZNY CIOS!");
                    obrazeniaPrzeciwnika = obrazeniaPrzeciwnika * 2;
                }
                if (obrazeniaPrzeciwnika >= 23)
                {
                    Console.WriteLine("Przeciwnik zzadał mocny cios");
                    obrazeniaPrzeciwnika = obrazeniaPrzeciwnika * 2;
                }
                if (losowanie.Next(1, 101) <= szansaNaUnik)
                {
                    Console.WriteLine("UNIK!");
                }
                else
                {
                    zycieGracza = zycieGracza - obrazeniaPrzeciwnika;
                }
                if (zycieGracza < 0)
                {
                    zycieGracza = 0;
                }
                Console.WriteLine("Przeciwnik atakuje");
                Console.WriteLine("Otrzymałeś" + obrazeniaPrzeciwnika + "Obrażeń");
                Console.WriteLine("twoje HP" + zycieGracza);
            }
        }
        Console.WriteLine();
        if (zycieGracza <= 0)
        {
            Console.WriteLine("Zginąłeś");
        }
        else
        {
            Console.WriteLine("Przeciwnik pokonany");
            doswiadczenie = doswiadczenie + doswiadczenieZaPrzeciwnika;
            Console.WriteLine("Zdobyłeś" + doswiadczenieZaPrzeciwnika + "XP");
            Console.WriteLine("Twoje XP" + doswiadczenie);
            if (doswiadczenie >= wymaganeXP)
            {
                poziom = poziom + 1;
                doswiadczenie = 0;
                wymaganeXP = wymaganeXP + 250;
                maksymalneHP = maksymalneHP + 10;
                zycieGracza = maksymalneHP;
                mikstury = mikstury + 1;
                Console.WriteLine("AWANS");
                Console.WriteLine("Osiągnąłeś poziom" + poziom + "!");
            }
        }
    }
}
class Gracz
{
    public string nazwa;
    public int poziom;
    public int hp;
}