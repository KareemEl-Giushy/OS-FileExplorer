
namespace FileExplorer {
    partial class fileExplorer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fileExplorer));
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFileType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLastAccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(-1, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(694, 300);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "avi");
            this.iconList.Images.SetKeyName(1, "c++");
            this.iconList.Images.SetKeyName(2, "css");
            this.iconList.Images.SetKeyName(3, "doc");
            this.iconList.Images.SetKeyName(4, "documents");
            this.iconList.Images.SetKeyName(5, "mp3");
            this.iconList.Images.SetKeyName(6, "pdf");
            this.iconList.Images.SetKeyName(7, "png");
            this.iconList.Images.SetKeyName(8, "ppt");
            this.iconList.Images.SetKeyName(9, "psd");
            this.iconList.Images.SetKeyName(10, "table");
            this.iconList.Images.SetKeyName(11, "wav");
            this.iconList.Images.SetKeyName(12, "xls");
            this.iconList.Images.SetKeyName(13, "zip");
            this.iconList.Images.SetKeyName(14, "folder");
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(93, 21);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(509, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(608, 19);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Name:";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(78, 375);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(13, 13);
            this.lbFileName.TabIndex = 5;
            this.lbFileName.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Type:";
            // 
            // lbFileType
            // 
            this.lbFileType.AutoSize = true;
            this.lbFileType.Location = new System.Drawing.Point(596, 375);
            this.lbFileType.Name = "lbFileType";
            this.lbFileType.Size = new System.Drawing.Size(13, 13);
            this.lbFileType.TabIndex = 7;
            this.lbFileType.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Access Time:";
            // 
            // lbLastAccess
            // 
            this.lbLastAccess.AutoSize = true;
            this.lbLastAccess.Location = new System.Drawing.Point(365, 375);
            this.lbLastAccess.Name = "lbLastAccess";
            this.lbLastAccess.Size = new System.Drawing.Size(13, 13);
            this.lbLastAccess.TabIndex = 9;
            this.lbLastAccess.Text = "--";
            // 
            // fileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 411);
            this.Controls.Add(this.lbLastAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFileType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fileExplorer";
            this.Text = " ";
            this.Load += new System.EventHandler(this.fileExplorer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFileType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLastAccess;
    }
}

