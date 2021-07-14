namespace bunifu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuTextbox1 = new ns1.BunifuTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuDatepicker1 = new ns1.BunifuDatepicker();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuHTTP_Utils1 = new ns1.BunifuHTTP_Utils(this.components);
            this.bunifuiOSSwitch1 = new ns1.BunifuiOSSwitch();
            this.bunifuRating1 = new ns1.BunifuRating();
            this.bunifuSearchEngine1 = new ns1.BunifuSearchEngine();
            this.bunifuSlider1 = new ns1.BunifuSlider();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
            this.bunifuGauge1 = new ns1.BunifuGauge();
            this.bunifuWebClient1 = new ns1.BunifuWebClient(this.components);
            this.bunifuVTrackbar1 = new ns1.BunifuVTrackbar();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(941, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Maroon;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(142, 248);
            this.bunifuTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(333, 52);
            this.bunifuTextbox1.TabIndex = 1;
            this.bunifuTextbox1.text = "Bunifu TextBox";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Coral;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(119, 44);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(219, 29);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Enovation of YOU";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(598, 223);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(404, 44);
            this.bunifuDatepicker1.TabIndex = 3;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 7, 19, 2, 41, 31, 412);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(142, 320);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuHTTP_Utils1
            // 
            this.bunifuHTTP_Utils1.JobName = "";
            this.bunifuHTTP_Utils1.Url = "";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(29, 74);
            this.bunifuiOSSwitch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 5;
            this.bunifuiOSSwitch1.Value = true;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(37, 82);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(481, 93);
            this.bunifuRating1.TabIndex = 6;
            this.bunifuRating1.Value = 0;
            // 
            // bunifuSearchEngine1
            // 
            this.bunifuSearchEngine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSearchEngine1.Location = new System.Drawing.Point(598, 30);
            this.bunifuSearchEngine1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSearchEngine1.Name = "bunifuSearchEngine1";
            this.bunifuSearchEngine1.Size = new System.Drawing.Size(317, 54);
            this.bunifuSearchEngine1.TabIndex = 7;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(553, 30);
            this.bunifuSlider1.TabIndex = 8;
            this.bunifuSlider1.Value = 0;
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(37, 265);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 9;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(105, 404);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMaterialTextbox1.TabIndex = 10;
            this.bunifuMaterialTextbox1.Text = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuGauge1.Location = new System.Drawing.Point(501, 288);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge1.Size = new System.Drawing.Size(174, 117);
            this.bunifuGauge1.TabIndex = 11;
            this.bunifuGauge1.Thickness = 30;
            this.bunifuGauge1.Value = 0;
            // 
            // bunifuWebClient1
            // 
            this.bunifuWebClient1.AllowReadStreamBuffering = false;
            this.bunifuWebClient1.AllowWriteStreamBuffering = false;
            this.bunifuWebClient1.BaseAddress = "";
            this.bunifuWebClient1.CachePolicy = null;
            this.bunifuWebClient1.Credentials = null;
            this.bunifuWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("bunifuWebClient1.Encoding")));
            this.bunifuWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("bunifuWebClient1.Headers")));
            this.bunifuWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("bunifuWebClient1.QueryString")));
            this.bunifuWebClient1.UseDefaultCredentials = false;
            // 
            // bunifuVTrackbar1
            // 
            this.bunifuVTrackbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuVTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuVTrackbar1.BorderRadius = 0;
            this.bunifuVTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuVTrackbar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuVTrackbar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuVTrackbar1.MaximumValue = 100;
            this.bunifuVTrackbar1.Name = "bunifuVTrackbar1";
            this.bunifuVTrackbar1.Size = new System.Drawing.Size(30, 511);
            this.bunifuVTrackbar1.SliderRadius = 0;
            this.bunifuVTrackbar1.TabIndex = 12;
            this.bunifuVTrackbar1.Value = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 8);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(852, 43);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1054, 527);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuVTrackbar1);
            this.Controls.Add(this.bunifuGauge1);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.bunifuSearchEngine1);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ns1.BunifuTextbox bunifuTextbox1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuDatepicker bunifuDatepicker1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuVTrackbar bunifuVTrackbar1;
        private ns1.BunifuGauge bunifuGauge1;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private ns1.BunifuSlider bunifuSlider1;
        private ns1.BunifuSearchEngine bunifuSearchEngine1;
        private ns1.BunifuRating bunifuRating1;
        private ns1.BunifuiOSSwitch bunifuiOSSwitch1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuHTTP_Utils bunifuHTTP_Utils1;
        private ns1.BunifuWebClient bunifuWebClient1;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}

