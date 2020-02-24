using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CA200224
{
    class Program
    {
        static void Main()
        {
            #region kecskelista
            var kecskek = new List<Kecske>()
            {
                new Kecske 
                {
                    Nev = "Kelly",
                    SzulDate = new DateTime(2007, 01, 06),
                    IrSzam = 1138,
                    Nem = false,
                },
                new Kecske
                {
                    Nev = "Joseph",
                    SzulDate = new DateTime(2006, 10, 17),
                    IrSzam = 2660,
                    Nem = true,
                },
                new Kecske
                {
                    Nev = "Edison",
                    SzulDate = new DateTime(2010, 08, 01),
                    IrSzam = 2660,
                    Nem = true,
                },
                new Kecske
                {
                    Nev = "Moonrow",
                    SzulDate = new DateTime(2006, 12, 10),
                    IrSzam = 1142,
                    Nem = false,
                },
                new Kecske
                {
                    Nev = "Dimitrij",
                    SzulDate = new DateTime(2008, 07, 11),
                    IrSzam = 1234,
                    Nem = true,
                },
            };
            #endregion
            #region teszt
            ////összes nev
            //foreach (var k in kecskek) Console.WriteLine(k.Nev);

            ////rendezes
            //for (int i = 0; i < kecskek.Count - 1; i++)
            //{
            //    for (int j = i; j < kecskek.Count; j++)
            //    {
            //        if(kecskek[i].IrSzam > kecskek[j].IrSzam)
            //        {
            //            var k = kecskek[i];
            //            kecskek[i] = kecskek[j];
            //            kecskek[j] = k;
            //        }
            //    }
            //}
            //foreach (var k in kecskek) Console.WriteLine(k.IrSzam);

            ////legöregebb
            //int mini = 0;
            //for (int i = 1; i < kecskek.Count; i++)
            //{
            //    if (kecskek[mini].SzulDate > kecskek[i].SzulDate)
            //        mini = i;
            //}
            //Console.WriteLine("Legöregebb kecs: " + kecskek[mini].Nev);
            #endregion

            //var t = new int[] { 20, 11, 34, 42, 69};
            //int sum = 0;
            //foreach (var e in t) sum += e;
            //Console.WriteLine("osszeg: " + sum);
            //Console.WriteLine("összeg: " + t.Sum());

            //int osszeg = kecskek.Sum(x => x.IrSzam);
            //Console.WriteLine(osszeg);

            //var valami = kecskek.OrderBy(x => x.Nev);
            //foreach (var k in valami) Console.WriteLine(k.Nev);
            //kecskek.OrderByDescending(x => x.SzulDate);

            //var valami = kecskek.Min(x => x.SzulDate);
            //Console.WriteLine(valami);

            //SELECT nev FROM kecskek WHERE szul = (SELECT Min(szul) FROM kecskek);
            //SELECT nev FROM kecskek WHERE szul = Min(szul)
            //SELECT TOP 1 nev FROM kecskek ORDER BY szul ASC
            //SELECT nev FROM kecskek ORDE BY szul ASC LIMIT 1

            //var v = kecskek.Where(
            //    x => x.SzulDate == kecskek.Min(y => y.SzulDate))
            //    .First().Nev;

            //var v2 = kecskek.OrderBy(x => x.SzulDate).First().Nev;

            //var v3 = (from x in kecskek
            //         where x.SzulDate == kecskek.Min(y => y.SzulDate)
            //         select x.Nev).First();

            //Console.WriteLine("legöregebb: " + v3);

            //2660-ás irányítószámú kecskék nevei

            kecskek
                .Where(x => x.IrSzam == 2660)
                .Select(x => x.Nev)
                .ToList()
                .ForEach(y => Console.WriteLine(y));

            (from x in kecskek where x.IrSzam == 2660 orderby x.Nev select x.Nev)
                .ToList()
                .ForEach(y => Console.WriteLine(y));



            Console.ReadKey();
        }
    }
}
