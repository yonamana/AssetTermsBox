using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AssetTermsBox
{
    /// <summary>
    /// パス文字列の作成
    /// </summary>
    static internal class C_CreatePath
    {
        /// <summary>
        /// workフォルダの作品までの相対パスを作成
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string WorkFileAssetIdPath(string assetId)
        {
            string filePath = "work\\" + assetId;
            return filePath;
        }

        static public string WorkDataPath()
        {
            string filePath = "workData\\";
            return filePath;
        }
        



        /// <summary>
        /// deleteFileフォルダの削除ファイルの相対パスを作成
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public string DeleteFilePath(string id)
        {
            string folderPath = "deleteFile/"  + id;
            return folderPath;
        }



    }
}
