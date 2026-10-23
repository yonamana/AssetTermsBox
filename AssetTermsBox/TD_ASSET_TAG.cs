using SqlOperate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    internal class TD_ASSET_TAG
    {
        const string TABLE_NAME = "ASSET_TAG";

        /// <summary>
        /// データの登録
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="tagId"></param>
        static public void InsertData(string assetId, string tagId)
        {
            C_OperateSql sql = new C_OperateSql();

            string columns = "asset_id, tag_id";

            string value = assetId + ", " + tagId;
            sql.Insert(TABLE_NAME, columns, value);
            return;
        }

        /// <summary>
        /// 指定したasset_idのデータを削除
        /// </summary>
        /// <param name="assetId"></param>
        static public void DeleteDataByAssetId(string assetId)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "asset_id = " + assetId;
            sql.Delete(TABLE_NAME, where);
            return;
        }

        /// <summary>
        /// 指定したtag_idのデータを削除
        /// </summary>
        /// <param name="tagId"></param>
        static public void DeleteDataByTagId(string tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "tag_id = " + tagId;
            sql.Delete(TABLE_NAME, where);
            return;
        }

        /// <summary>
        /// 指定したasset_idのデータのtag_idを取得
        /// </summary>
        /// <param name="assetId"></param>
        /// <returns></returns>
        static public string[] SelectTagId(string assetId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "tag_id" };
            string where = "asset_id = " + assetId;
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);

            // 結果を配列に格納して返却
            string[] tagIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                tagIdList[count] = data["tag_id"];
            }

            return tagIdList;
        }

        /// <summary>
        /// 指定したtag_id群と一致するデータのasset_idを取得
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        static public string[] SelectAssetId(string[] tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "asset_id" };
            string where = "";
            foreach (string item in tagId)
            {
                if (where != "")
                {
                    where += " OR ";
                }
                where += "tag_id = " + item;
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);

            // 結果を配列にして返却
            string[] assetIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                assetIdList[count] = data["asset_id"];
            }

            return assetIdList;
        }


        static public string[] SelectAssetIdWhereTagId(string[] tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "ASSET.id" };
            string other = "";
            int tableCnt = 1;
            foreach (string item in tagId)
            {
                other += " INNER JOIN ASSET_TAG AS WT" + tableCnt + " ON ASSET.id = WT" + tableCnt + ".asset_id AND WT" + tableCnt + ".tag_id = " + item;
                tableCnt++;
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select("ASSET", columns, "", other);

            // 結果を配列にして返却
            string[] assetIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                assetIdList[count] = data["id"];
            }

            return assetIdList;
        }



    }
}
