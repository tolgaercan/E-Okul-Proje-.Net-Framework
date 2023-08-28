using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace E_Okul_Proje
{
    class SqlBaglantı
    {
            public SqlConnection baglanti()
            {
                SqlConnection baglan = new SqlConnection ("Data Source=DESKTOP-Q90HJ59;Initial Catalog=e_okul;Integrated Security=True");
                baglan.Open();
                return baglan;
            }
        


    }
}
