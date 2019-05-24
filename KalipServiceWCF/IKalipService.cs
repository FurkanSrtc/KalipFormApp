using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KalipServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKalipService
    {

        [OperationContract]
        List<Numune> getAll();

        [OperationContract]
        int GetUser(string username, string password);

        [OperationContract]
        Numune Find(int urunkodu,int parcakodu);

        [OperationContract]
        List<Numune> FindUrunKod(int urunkodu);

        [OperationContract]
        void Add(Numune numune);

        [OperationContract]
        void Edit(Numune numune);

        [OperationContract]
        void Delete(int id);


        [OperationContract]
        List<Numune> FindByDate(DateTime date);

        [OperationContract]
        List<prcPieChartOnlyDate_Result> PieChartDate(string baslangic, string bitis);

        [OperationContract]
        List<prcPieChart_Result> PieChart(string baslangic, string bitis,int parca, int kalip);

        //-----------------

        [OperationContract]
        void AddDetail(NumuneDetay numune);

        [OperationContract]
        void EditDetail(NumuneDetay numune);

        [OperationContract]
        void DeleteDetail(int id);

        [OperationContract]
        NumuneDetay FindDetail(int urunkodu, int parcakodu);


        [OperationContract]
        List<NumuneTariheGoreSatisOranları_Result> procAylikSatisOrani (string baslangic, string bitis);

      
 
    }



}
