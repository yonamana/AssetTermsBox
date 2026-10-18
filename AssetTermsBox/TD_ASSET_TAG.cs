using SqlOperate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    internal class TD_ASSET_TAG
    {
        const string TABLE_NAME = "ASSET_TAG";

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

        static public string[] SelectAssetIdWhereTagId(string[] tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "WORK.id" };
            string other = "";
            int tableCnt = 1;
            foreach (string item in tagId)
            {
                other += " INNER JOIN WORK_TAG AS WT" + tableCnt + " ON WORK.id = WT" + tableCnt + ".work_id AND WT" + tableCnt + ".tag_id = " + item;
                tableCnt++;
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select("WORK", columns, "", other);

            // 結果を配列にして返却
            string[] workIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                workIdList[count] = data["id"];
            }

            return workIdList;
        }


    }
}
