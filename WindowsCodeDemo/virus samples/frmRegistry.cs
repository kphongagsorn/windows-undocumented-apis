using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Win.32 needed to read/write the regsitry
using Microsoft.Win32;

namespace windowsDemo
{
    public partial class frmRegistry : Form
    {

        private string subKey = @"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management".ToUpper();  //access path from registry editor
        //private string subKey = "C:\\Windows\\System32\\config\\systemprofile\\ntuser.dat";
        //private string value = "ClearPageFileAtShutdown";
        private string value = "DisablePageCombining";
        private RegistryKey baseRegistryKey = Registry.LocalMachine;
        
        public frmRegistry()
        {
            InitializeComponent();
        }

        private void frmRegistry_Load(object sender, EventArgs e)
        {
            txtRegistrySubKey.Text = subKey.ToString();
            txtRegistryKey.Text = value;
           

        }

        public string ReadKey()
        {
         
                try
                {
                    
                    RegistryKey key = Registry.LocalMachine.OpenSubKey(txtRegistrySubKey.Text);
                    Object val = key.GetValue(txtRegistryKey.Text);

                    //HKEY_LOCAL_MACHINE\SYSTEM\CURRENTCONTROLSET\CONTROL\SESSION MANAGER\MEMORY MANAGEMENT
                    Console.WriteLine(key.ToString());

                    return  txtValue.Text = val.ToString();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e + "Reading registry " + txtRegistryKey.Text.ToString().ToUpper());
                    return null;
                }
           
        }

   
        public bool WriteKey(string KeyName, object Value)
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                // I have to use CreateSubKey 
                // (create or open it if already exits), 
                // 'cause OpenSubKey open a subKey as read-only
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                // Save the value
                sk1.SetValue(KeyName.ToUpper(), Value);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e+ "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }

    
        public bool DeleteKey(string KeyName)
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.CreateSubKey(subKey);
                // If the RegistrySubKey doesn't exists -> (true)
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);

                return true;
            }
            catch (Exception e)
            {
              
                MessageBox.Show(e+ "Deleting SubKey " + subKey);
                return false;
            }
        }

        public bool DeleteSubKeyTree()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists, I delete it
                if (sk1 != null)
                    rk.DeleteSubKeyTree(subKey);

                return true;
            }
            catch (Exception e)
            {
          
                MessageBox.Show(e+ "Deleting SubKey " + subKey);
                return false;
            }
        }

  
        public int SubKeyCount()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
               
                MessageBox.Show(e+ "Retriving subkeys of " + subKey);
                return 0;
            }
        }

        public int ValueCount()
        {
            try
            {
                // Setting
                RegistryKey rk = baseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistryKey exists...
                if (sk1 != null)
                    return sk1.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
              
                MessageBox.Show(e + "Retriving keys of " + subKey);
                return 0;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtValue.Text = ReadKey();

        }


   
    }
}
