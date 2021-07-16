using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data
{
    public class CEntity
    { 

        public CEntity()
        {

        }

        protected IEnumerable<T> ExecuteSprocQuery<T>(string sproc, object objectParams)
        {
            sproc = this.SqlString();
            objectParams = DynamicParameters();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CHelper.CnnVal("BookShopDB")))
            {
                var list = connection.Query<T>(sproc, objectParams, commandType: CommandType.StoredProcedure);
                return list;
            }
        }

        public virtual string SqlString()
        {
            return String.Empty;
        }

        public virtual DynamicParameters DynamicParameters()
        {
            
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add(String.Empty, null);

            return dynamic;
        }

     
    }
}
