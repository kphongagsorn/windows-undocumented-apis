using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // needed for api imports
using System.Data;
using System.Data.SqlClient;// needed for SQL Server stored procedures
using System.Collections.Specialized;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Threading;

namespace windowsDemo
{
    public partial class frmWinAPI : Form
    {

         //Importing Windows API functions
	    [DllImport("user32")]
	    public static extern int SetWindowLongA(int hwnd, int nIndex, int dwNew);
	    [DllImport("user32")]
	    public static extern int GetWindowLongA(int hwnd, int nIndex);
        //Constants for minimize box and style
        private const Int32 WS_MINIMIZE = 0x20000; //0x20000 is for minimize button 0x10000 is for maximize button
        private const Int32 GWL_STYLE = -16;

        //for delete file api
        private bool booldeleted;
        private string filePath = "C:\\Users\\admin\\Desktop\\test.txt";

        // these are for swapping mouse buttons
        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        //delete file; added by me
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFile(string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileA([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteFileW([MarshalAs(UnmanagedType.LPWStr)]string lpFileName);

        
        //find volumes; added by me
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr FindFirstVolume([Out] StringBuilder lpszVolumeName,uint cchBufferLength);
        [DllImport("kernel32.dll")]
        public static extern bool FindNextVolume(IntPtr hFindVolume, [Out] StringBuilder lpszVolumeName, uint cchBufferLength);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FindVolumeClose(IntPtr hFindVolume);

        /*
        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool  IsElevationRequired(string pwszExeFile);
        */
        [DllImport("user32.dll")]
        public static extern int SetDeskWallpaper(string filename);



        public static StringCollection GetVolumes()
        {
            const uint N = 1024;
            StringBuilder volume = new StringBuilder((int)N, (int)N);
            StringCollection ret = new StringCollection();
            IntPtr volume_handle = FindFirstVolume(volume, N);
            do
            {
                ret.Add(volume.ToString());

            } while (FindNextVolume(volume_handle, volume, N));
            return ret;
        }

        private void FindFirstVolume()
        {
            throw new NotImplementedException();
        }
        private static bool FindNextVolume(FindVolumeSafeHandle volumeHandle, StringBuilder volume, uint bufferLength)
        {
            throw new NotImplementedException();
        }

        public class FindVolumeSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            private FindVolumeSafeHandle()
            : base(true)
            {
            }

            public FindVolumeSafeHandle(IntPtr preexistingHandle, bool ownsHandle)
            : base(ownsHandle)
            {
                SetHandle(preexistingHandle);
            }

            protected override bool ReleaseHandle()
            {
                return FindVolumeClose(handle);
            }
        }

        public frmWinAPI()
        {
            InitializeComponent();
        }



        private void btnDemo_Click(object sender, EventArgs e)
        {

            //Disable minimize button
            int intStyle;
	        intStyle = GetWindowLongA(this.Handle.ToInt32(), GWL_STYLE);// Get the form current style
            intStyle = intStyle & ~ (WS_MINIMIZE); //Disable the button
            intStyle = SetWindowLongA(this.Handle.ToInt32(), GWL_STYLE, intStyle); //Send the new style to the form
        }

        private void btnSwapMouse_Click(object sender, EventArgs e)
        {
            SwapMouseButton(1);
        }

        private void btnReturnMouse_Click(object sender, EventArgs e)
        {
            SwapMouseButton(0);
        }

        private void deleteFilebtn_Click(object sender, EventArgs e)
        {
            booldeleted = DeleteFileW(filePath);
        }

        private void findVolumesbtn_Click(object sender, EventArgs e)
        {
            
            foreach (string v in GetVolumes())
            {
                Console.WriteLine(v);
            }


        }


        private void cmdStoredProc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

       
            try
            {
                // put the connection string for your database here
                conn = new SqlConnection("Server=(local);DataBase=master;Integrated Security=SSPI");
                conn.Open();
                SqlCommand cmd = new SqlCommand("storedprocnamegoeshere", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                rdr = cmd.ExecuteReader();
           
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        private void frmWinAPI_Load(object sender, EventArgs e)
        {

        }
        
        private void setDeskWallpaperbtn_Click(object sender, EventArgs e)
        {
            SetDeskWallpaper("C:\\Users\\admin\\Pictures\\windows_xp.jpg");
        }
    }
}
