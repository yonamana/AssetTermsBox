using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    internal class C_ManageForm
    {
        static FormAssetInsert m_formAssetInsert = null;


        static public void StartAssetInsert()
        {
            // フォーム表示
            if (m_formAssetInsert == null || m_formAssetInsert.IsDisposed == true)
            {
                m_formAssetInsert = new FormAssetInsert();
                m_formAssetInsert.ShowDialog();
            }
            else
            {
                m_formAssetInsert.WindowState = FormWindowState.Normal;
                m_formAssetInsert.Activate();
            }
            return;
        }




    }
}
