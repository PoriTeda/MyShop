using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for ProductWebservice
    /// </summary>
    [WebService(Namespace = "http://myproductsview.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductWebservice : System.Web.Services.WebService
    {
        public ProductWebservice() { }

        [WebMethod]
        public int GetNumberOfCatalog()
        {
            ConnectionFactory factory = new ConnectionFactory();
            int count = factory.GetCount("select count(*) from PHANLOAIHANG");
            factory.CloseConnection();
            return count;
        }
        [WebMethod]
        public double GetMoney(int quantity, double unitprice)
        {

            return quantity * unitprice;
        }
        [WebMethod]
        public List<Catalog> GetListCatalog()
        {
            List<Catalog> list = new List<Catalog>();
            ConnectionFactory factory = new ConnectionFactory();
            SqlDataReader da = factory.GetData("select * from PHANLOAIHANG");
            while(da.Read())
            {
                Catalog ca = new Catalog();
                ca.CateId = da.GetInt32(0).ToString();
                ca.CateName = da.GetString(1);
                list.Add(ca);
            }
            factory.CloseConnection();
            return list;
        }


    }
}
