using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer {
    public partial class fileExplorer : Form {

        private string filePath = @"C:\";
        private bool isFile = false;
        private string currentItemName;

        public fileExplorer() {
            InitializeComponent();
        }

        private void fileExplorer_Load(object sender, EventArgs e) {
            txtFilePath.Text = filePath;
            LoadFilesAndDirectories();
        }

        void loadButtonAction() {
            filePath = txtFilePath.Text;
            LoadFilesAndDirectories();
            isFile = false;
        }

        private void LoadFilesAndDirectories() {
            try {
                if (isFile) {

                       // Should Open The Process That Could Handle The File

                }else {
                    DirectoryInfo fdir;

                    fdir = new DirectoryInfo(filePath);
                    DirectoryInfo[] dirs = fdir.GetDirectories();
                    FileInfo[] files = fdir.GetFiles();

                    listView1.Clear();
                    foreach (var d in dirs)
                        listView1.Items.Add(d.Name, "folder");
                    foreach (var f in files) {
                        switch (f.Extension) {
                            case ".css":
                                listView1.Items.Add(f.Name, "css");
                                break;
                            case ".pdf":
                                listView1.Items.Add(f.Name, "pdf");
                                break;
                            case ".doc":
                                listView1.Items.Add(f.Name, "doc");
                                break;
                            case ".docx":
                                listView1.Items.Add(f.Name, "doc");
                                break;
                           case ".png":
                                listView1.Items.Add(f.Name, "png");
                                break;
                            case ".ppt":
                            case ".pptx":
                                listView1.Items.Add(f.Name, "ppt");
                                break;
                            case ".psd":
                                listView1.Items.Add(f.Name, "psd");
                                break;
                            case ".mp3":
                                listView1.Items.Add(f.Name, "mp3");
                                break;
                            case ".wav":
                                listView1.Items.Add(f.Name, "wav");
                                break;
                            case ".xls":
                                listView1.Items.Add(f.Name, "xls");
                                break;
                            case ".zip":
                                listView1.Items.Add(f.Name, "zip");
                                break;
                            case ".cpp":
                            case ".c":
                                listView1.Items.Add(f.Name, "c++");
                                break;
                            default:
                                listView1.Items.Add(f.Name, "documents");
                                break;
                        }
                    }

                }

            } catch (Exception e) { }

        }

        private void btnGo_Click(object sender, EventArgs e) {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            currentItemName = e.Item.Text;
            try {

                FileAttributes attr = File.GetAttributes(filePath + @"\" + currentItemName);
                if ( (attr & FileAttributes.Directory) == FileAttributes.Directory) {
                    isFile = false;
                    txtFilePath.Text = filePath + @"\" + currentItemName;
                }else {
                    isFile = true;
                    FileInfo f = new FileInfo(filePath + @"\" + currentItemName);
                    lbFileName.Text = f.Name;
                    lbFileType.Text = f.Extension;
                    lbLastAccess.Text = f.LastAccessTime.ToString();
                }
            }catch(Exception ex) { }
        }

        private void listView1_DoubleClick(object sender, EventArgs e) {
            loadButtonAction();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            try {
                txtFilePath.Text = filePath.Substring(0, filePath.LastIndexOf(@"\"));
                loadButtonAction();
                isFile = false;
            }catch(Exception ex) { }
        }
    }
}
