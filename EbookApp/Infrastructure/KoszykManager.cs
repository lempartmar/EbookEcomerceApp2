using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EbookApp.DAL;
using EbookApp.Data;
using EbookApp.Models;

namespace EbookApp.Infrastructure
{
    public class KoszykManager
    {
        private EbookContext data = new EbookContext();
        private ISessionManager session;
        public KoszykManager(ISessionManager session, EbookContext db)
        {

            this.session = session;
            //this.data = db; 

        }

        public List<PozycjaKoszyka> PobierzKoszyk()
        {


            List<PozycjaKoszyka> koszyk;

            if (session.Get<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz)==null)
            {
                koszyk = new List<PozycjaKoszyka>();
            }
            else
            {
                koszyk = session.Get<List<PozycjaKoszyka>>(Consts.KoszykSessionKlucz) as List<PozycjaKoszyka>;

            }

            return koszyk;
        }

        public void DodajDoKoszyka(int kursId)
        {

            var koszyk = PobierzKoszyk();
            var pozycjaKoszyka = koszyk.Find(k => k.EbookKoszyk.Id == kursId);

            if (pozycjaKoszyka != null)
            {
                pozycjaKoszyka.Ilosc++;
            }
            else
            {
                var kursDoDodania = data.Ebooki.Where(k => k.Id == kursId).SingleOrDefault();

                if (kursDoDodania != null)
                {
                    var nowaPozycjaKoszyka = new PozycjaKoszyka()
                    {
                        EbookKoszyk = kursDoDodania,
                        Ilosc = 1,
                        Wartosc = 100
                    };
                    koszyk.Add(nowaPozycjaKoszyka);
                }
            
            }

            session.Set(Consts.KoszykSessionKlucz, koszyk);
        }

        public decimal PobierzWartoscKoszyk()
        {
           
            return 100;
        }

        public int PobierzIloscPozycjiKoszyka()
        {
            return 10;
        }

       
    }
} 