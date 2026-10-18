using SqlOperate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    internal class TD_ASSET
    {
        const string TABLE_NAME = "ASSET";

        static public void InsertData()
        {
            C_OperateSql sql = new C_OperateSql();
            string columns = "";
            string values = "N''";


            sql.Insert(TABLE_NAME, columns, values);
        }


        static public void UpdateData()
        {
            C_OperateSql sql = new C_OperateSql();
            string setStr = "";
            string where = "";

            sql.Update(TABLE_NAME, setStr, where);
        }


        static public void DeleteData()
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "";
            sql.Delete(TABLE_NAME, where);
            return;
        }

        static public Dictionary<string, string> SelectDataOne(string id)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "creator", "favorite", "thumbnail" };

            string where = "";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result[0];
        }

        static public Dictionary<int, Dictionary<string, string>> SelectData()
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "creator", "favorite", "thumbnail" };

            string where = "";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result;
        }



    }
}
