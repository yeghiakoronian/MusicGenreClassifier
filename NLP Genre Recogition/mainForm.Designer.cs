namespace NLP_Genre_Recogition
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ribbonTab1 = new Janus.Windows.Ribbon.RibbonTab();
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.ribbon1 = new Janus.Windows.Ribbon.Ribbon();
            this.btn_voiceCommand = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_Exit = new Janus.Windows.Ribbon.ButtonCommand();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ribbonTab2 = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup1 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btn_PasteTest = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_OpenFileTest = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup2 = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommand1 = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommand3 = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup3 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btn_VoiceTest = new Janus.Windows.Ribbon.ButtonCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.commandBox1 = new Janus.Windows.Ribbon.CommandBox();
            this.btn_CameraOCRTest = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_ScannerOCRTest = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_ImageOCRTest = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup7 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btn_CMatrix = new Janus.Windows.Ribbon.ButtonCommand();
            this.tab_Train = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup4 = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommand2 = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_OpenFileTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup5 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btn_DataBaseTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_DataTableTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup6 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btn_VoiceTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.separatorCommand2 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.commandBox2 = new Janus.Windows.Ribbon.CommandBox();
            this.btn_CameraOCRTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_ScannerOCRTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.btn_ImageOCRTrain = new Janus.Windows.Ribbon.ButtonCommand();
            this.openFileDialogLyric = new System.Windows.Forms.OpenFileDialog();
            this.btn_getPaste = new Janus.Windows.EditControls.UIButton();
            this.ribbonStatusBar1 = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_audioCommandOn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(165, 570);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(504, 80);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Key = "ribbonTab1";
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab 1";
            // 
            // dropDownCommand1
            // 
            this.dropDownCommand1.Key = "dropDownCommand1";
            this.dropDownCommand1.Name = "dropDownCommand1";
            this.dropDownCommand1.Text = "Voice Commands";
            // 
            // dropDownCommand2
            // 
            this.dropDownCommand2.Key = "dropDownCommand2";
            this.dropDownCommand2.Name = "dropDownCommand2";
            this.dropDownCommand2.Text = "Exit";
            // 
            // ribbon1
            // 
            this.ribbon1.BackstageMenuData = "<?xml version=\"1.0\" encoding=\"utf-8\"?><BackstageMenu><ImageKey /><Key /><Text>Fil" +
    "e</Text></BackstageMenu>";
            this.ribbon1.ControlBoxMenu.LeftCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_voiceCommand,
            this.btn_Exit});
            // 
            // 
            // 
            this.ribbon1.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbon1.HelpButton.Image")));
            this.ribbon1.HelpButton.Key = "HelpButton";
            this.ribbon1.ImageList = this.imageList1;
            this.ribbon1.LargeImageList = this.imageList1;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Size = new System.Drawing.Size(866, 162);
            // 
            // 
            // 
            this.ribbon1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbon1.SuperTipComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.SuperTipComponent.ImageList = this.imageList1;
            this.ribbon1.TabIndex = 6;
            this.ribbon1.Tabs.AddRange(new Janus.Windows.Ribbon.RibbonTab[] {
            this.ribbonTab2,
            this.tab_Train});
            this.ribbon1.Text = "";
            this.ribbon1.CommandClick += new Janus.Windows.Ribbon.CommandEventHandler(this.ribbon1_CommandClick);
            // 
            // btn_voiceCommand
            // 
            this.btn_voiceCommand.CheckOnClick = true;
            this.btn_voiceCommand.Image = ((System.Drawing.Image)(resources.GetObject("btn_voiceCommand.Image")));
            this.btn_voiceCommand.Key = "btn_voiceCommand";
            this.btn_voiceCommand.Name = "btn_voiceCommand";
            this.btn_voiceCommand.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.btn_voiceCommand.Style = Janus.Windows.Ribbon.CommandStyle.ImageAndText;
            this.btn_voiceCommand.Text = "Voice Command";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Key = "btn_Exit";
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Text = "Exit";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RecordScreenVoice_32x.png");
            this.imageList1.Images.SetKeyName(1, "NLPICON.ico");
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroup1,
            this.ribbonGroup2,
            this.ribbonGroup3,
            this.ribbonGroup7});
            this.ribbonTab2.Key = "tab_Test";
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Test";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_PasteTest,
            this.btn_OpenFileTest});
            this.ribbonGroup1.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup1;
            this.ribbonGroup1.ImageKey = "";
            this.ribbonGroup1.Key = "ribbonGroup1";
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "File";
            // 
            // btn_PasteTest
            // 
            this.btn_PasteTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_PasteTest.Image")));
            this.btn_PasteTest.Key = "btn_PasteTest";
            this.btn_PasteTest.Name = "btn_PasteTest";
            this.btn_PasteTest.Text = "Paste";
            // 
            // btn_OpenFileTest
            // 
            this.btn_OpenFileTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFileTest.Image")));
            this.btn_OpenFileTest.Key = "btn_OpenFileTest";
            this.btn_OpenFileTest.Name = "btn_OpenFileTest";
            this.btn_OpenFileTest.Text = "Open";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommand1,
            this.buttonCommand3});
            this.ribbonGroup2.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup2;
            this.ribbonGroup2.ImageKey = "";
            this.ribbonGroup2.Key = "ribbonGroup2";
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Data";
            // 
            // buttonCommand1
            // 
            this.buttonCommand1.Image = ((System.Drawing.Image)(resources.GetObject("buttonCommand1.Image")));
            this.buttonCommand1.Key = "btn_DataBaseTest";
            this.buttonCommand1.Name = "buttonCommand1";
            this.buttonCommand1.Text = "DataBase";
            // 
            // buttonCommand3
            // 
            this.buttonCommand3.Image = ((System.Drawing.Image)(resources.GetObject("buttonCommand3.Image")));
            this.buttonCommand3.Key = "btn_DataTableTest";
            this.buttonCommand3.Name = "buttonCommand3";
            this.buttonCommand3.Text = "DataTable";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_VoiceTest,
            this.separatorCommand1,
            this.commandBox1});
            this.ribbonGroup3.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup3;
            this.ribbonGroup3.ImageKey = "";
            this.ribbonGroup3.Key = "ribbonGroup3";
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Intelligent";
            // 
            // btn_VoiceTest
            // 
            this.btn_VoiceTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_VoiceTest.Image")));
            this.btn_VoiceTest.Key = "btn_VoiceTest";
            this.btn_VoiceTest.Name = "btn_VoiceTest";
            this.btn_VoiceTest.Text = "Voice";
            // 
            // separatorCommand1
            // 
            this.separatorCommand1.Key = "SeparatorCommand1";
            this.separatorCommand1.Name = "separatorCommand1";
            // 
            // commandBox1
            // 
            this.commandBox1.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_CameraOCRTest,
            this.btn_ScannerOCRTest,
            this.btn_ImageOCRTest});
            this.commandBox1.Key = "CommandBox1";
            this.commandBox1.Name = "commandBox1";
            // 
            // btn_CameraOCRTest
            // 
            this.btn_CameraOCRTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_CameraOCRTest.Image")));
            this.btn_CameraOCRTest.Key = "btn_CameraOCRTest";
            this.btn_CameraOCRTest.Name = "btn_CameraOCRTest";
            this.btn_CameraOCRTest.Text = "Camera OCR";
            // 
            // btn_ScannerOCRTest
            // 
            this.btn_ScannerOCRTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_ScannerOCRTest.Image")));
            this.btn_ScannerOCRTest.Key = "btn_ScannerOCRTest";
            this.btn_ScannerOCRTest.Name = "btn_ScannerOCRTest";
            this.btn_ScannerOCRTest.Text = "Scanner OCR";
            // 
            // btn_ImageOCRTest
            // 
            this.btn_ImageOCRTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImageOCRTest.Image")));
            this.btn_ImageOCRTest.Key = "btn_ImageOCRTest";
            this.btn_ImageOCRTest.Name = "btn_ImageOCRTest";
            this.btn_ImageOCRTest.Text = "Image OCR";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_CMatrix});
            this.ribbonGroup7.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup7;
            this.ribbonGroup7.ImageKey = "";
            this.ribbonGroup7.Key = "RibbonGroup4";
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Text = "Analysis";
            // 
            // btn_CMatrix
            // 
            this.btn_CMatrix.Image = ((System.Drawing.Image)(resources.GetObject("btn_CMatrix.Image")));
            this.btn_CMatrix.Key = "btn_CMatrix";
            this.btn_CMatrix.Name = "btn_CMatrix";
            this.btn_CMatrix.Text = "Confusion Matrix";
            // 
            // tab_Train
            // 
            this.tab_Train.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroup4,
            this.ribbonGroup5,
            this.ribbonGroup6});
            this.tab_Train.Key = "tab_Train";
            this.tab_Train.Name = "tab_Train";
            this.tab_Train.Text = "Train";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommand2,
            this.btn_OpenFileTrain});
            this.ribbonGroup4.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup4;
            this.ribbonGroup4.ImageKey = "";
            this.ribbonGroup4.Key = "RibbonGroup1";
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "File";
            // 
            // buttonCommand2
            // 
            this.buttonCommand2.Image = ((System.Drawing.Image)(resources.GetObject("buttonCommand2.Image")));
            this.buttonCommand2.Key = "btn_PasteTrain";
            this.buttonCommand2.Name = "buttonCommand2";
            this.buttonCommand2.Text = "Paste";
            // 
            // btn_OpenFileTrain
            // 
            this.btn_OpenFileTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFileTrain.Image")));
            this.btn_OpenFileTrain.Key = "btn_OpenFileTrain";
            this.btn_OpenFileTrain.Name = "btn_OpenFileTrain";
            this.btn_OpenFileTrain.Text = "Open";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_DataBaseTrain,
            this.btn_DataTableTrain});
            this.ribbonGroup5.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup5;
            this.ribbonGroup5.ImageKey = "";
            this.ribbonGroup5.Key = "RibbonGroup2";
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Data";
            // 
            // btn_DataBaseTrain
            // 
            this.btn_DataBaseTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_DataBaseTrain.Image")));
            this.btn_DataBaseTrain.Key = "btn_DataBaseTrain";
            this.btn_DataBaseTrain.Name = "btn_DataBaseTrain";
            this.btn_DataBaseTrain.Text = "DataBase";
            // 
            // btn_DataTableTrain
            // 
            this.btn_DataTableTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_DataTableTrain.Image")));
            this.btn_DataTableTrain.Key = "btn_DataTableTrain";
            this.btn_DataTableTrain.Name = "btn_DataTableTrain";
            this.btn_DataTableTrain.Text = "DataTable";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_VoiceTrain,
            this.separatorCommand2,
            this.commandBox2});
            this.ribbonGroup6.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup6;
            this.ribbonGroup6.ImageKey = "";
            this.ribbonGroup6.Key = "RibbonGroup3";
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Intelligent";
            // 
            // btn_VoiceTrain
            // 
            this.btn_VoiceTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_VoiceTrain.Image")));
            this.btn_VoiceTrain.Key = "btn_VoiceTrain";
            this.btn_VoiceTrain.Name = "btn_VoiceTrain";
            this.btn_VoiceTrain.Text = "Voice";
            // 
            // separatorCommand2
            // 
            this.separatorCommand2.Key = "SeparatorCommand1";
            this.separatorCommand2.Name = "separatorCommand2";
            // 
            // commandBox2
            // 
            this.commandBox2.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btn_CameraOCRTrain,
            this.btn_ScannerOCRTrain,
            this.btn_ImageOCRTrain});
            this.commandBox2.Key = "CommandBox1";
            this.commandBox2.Name = "commandBox2";
            // 
            // btn_CameraOCRTrain
            // 
            this.btn_CameraOCRTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_CameraOCRTrain.Image")));
            this.btn_CameraOCRTrain.Key = "btn_CameraOCRTrain";
            this.btn_CameraOCRTrain.Name = "btn_CameraOCRTrain";
            this.btn_CameraOCRTrain.Text = "Camera OCR";
            // 
            // btn_ScannerOCRTrain
            // 
            this.btn_ScannerOCRTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_ScannerOCRTrain.Image")));
            this.btn_ScannerOCRTrain.Key = "btn_ScannerOCRTrain";
            this.btn_ScannerOCRTrain.Name = "btn_ScannerOCRTrain";
            this.btn_ScannerOCRTrain.Text = "Scanner OCR";
            // 
            // btn_ImageOCRTrain
            // 
            this.btn_ImageOCRTrain.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImageOCRTrain.Image")));
            this.btn_ImageOCRTrain.Key = "btn_ImageOCRTrain";
            this.btn_ImageOCRTrain.KeyTip = "btn_ImageOCRTrain";
            this.btn_ImageOCRTrain.Name = "btn_ImageOCRTrain";
            this.btn_ImageOCRTrain.Text = "Image OCR";
            // 
            // btn_getPaste
            // 
            this.btn_getPaste.Location = new System.Drawing.Point(367, 524);
            this.btn_getPaste.Name = "btn_getPaste";
            this.btn_getPaste.Size = new System.Drawing.Size(101, 23);
            this.btn_getPaste.TabIndex = 8;
            this.btn_getPaste.Text = "Test";
            this.btn_getPaste.Visible = false;
            this.btn_getPaste.Click += new System.EventHandler(this.btn_getPaste_Click);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 738);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(866, 23);
            // 
            // 
            // 
            this.ribbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbonStatusBar1.SuperTipComponent.ImageList = null;
            this.ribbonStatusBar1.TabIndex = 9;
            this.ribbonStatusBar1.Text = "ribbonStatusBar1";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 202);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(866, 316);
            this.richTextBox.TabIndex = 10;
            this.richTextBox.Text = "";
            this.richTextBox.Visible = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // btn_audioCommandOn
            // 
            this.btn_audioCommandOn.Location = new System.Drawing.Point(13, 679);
            this.btn_audioCommandOn.Name = "btn_audioCommandOn";
            this.btn_audioCommandOn.Size = new System.Drawing.Size(152, 23);
            this.btn_audioCommandOn.TabIndex = 11;
            this.btn_audioCommandOn.Text = "Audio Command On";
            this.btn_audioCommandOn.UseVisualStyleBackColor = true;
            this.btn_audioCommandOn.Click += new System.EventHandler(this.btn_audioCommandOn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 679);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Audio Command Off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_audioCommandOn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.btn_getPaste);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "COMP 6781: NLP    Genre Recognition";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private Janus.Windows.Ribbon.RibbonTab ribbonTab1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.Ribbon ribbon1;
        private System.Windows.Forms.OpenFileDialog openFileDialogLyric;
        private Janus.Windows.Ribbon.RibbonTab tab_Train;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup4;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup5;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup6;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand2;
        private Janus.Windows.Ribbon.ButtonCommand btn_OpenFileTrain;
        private Janus.Windows.Ribbon.ButtonCommand btn_DataBaseTrain;
        private Janus.Windows.Ribbon.ButtonCommand btn_DataTableTrain;
        private Janus.Windows.Ribbon.ButtonCommand btn_VoiceTrain;
        private Janus.Windows.EditControls.UIButton btn_getPaste;
        private Janus.Windows.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private Janus.Windows.Ribbon.ButtonCommand btn_voiceCommand;
        private Janus.Windows.Ribbon.ButtonCommand btn_Exit;
        private Janus.Windows.Ribbon.RibbonTab ribbonTab2;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup1;
        private Janus.Windows.Ribbon.ButtonCommand btn_PasteTest;
        private Janus.Windows.Ribbon.ButtonCommand btn_OpenFileTest;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup2;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand1;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand3;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup3;
        private Janus.Windows.Ribbon.ButtonCommand btn_VoiceTest;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.CommandBox commandBox1;
        private Janus.Windows.Ribbon.ButtonCommand btn_CameraOCRTest;
        private Janus.Windows.Ribbon.ButtonCommand btn_ScannerOCRTest;
        private Janus.Windows.Ribbon.ButtonCommand btn_ImageOCRTest;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand2;
        private Janus.Windows.Ribbon.CommandBox commandBox2;
        private Janus.Windows.Ribbon.ButtonCommand btn_CameraOCRTrain;
        private Janus.Windows.Ribbon.ButtonCommand btn_ScannerOCRTrain;
        private Janus.Windows.Ribbon.ButtonCommand btn_ImageOCRTrain;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup7;
        private Janus.Windows.Ribbon.ButtonCommand btn_CMatrix;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Button btn_audioCommandOn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

