using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTermsBox
{
    internal class C_ManageForm
    {
        static FormWorkStart m_formWorkStart = null;
        static FormAssetInsert m_formAssetInsert = null;
        static FormAssetUpdate m_formAssetUpdate = null;
        static FormTagInsert m_formTagInsert = null;
        static FormTagUpdate m_formTagUpdate = null;

        static FormTagDelete m_formTagDelete = null;
        static FormUsed m_formUsed = null;


        static public void StartWorkStart(FormMain formMain)
        {
            // フォーム表示
            if (m_formWorkStart == null || m_formWorkStart.IsDisposed == true)
            {
                m_formWorkStart = new FormWorkStart(formMain);
                m_formWorkStart.ShowDialog();
            }
            else
            {
                m_formWorkStart.WindowState = FormWindowState.Normal;
                m_formWorkStart.Activate();
            }
            return;
        }


        static public void StartAssetInsert(FormMain formMain)
        {
            // フォーム表示
            if (m_formAssetInsert == null || m_formAssetInsert.IsDisposed == true)
            {
                m_formAssetInsert = new FormAssetInsert(formMain);
                m_formAssetInsert.ShowDialog();
            }
            else
            {
                m_formAssetInsert.WindowState = FormWindowState.Normal;
                m_formAssetInsert.Activate();
            }
            return;
        }

        static public void StartAssetUpdate(FormMain formMain, string assetId)
        {
            // フォーム表示
            if (m_formAssetUpdate == null || m_formAssetUpdate.IsDisposed == true)
            {
                m_formAssetUpdate = new FormAssetUpdate(formMain, assetId);
                m_formAssetUpdate.ShowDialog();
            }
            else
            {
                m_formAssetUpdate.WindowState = FormWindowState.Normal;
                m_formAssetUpdate.Activate();
            }
            return;
        }

        static public void StartFormTagInsert(FormMain formMain)
        {
            // フォーム表示
            if (m_formTagInsert == null || m_formTagInsert.IsDisposed == true)
            {
                m_formTagInsert = new FormTagInsert(formMain);
                m_formTagInsert.ShowDialog();
            }
            else
            {
                m_formTagInsert.WindowState = FormWindowState.Normal;
                m_formTagInsert.Activate();
            }
            return;
        }

        static public void StartFormTagUpdate(FormMain formMain)
        {
            // フォーム表示
            if (m_formTagUpdate == null || m_formTagUpdate.IsDisposed == true)
            {
                m_formTagUpdate = new FormTagUpdate(formMain);
                m_formTagUpdate.ShowDialog();
            }
            else
            {
                m_formTagUpdate.WindowState = FormWindowState.Normal;
                m_formTagUpdate.Activate();
            }
            return;
        }

        static public void StartFormTagDelete(FormMain formMain)
        {
            // フォーム表示
            if (m_formTagDelete == null || m_formTagDelete.IsDisposed == true)
            {
                m_formTagDelete = new FormTagDelete(formMain);
                m_formTagDelete.ShowDialog();
            }
            else
            {
                m_formTagDelete.WindowState = FormWindowState.Normal;
                m_formTagDelete.Activate();
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
