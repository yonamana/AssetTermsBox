using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AssetTermsBox
{
    /// <summary>
    /// ネットからコピーしてきたコード
    /// コード：https://qiita.com/chai0917/items/fbf33eb3db3cb1c82f27
    /// </summary>
    internal class C_ArraySort : IComparer<string>
    {
        // WIN32API
        private static class NativeMethods
        {
            [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
            public static extern int StrCmpLogicalW(string psz1, string psz2);
        }
        private C_ArraySort()
        {
        }
        public int Compare(string x, string y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x is null) return -1;
            if (y is null) return 1;
            // 文字列比較：自然順 - ここを変更することで任意の照合規則とすることが可能   
            return NativeMethods.StrCmpLogicalW(x, y);
        }
        public static C_ArraySort Natural
        {
            get
            {
                if (_Natural == null)
                    _Natural = new C_ArraySort();
                return _Natural;
            }
        }
        static C_ArraySort _Natural = null;
    }

    // 使い方
    // Array.Sort([ソートする配列], NaturalComparer.Natural);

}
