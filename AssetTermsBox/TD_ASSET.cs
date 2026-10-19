using SqlOperate;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AssetTermsBox
{
    internal class TD_ASSET
    {
        const string TABLE_NAME = "ASSET";

        static public string InsertData(string assetName, string holderId, string terms, string parent, string memo, bool bookmark, int kinds)
        {
            C_OperateSql sql = new C_OperateSql();
            string columns = "name,holder_id,parent,terms,memo,kinds,bookmark";
            string values = "N'" + assetName + "',";
            values += holderId + ",";
            values += "N'" + parent + "',";
            values += "N'" + terms + "',";
            values += "N'" + memo + "',";
            values += kinds + ",";
            if (bookmark == true)
            {
                values += "1";
            }
            else
            {
                values += "0";
            }

            return sql.InsertGetId(TABLE_NAME, columns, values);
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
            string[] columns = {"name", "holder_id", "parent", "terms", "memo" };

            string where = "id = " + id;
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result[0];
        }

        static public Dictionary<int, Dictionary<string, string>> SelectData(int kinds)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "holder_id", "bookmark" };

            string where = "kinds = " + kinds;
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result;
        }




    }
}
