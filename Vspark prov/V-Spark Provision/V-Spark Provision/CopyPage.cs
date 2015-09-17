using System;
using System.Windows.Forms;

namespace V_Spark_Provision
{

 
    
    public partial class CopyPage : Form
    {
        public CopyPage()
        {
            InitializeComponent();

        }

        private void cmdSelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlgSource = new FolderBrowserDialog();
            folderDlgSource.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlgSource.ShowDialog();
            if (result == DialogResult.OK)
            {
             
                txtSourceDest.Text = folderDlgSource.SelectedPath;
                //Environment.SpecialFolder root = folderDlg.RootFolder;
                // = txtSourceDest.Text;
            }
        }

        private void cmdSelectDestination_Click(object sender, EventArgs e)
        {
            string tempfinaldest;
            FolderBrowserDialog folderDlgSource = new FolderBrowserDialog();
            folderDlgSource.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlgSource.ShowDialog();
            if (result == DialogResult.OK)
            {

               txtFinalDest.Text = folderDlgSource.SelectedPath;
              
            }
        }

        private void CopyPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
