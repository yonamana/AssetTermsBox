using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    static internal class C_ManageWorkDataFile
    {
        static string workDataFilePath = "";
        static List<string> usedAssetList = new List<string>();

        static public void SetWorkDataFilePath(string filePath)
        {
            workDataFilePath = filePath;
            return;
        }

        static public string GetWorkDataFilePath()
        {
            return workDataFilePath;
        }

        static public bool CheckUsedAsset(string id)
        {
            if (usedAssetList.IndexOf(id) >= 0)
            {
                // ある
                return true;
            }

            return false;
        }

        static public void UsedAsset(string id)
        {
            if (workDataFilePath == "")
            {
                return;
            }

            if (usedAssetList.IndexOf(id) >= 0)
            {
                // すでに登録済み
                return;
            }

            usedAssetList.Add(id);

            SaveFile();
            return;
        }

        static public void UnUsedAsset(string id)
        {
            if (workDataFilePath == "")
            {
                return;
            }

            if (usedAssetList.IndexOf(id) < 0)
            {
                // 登録されていない
                return;
            }

            usedAssetList.Remove(id);

            SaveFile();
            return;
        }


        static public void LoadFile()
        {
            if (workDataFilePath == "")
            {
                return;
            }

            usedAssetList.Clear();

            using (StreamReader sr = new StreamReader(workDataFilePath))
            {
                while (sr.Peek() != -1)
                {
                    usedAssetList.Add(sr.ReadLine());
                }
            }
            return;
        }

        static public void SaveFile()
        {
            if (workDataFilePath == "")
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(workDataFilePath, false))
            {
                for(int cnt = 0; cnt < usedAssetList.Count(); cnt++)
                {
                    writer.WriteLine(usedAssetList[cnt]);
                }
            }
            return;
        }


    }
}
