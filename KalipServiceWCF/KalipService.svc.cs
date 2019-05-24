using System;
using System.Collections.Generic;
using System.Linq;

namespace KalipServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IKalipService
    {
        KalipDBEntities db = new KalipDBEntities();
        public void Add(Numune numune)
        {
          
                db.Numune.Add(numune);
                db.SaveChanges();
            
        }

        public void Delete(int id)
        {
          
                var num = db.Numune.Find(id);
                if (num != null)
                {
                    db.Numune.Remove(num);
                    db.SaveChanges();
                }


            

        }

        public void Edit(Numune numune)
        {
           
                var num = db.Numune.FirstOrDefault(n => n.Id == numune.Id);
                if (num != null)
                {



                   // num.KalipKodu = numune.KalipKodu;
                  //  num.NumuneAdi = numune.NumuneAdi;
                    num.Tarih = numune.Tarih;
                  //  num.UrunKodu = numune.UrunKodu;
                    num.Adet = numune.Adet;
                }
                db.SaveChanges();
            

        }

        public Numune Find(int urunkodu, int kalipKodu)
        {
           

                return db.Numune.Where(x => x.UrunKodu == urunkodu && x.KalipKodu == kalipKodu).FirstOrDefault();
            
        }

        public List<Numune> FindByDate(DateTime date)
        {
           
                return db.Numune.Where(n => n.Tarih.Value == date).ToList();

            

        }

        public List<Numune> FindUrunKod(int urunkodu)
        {
            
                try
                {
                    return db.Numune.Where(x => x.UrunKodu == urunkodu).ToList();

                }
                catch (Exception)
                {
                    return null;
                }
            
        }

        public List<Numune> getAll()
        {
          

                return db.Numune.ToList();
            
        }

        public int GetUser(string username, string password)
        {
           
                return db.Uye.Where(x => x.UserName == username && x.Password == password).Count();

            
        }

        public List<prcPieChartOnlyDate_Result> PieChartDate(string baslangic,string bitis)
        {
          
            return db.prcPieChartOnlyDate(Convert.ToDateTime(baslangic), Convert.ToDateTime(bitis)).ToList();
        }

        public List<prcPieChart_Result> PieChart(string baslangic, string bitis, int parca, int kalip)
        {
           
            return db.prcPieChart(Convert.ToDateTime(baslangic), Convert.ToDateTime(bitis),parca,kalip).ToList();
        }

        public void AddDetail(NumuneDetay numune)
        {

            db.NumuneDetay.Add(numune);
            db.SaveChanges();

        }

        public void DeleteDetail(int id)
        {

            var num = db.NumuneDetay.Find(id);
            if (num != null)
            {
                db.NumuneDetay.Remove(num);
                db.SaveChanges();
            }




        }

        public void EditDetail(NumuneDetay numune)
        {

            var num = db.NumuneDetay.FirstOrDefault(n => n.id == numune.id);
            if (num != null)
            {



                num.KalipKodu = numune.KalipKodu;
                num.NumuneAdi = numune.NumuneAdi;
                num.BaskiSuresi = numune.BaskiSuresi;
                num.UrunKodu = numune.UrunKodu;
                num.CikanParcaMiktarı = numune.CikanParcaMiktarı;
                num.Hammadde = numune.Hammadde;
                num.KalipBoyutu = numune.KalipBoyutu;
                num.KalipGozu = numune.KalipGozu;
                num.ParcaAgirligi = numune.ParcaAgirligi;
                num.Renk = numune.Renk;
                num.ResimURL = numune.ResimURL;
                num.TedarikciFirma = numune.TedarikciFirma;
            }
            db.SaveChanges();


        }

        public NumuneDetay FindDetail(int urunkodu, int kalipKodu)
        {


            return db.NumuneDetay.Where(x => x.UrunKodu == urunkodu && x.KalipKodu == kalipKodu).FirstOrDefault();

        }

        public List<NumuneTariheGoreSatisOranları_Result> procAylikSatisOrani(string baslangic, string bitis)
        {
            return db.NumuneTariheGoreSatisOranları(Convert.ToDateTime(baslangic), Convert.ToDateTime(bitis)).ToList();
        }

      
    }
}
