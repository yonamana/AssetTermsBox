using SqlOperate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AssetTermsBox
{
    internal class TD_HOLDER
    {
        const string TABLE_NAME = "HOLDER";

        static public string InsertData(string name, string terms)
        {
            C_OperateSql sql = new C_OperateSql();
            string columns = "name, terms";
            string values = "N'" + name + "',";
            values += "N'" + terms + "'";

            return sql.InsertGetId(TABLE_NAME, columns, values);
        }


        static public void UpdateData(string id, string name, string terms)
        {
            C_OperateSql sql = new C_OperateSql();
            string setStr = "name = N'" + name + "',";
            setStr += "terms = N'" + terms + "'";
            string where = "id = " + id;

            sql.Update(TABLE_NAME, setStr, where);
        }


        static public void DeleteData()
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "";
            sql.Delete(TABLE_NAME, where);
            return;
        }

        static public string GetId(string name)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id" };

            string where = "name = N'" + name + "'";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            if (result.Count() == 0)
            {
                return "";
            }
            return result[0]["id"];
        }

        static public Dictionary<string, string> SelectDataOne(string id)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "terms"};

            string where = "id = " + id;
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result[0];
        }

        static public Dictionary<string, string> SelectDataWhereName(string name)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "terms" };

            string where = "name = N'" + name + "'";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            if (result.Count() == 0)
            {
                return null;
            }
            return result[0];
        }

        static public Dictionary<int, Dictionary<string, string>> SelectData()
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name" };

            string where = "";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result;
        }

        static public Dictionary<int, Dictionary<string, string>> GetTerms(string name)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "terms" };

            string where = "name = N'" + name + "'";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result;
        }


        static public Dictionary<int, Dictionary<string, string>> SelectTermsWhereId(string[] idList)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "terms" };

            string where = "";
            for (int cnt = 0; cnt < idList.Count(); cnt++)
            {
                if (cnt > 0)
                {
                    where += " OR ";
                }
                where += "id = " + idList[cnt];
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result;
        }



    }
}
