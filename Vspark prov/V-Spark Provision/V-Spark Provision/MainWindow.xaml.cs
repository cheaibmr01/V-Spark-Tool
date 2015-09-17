using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MessageBox = System.Windows.Forms.MessageBox;



namespace V_Spark_Provision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
    public partial class MainWindow : Window
    {
        private string foldernamePhysical;
        private string foldernameLogical;
        private string folderpath;
        private string tempSource;
        private string tempfinaldest;
        public MainWindow()
        {
            InitializeComponent();
           
            string originalname;

        }

        private void NewFolderName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //foldername = NewFolderName.Text;
            //NewFolderName.Clear();

        }



        public void CreateFolder()
        {

            Guid physicalname;

            //allows the user to input the name of folder that they want to create

            foldernameLogical = NewFolderName.Text;
            NewFolderName.Clear();

            //stores the Logical Name in variable
            TestLogic.Content = foldernameLogical;

            //stores the Logical Name in variable
            physicalname = Guid.NewGuid();
            TestPhysical.Content = physicalname;

            //create folder path

            //DB Connect:


            folderpath = @"C:\Users\mcheaib\Desktop\V-Spark";
            string pathstring = Path.Combine(folderpath, foldernameLogical);
            if (!Directory.Exists(pathstring))
            {
                Directory.CreateDirectory(pathstring);
                DatabaseConnect();
                MessageBox.Show("this folder location has been creted");

            }
            else
            {
                MessageBox.Show(
                    "A folder with the name you are trying to use already exists please try again with a new name");
            }

        }

        public void DatabaseConnect()
        {
            try
            {

                string cntst = null;
                SqlCommand cmd = new SqlCommand();
                SqlConnection cnn;
                string savelocation =
                    "use VSpark INSERT INTO dbo.VsparkFiles (physical_name,logical_name) VALUES ( @physicalname,@logicalname);";

                cntst =
                    "Data Source=casteldetect240;Initial Catalog=db_castel_stg;Integrated Security=False;User ID=DBAdmin;Password=DBAdmin";
                cnn = new SqlConnection(cntst);
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                SqlCommand SaveCommand = new SqlCommand(savelocation, cnn);
              
                SaveCommand.Parameters.AddWithValue("@physicalname", TestPhysical.Content);
                SaveCommand.Parameters.AddWithValue("@logicalname", TestLogic.Content);
                SaveCommand.ExecuteNonQuery();

                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        public void CountFiles()
        {

            int fileCount =
                Directory.GetFiles(tempSource, "*", SearchOption.AllDirectories).Length;
            MessageBox.Show("There were " + fileCount + " files copied to new Destination");

            //string[] filestorearray = Directory.GetFiles(@"C:\Users\mcheaib\Desktop\Store_V-Spark", "*.BIN*");

            //foreach (string name in filenamearray)
            //{
            //    MessageBox.Show(name);
            //}
        }


        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            CreateFolder();

        }


        private void SelectSource_Click(object sender, RoutedEventArgs e)
        {

            
            FolderBrowserDialog folderDlgSource = new FolderBrowserDialog();
            folderDlgSource.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlgSource.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {

                txtSourceDest.Text = folderDlgSource.SelectedPath;
                tempSource = txtSourceDest.Text;
            }
        }

        private void SelectDestn_Click(object sender, RoutedEventArgs e)
        {
            
            FolderBrowserDialog folderDlgSource = new FolderBrowserDialog();
            folderDlgSource.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlgSource.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {

                txtFinalDest.Text = folderDlgSource.SelectedPath;
                tempfinaldest = txtFinalDest.Text;

            }
        }

        private void CopySourceToDest_Click(object sender, RoutedEventArgs e)
        {

            string sourceFolder = tempSource;
            string destinationFolder = tempfinaldest;

            if (Directory.Exists(sourceFolder))
            {
                // Copy folder structure
                foreach (string sourceSubFolder in Directory.GetDirectories(sourceFolder, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(sourceSubFolder.Replace(sourceFolder, destinationFolder));
                }

                // Copy files
                foreach (string sourceFile in Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories))
                {
                    string destinationFile = sourceFile.Replace(sourceFolder, destinationFolder);
                    File.Copy(sourceFile, destinationFile, true);
                }
                CountFiles();
            }
        }

        
        
        //Buggs 
        //fix if source or final destination blank and view/count button is clicked application time out.
        //need to clear file list every time a view button is clicked

        private void View_Source_Files_Click(object sender, RoutedEventArgs e)
        {
            TitleBar.Content = "Source Files: " + tempSource;
            string[] SourceFiles = Directory.GetFiles(tempSource, "*.*", SearchOption.AllDirectories);
            int sc = 0;
            foreach (string sfile in SourceFiles)
            {
                SourceFiles[sc] = sfile;
                SourceFileList.Items.Add(SourceFiles[sc]);
                sc++;
                FilesCountLabel.Content = "The number of files in the Source Directory is: " + sc;
            }
        }

        private void View_Desination_Files_Click(object sender, RoutedEventArgs e)
        {
            TitleBar.Content = "Destination Files: " + tempfinaldest;
            string[] DestinationFiles = Directory.GetFiles(tempfinaldest, "*.*", SearchOption.AllDirectories);
            int dc = 0;
            foreach (string dfile in DestinationFiles)
            {
                DestinationFiles[dc] = dfile;
                SourceFileList.Items.Add(DestinationFiles[dc]);
                dc++;
                FilesCountLabel.Content = "The number of files in the Source Directory is: " + dc;
            }

        }

      

   
    }
}


        
    



    

           

       
    


