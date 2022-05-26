using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
// Wojciech Wilk gr B 6877
namespace RpgMakerOkienkowa
{
    public partial class Form1 : Form
    {
        String wartoscPytania = "";
        int numerPytania = 1;
        static List<String> wybory = new List<String>();
        public Form1()
        {
            InitializeComponent();
            zadawaniePytan();
            zadawaniePytan2();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wybierz_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            Color losowyKolor = Color.FromArgb(rn.Next(256), rn.Next(256), rn.Next(256));
            this.BackColor = losowyKolor;


            if (wybierz.Text.Equals("EXIT"))
            {
                Application.Exit();
            }
            if (pytanie1.Checked || pytanie2.Checked)
            {
                if (pytanie1.Checked)
                {
                    wartoscPytania = "1";
                }
                else if (pytanie2.Checked)
                {
                    wartoscPytania = "2";
                }

                wybory.Add(wartoscPytania);


                if (((numerPytania == 4 || numerPytania == 6) && wartoscPytania == "2") || (numerPytania == 5 || numerPytania == 7))
                {
                    tworzeniePostaci();
                    wybierz.Text = "EXIT";
                }
                else
                {
                    numerPytania++;

                    if (numerPytania <= 3)
                    {
                        zadawaniePytan();
                    }
                    else
                    {
                        zadawaniePytan2();
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz mądrze");
            }
        }

        private void tworzeniePostaci()
        {
            if (wybory[1].Equals("1"))
            {
                Rycerz rycerz = stworzRycerza();
                //MessageBox.Show(rycerz.ToString());
                if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("ORK"))
                {
                    pictureBox1.Image = Properties.Resources.ork_k;
                }
                else if (rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("ORK"))
                {
                    pictureBox1.Image = Properties.Resources.ork_m;
                }
                else if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("PREDATOR"))
                {
                    pictureBox1.Image = Properties.Resources.predator_k;
                }
                else if (rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("PREDATOR"))
                {
                    pictureBox1.Image = Properties.Resources.predator_m;
                }
                else if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("KRANSOLUD"))
                {
                    pictureBox1.Image = Properties.Resources.krasnolud_k;
                }
                else if (rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("KRANSOLUD"))
                {
                    pictureBox1.Image = Properties.Resources.krasnolud_m;
                }
                else if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("CZLOWIEK"))
                {
                    pictureBox1.Image = Properties.Resources.czlowiek_k;
                }
                else if (rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("CZLOWIEK"))
                {
                    pictureBox1.Image = Properties.Resources.czlowiek_m;
                }
                else if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("ELF"))
                {
                    pictureBox1.Image = Properties.Resources.elf_k;
                }
                else if (rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("ELF"))
                {
                    pictureBox1.Image = Properties.Resources.elf_m;
                }
                else if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("JEDNOROZEC"))
                {
                    pictureBox1.Image = Properties.Resources.jednorozec_k;
                }
                else if (rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("JEDNOROZEC"))
                {
                    pictureBox1.Image = Properties.Resources.jednorozec_m;
                }
                else if (rycerz.Plec.Equals("KOBIETA") && rycerz.Rasa.Equals("AXOLOTH") || rycerz.Plec.Equals("MEZCZYZNA") && rycerz.Rasa.Equals("AXOLOTH"))
                {
                    pictureBox1.Image = Properties.Resources.axoloth;
                }

                Pytanie.Text = "Twoja postac: " + rycerz.ToString();
                pytanie1.Hide();
                pytanie2.Hide();
            }
            else if (wybory[1].Equals("2"))
            {
                Mag mag = stworzMaga();
                if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("ORK"))
                {
                    pictureBox1.Image = Properties.Resources.ork_k;
                }
                else if (mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("ORK"))
                {
                    pictureBox1.Image = Properties.Resources.ork_m;
                }
                else if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("PREDATOR"))
                {
                    pictureBox1.Image = Properties.Resources.predator_k;
                }
                else if (mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("PREDATOR"))
                {
                    pictureBox1.Image = Properties.Resources.predator_m;
                }
                else if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("KRANSOLUD"))
                {
                    pictureBox1.Image = Properties.Resources.krasnolud_k;
                }
                else if (mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("KRANSOLUD"))
                {
                    pictureBox1.Image = Properties.Resources.krasnolud_m;
                }
                else if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("CZLOWIEK"))
                {
                    pictureBox1.Image = Properties.Resources.czlowiek_k;
                }
                else if (mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("CZLOWIEK"))
                {
                    pictureBox1.Image = Properties.Resources.czlowiek_m;
                }
                else if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("ELF"))
                {
                    pictureBox1.Image = Properties.Resources.elf_k;
                }
                else if (mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("ELF"))
                {
                    pictureBox1.Image = Properties.Resources.elf_m;
                }
                else if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("JEDNOROZEC"))
                {
                    pictureBox1.Image = Properties.Resources.jednorozec_k;
                }
                else if (mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("JEDNOROZEC"))
                {
                    pictureBox1.Image = Properties.Resources.jednorozec_m;
                }
                else if (mag.Plec.Equals("KOBIETA") && mag.Rasa.Equals("AXOLOTH") || mag.Plec.Equals("MEZCZYZNA") && mag.Rasa.Equals("AXOLOTH"))
                {
                    pictureBox1.Image = Properties.Resources.axoloth;
                }
                //MessageBox.Show(mag.ToString());
                Pytanie.Text = "Twoja postac: " + mag.ToString();
                pytanie1.Hide();
                pytanie2.Hide();
                //Application.Exit();
            }
        }

        private void zadawaniePytan()
        {
            switch (numerPytania)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.pytanie11;
                    Pytanie.Text = "Na swojej drodze spotykasz 3 mężczyzn,którzy chcą Cię okraść. Co robisz ?";
                    pytanie1.Text = "tłukę ich na kwaśne jabłko kijem";
                    pytanie2.Text = "trzymam się na dystans i ciskam w nich czym popdadnie";
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.pytanie2;
                    Pytanie.Text = "Na śniadanie płatki jesz z miski, czy z czaszek swich wrogów ??";
                    pytanie1.Text = "czaszki";
                    pytanie2.Text = "miski";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.pytanie3;
                    Pytanie.Text = "Jestes kobietą czy meżczyzną ?";
                    pytanie1.Text = "mężczyzną";
                    pytanie2.Text = "kobietą";
                    break;
            }
            pytanie1.Checked = false;
            pytanie2.Checked = false;
        }
        private void zadawaniePytan2()
        {
            if (wybory.Count > 0)
                if (numerPytania == 4 && wybory[0].Equals("1"))
                {
                    numerPytania += 2;
                }
            switch (numerPytania)
            {
                case 4:
                    pictureBox1.Image = Properties.Resources.pytanie4;
                    Pytanie.Text = "W przydrożnej gospodzie znajdujesz zaczarowany róg. Co robisz ?";
                    pytanie1.Text = "kupuje go";
                    pytanie2.Text = " odchodzę";
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.pytanie5;
                    Pytanie.Text = "Róg ma miejsce na kryształ, tak się skłąda że posiadasz pasujący idealnie. Co robisz?";
                    pytanie1.Text = "umieść kryształ w rogu";
                    pytanie2.Text = "wyrzuć róg";
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.pytanie6;
                    Pytanie.Text = "Na swoje drodze spotykasz wędrownego maga, proponuje Ci wspólny posiłek. Co robisz??";
                    pytanie1.Text = "zgadzam się";
                    pytanie2.Text = "odchdzę";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.pytanie7;
                    Pytanie.Text = "Po posiłku mag zasypia. Co robisz ???";
                    pytanie1.Text = "kradnę magowi topór, który wystaje z jego rzeczy";
                    pytanie2.Text = "również zasypiam";
                    break;
            }

            pytanie1.Checked = false;
            pytanie2.Checked = false;

        }
        public class Istota
        {
            private String rasa;
            private String plec;
            private String imie;
            private List<string> wyglad;
            private int wiek;
            private int zycie;
            private double sila;
            private double inteligencja;

            private static Random random = new Random();
            private static string[] rasy = { "ORK", "PREDATOR", "KRANSOLUD", "CZLOWIEK", "ELF", "JEDNOROZEC", "AXOLOTH" };
            private static string[] plcie = { "MEZCZYZNA", "KOBIETA" };
            private static string[] wlosy = { "ODSTAJACYCH", "ROZCZOCHRANYCH", "ULIZANYCH" };
            private static string[] oczy = { "SZALONYCH", "TĘCZOWYCH", "BEZDENNYCH", "BEZDUSZNYCH" };
            private static string[] skora = { "OWRZODZONEJ", "CĘTKOWANEJ", "SNIADEJ", "BLADEJ" };
            //  private static string[] znakSzczegolny = { "PIEPRZYK NA POŚLADKU", "ZNAMIE W KSZTALCIE DINOZAURA", "KALAFIOROWE USZY" };

            public string Rasa { get => rasa; set => rasa = value; }
            public String Plec { get => plec; set => plec = value; }
            public string Imie { get => imie; set => imie = value; }
            public int Wiek { get => wiek; set => wiek = value; }
            public int Zycie { get => zycie; set => zycie = value; }
            public double Sila { get => sila; set => sila = value; }
            public double Inteligencja { get => inteligencja; set => inteligencja = value; }
            public List<string> Wyglad { get => wyglad; set => wyglad = value; }

            public Istota()
            {
                this.imie = LosowanieImienia();
                this.wiek = LosujWiek();
                this.wyglad = LosujWyglad();
            }

            public String LosowanieImienia()
            {
                StringBuilder imieWylosowane = new StringBuilder("");
                List<char> literki = new List<char>();
                int dlugoscImienia = random.Next(3, 10);
                char litera;
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    literki.Add(c);

                }

                for (int i = 0; i < dlugoscImienia; i++)
                {
                    litera = literki[random.Next(0, literki.Count)];
                    bool jestSamogloska = "AEIOU".IndexOf(litera) >= 0;
                    if (jestSamogloska.Equals(true) && i % 2 != 0)
                    {
                        imieWylosowane.Append(litera);
                    }
                    else if (!jestSamogloska.Equals(true) && i % 2 == 0)
                    {
                        imieWylosowane.Append(litera);
                    }
                    else
                    {
                        i--;
                    }
                }
                return imieWylosowane.ToString();
            }

            public void LosujRase()
            {
                if (wybory[1].Equals("1"))
                {
                    Rasa = rasy[random.Next(0, 3)];
                }
                else
                {
                    Rasa = rasy[random.Next(4, 6)];
                }

            }

            public void LosujPlec()
            {
                if (wybory[2].Equals("1"))
                {
                    Plec = plcie[0];
                }
                else
                {
                    Plec = plcie[1];
                }
            }

            public List<string> LosujWyglad()
            {
                List<string> listaChwilowa = new List<string>();
                listaChwilowa.Add(wlosy[random.Next(0, wlosy.Length)]);
                listaChwilowa.Add(oczy[random.Next(0, oczy.Length)]);
                listaChwilowa.Add(skora[random.Next(0, skora.Length)]);
                return listaChwilowa;
            }

            public int LosujWiek()
            {
                return random.Next(10, 100);
            }

            public virtual void IleSily()
            {
                if (Rasa.Equals("ORK") || Rasa.Equals("PREDATOR"))
                {
                    if (15 < Wiek && Wiek < 50)
                    {
                        Sila = Math.Round(random.NextDouble() + random.Next(15, 30), 2);
                    }
                    else
                    {
                        Sila = Math.Round(random.NextDouble() + random.Next(12, 28), 2);
                    }
                }
                else if (Rasa.Equals("CZLOWIEK") || Rasa.Equals("KRASNOLUD"))
                {
                    if (20 < Wiek && Wiek < 60)
                    {
                        Sila = Math.Round(random.NextDouble() + random.Next(13, 27), 2);
                    }
                    else
                    {
                        Sila = Math.Round(random.NextDouble() + random.Next(11, 16), 2);
                    }
                }
                else
                {
                    Sila = Math.Round(random.NextDouble() + random.Next(10, 24), 2);
                }
            }

            public virtual void IleInt()
            {
                if (Rasa.Equals("ELF") || Rasa.Equals("AXOLOTH"))
                {
                    if (Wiek > 50)
                    {
                        Inteligencja = Math.Round(random.NextDouble() + random.Next(15, 30), 2);
                    }
                    else
                    {
                        Inteligencja = Math.Round(random.NextDouble() + random.Next(14, 28), 2);
                    }
                }
                else if (Rasa.Equals("JEDNOROZEC") || Rasa.Equals("KRASNOLUD"))
                {
                    if (60 < Wiek && Wiek < 100)
                    {
                        Inteligencja = Math.Round(random.NextDouble() + random.Next(11, 18), 2);
                    }
                    else
                    {
                        Inteligencja = Math.Round(random.NextDouble() + random.Next(10, 16), 2);
                    }
                }
                else
                {
                    Inteligencja = Math.Round(random.NextDouble() + random.Next(8, 15), 2);
                }
            }

            public String OkreslenieSily()
            {
                if (Sila <= 15)
                {
                    String temp = "SŁABIAK";
                    return temp;
                }
                else if (15 < Sila && Sila < 22)
                {
                    String temp = "PRZECIĘTNIE SILNY";
                    return temp;
                }
                else
                {
                    String temp = "POTĘŻNY";
                    return temp;
                }
            }

            public String OkreslenieInt()
            {
                if (Inteligencja <= 11)
                {
                    String temp = "TUMAN";
                    return temp;
                }
                else if (11 < Inteligencja && Inteligencja < 24)
                {
                    String temp = "CAŁKIEM INTELIGENTY";
                    return temp;
                }
                else
                {
                    String temp = "NO GENIUSZ PO PROSTU";
                    return temp;
                }
            }

            public virtual void IleZycia()
            {
                Zycie = (int)Sila + 40;
            }

            public override string ToString() => OkreslenieSily() + " i " + OkreslenieInt() + " " + Rasa + " " + Plec + " o imieniu " + Imie + ", ma " + Wiek + " lat " + " o " + Wyglad[1] + " oczach "
                    + Wyglad[0] + " włosach " + " i " + Wyglad[2] + " skórze " + "\n" + " masz: " + "\n" + Zycie + " życia " + "\n" + Sila + " siły" + "\n" + Inteligencja + " inteligencji";
        }
        public class Rycerz : Istota
        {
            public int obrona = 6;

            public int Obrona { get => obrona; set => obrona = value; }

            public override void IleSily()
            {
                base.IleSily();
                Sila = Math.Round((Sila + 10), 2);
            }

            public override void IleZycia()
            {
                Zycie = (int)Sila + 40;
                if (wybory.Count >= 5)
                    if (wybory[4].Equals("1"))
                    {
                        Zycie -= 10;
                        MessageBox.Show("Na topór nałożono klątwę, zabrała Ci 10 życia");
                    }
                    else
                    {
                        Zycie += 10;
                        MessageBox.Show("Po przebudzeniu nie zastałeś już maga, jednak znalazłeś buteleczkę z miksturą, która dała Ci + 10 życia");
                    }
            }
            public override string ToString() =>"RYCERZ " + base.ToString();
        }
        public class Mag : Istota
        {
            //   private String rzucCzar;
            public override void IleInt()
            {
                base.IleInt();
                Inteligencja = Math.Round((Inteligencja + 10), 2);
            }
            public override void IleZycia()
            {
                Zycie = (int)Sila + 40;
                if (wybory.Count >= 5)
                    if (wybory[4].Equals("2"))
                    {
                        Zycie -= 10;
                        MessageBox.Show("Róg odbija się od ziemi i rani Cię w głowę (-10 życia)");
                       
                    }
                    else
                    {
                        Zycie += 10;
                        MessageBox.Show("Róg wypełnia się wodą, która po wypiciu dodaje Ci życia (+10 życia)");
                    }
            }
            public override string ToString() =>"MAG " + base.ToString();
        }
        public static Rycerz stworzRycerza()
        {
            Rycerz rycerz = new Rycerz();
            rycerz.LosujRase();
            rycerz.IleSily();
            rycerz.LosujPlec();
            rycerz.IleInt();
            rycerz.IleZycia();
            return rycerz;
        }
        public static Mag stworzMaga()
        {
            Mag mag = new Mag();
            mag.LosujRase();
            mag.IleSily();
            mag.LosujPlec();
            mag.IleInt();
            mag.IleZycia();
            return mag;
        }
    }
}
