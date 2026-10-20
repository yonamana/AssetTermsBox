using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    internal class C_ManageForm
    {
        static FormWorkStart m_formWorkStart = null;
        static FormAssetInsert m_formAssetInsert = null;
        static FormUsed m_formUsed = null;


        static public void StartWorkStart()
        {
            // フォーム表示
            if (m_formWorkStart == null || m_formWorkStart.IsDisposed == true)
            {
                m_formWorkStart = new FormWorkStart();
                m_formWorkStart.ShowDialog();
            }
            else
            {
                m_formWorkStart.WindowState = FormWindowState.Normal;
                m_formWorkStart.Activate();
            }
            return;
        }


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

        static public void StartFormUsed()
        {
            // フォーム表示
            if (m_formUsed == null || m_formUsed.IsDisposed == true)
            {
                m_formUsed = new FormUsed();
                m_formUsed.ShowDialog();
            }
            else
            {
                m_formUsed.WindowState = FormWindowState.Normal;
                m_formUsed.Activate();
            }
            return;
        }


    }
}
