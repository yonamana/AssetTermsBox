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


        static public void UpdateData(string assetId, string assetName, string holderId, string terms, string parent, string memo, bool bookmark, int kinds)
        {
            C_OperateSql sql = new C_OperateSql();
            string setStr = "";
            setStr += "name = N'" + assetName + "',";
            setStr += "holder_id = " + holderId + ",";
            setStr += "parent = N'" + parent + "',";
            setStr += "terms = N'" + terms + "',";
            setStr += "memo = N'" + memo + "',";
            setStr += "kinds = " + kinds + ",";
            if (bookmark == true)
            {
                setStr += "bookmark = 1";
            }
            else
            {
                setStr += "bookmark = 0";
            }

            string where = "id = " + assetId;

            sql.Update(TABLE_NAME, setStr, where);
            return;
        }

        static public void UpdateDataSetAlways(string assetId, string always)
        {
            C_OperateSql sql = new C_OperateSql();
            string setStr = "";
            setStr += "always = " + always;

            string where = "id = " + assetId;

            sql.Update(TABLE_NAME, setStr, where);
            return;
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
            string[] columns = {"name", "holder_id", "parent", "terms", "memo", "bookmark", "kinds", "always" };

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

        static public Dictionary<int, Dictionary<string, string>> SelectDataWhereAlwaysTrue()
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "holder_id", "bookmark" };

            string where = "always = 1";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result;
        }


        static public Dictionary<int, Dictionary<string, string>> SelectUsedData(List<string> idList)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "holder_id", "parent", "terms", "bookmark", "kinds" };

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


        static public string[] SelectUsedHolderId(List<string> idList)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "DISTINCT holder_id" };

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

            string[] holderIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                holderIdList[count] = data["holder_id"];
            }

            return holderIdList;
        }


    }
}
