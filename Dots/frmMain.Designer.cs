namespace Dots {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSpawnAmount = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tmrClick = new System.Windows.Forms.Timer(this.components);
            this.chkRound = new System.Windows.Forms.CheckBox();
            this.chkFillObjects = new System.Windows.Forms.CheckBox();
            this.btnColour = new System.Windows.Forms.Button();
            this.chkRainbow = new System.Windows.Forms.CheckBox();
            this.cbxPhysics = new System.Windows.Forms.ComboBox();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudSpawnAmount = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(710, 22);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(104, 16);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Particle Speed:";
            this.lblSpeed.Visible = false;
            // 
            // lblSpawnAmount
            // 
            this.lblSpawnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpawnAmount.AutoSize = true;
            this.lblSpawnAmount.ForeColor = System.Drawing.Color.White;
            this.lblSpawnAmount.Location = new System.Drawing.Point(710, 87);
            this.lblSpawnAmount.Name = "lblSpawnAmount";
            this.lblSpawnAmount.Size = new System.Drawing.Size(127, 16);
            this.lblSpawnAmount.TabIndex = 3;
            this.lblSpawnAmount.Text = "Spawn Amount (/t):";
            this.lblSpawnAmount.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(710, 152);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 16);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            this.lblSize.Visible = false;
            // 
            // tmrClick
            // 
            this.tmrClick.Interval = 1;
            this.tmrClick.Tick += new System.EventHandler(this.tmrClick_Tick);
            // 
            // chkRound
            // 
            this.chkRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRound.AutoSize = true;
            this.chkRound.BackColor = System.Drawing.Color.Transparent;
            this.chkRound.ForeColor = System.Drawing.Color.White;
            this.chkRound.Location = new System.Drawing.Point(716, 224);
            this.chkRound.Name = "chkRound";
            this.chkRound.Size = new System.Drawing.Size(121, 20);
            this.chkRound.TabIndex = 6;
            this.chkRound.Text = "Round Objects";
            this.chkRound.UseVisualStyleBackColor = false;
            this.chkRound.Visible = false;
            // 
            // chkFillObjects
            // 
            this.chkFillObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFillObjects.AutoSize = true;
            this.chkFillObjects.BackColor = System.Drawing.Color.Transparent;
            this.chkFillObjects.ForeColor = System.Drawing.Color.White;
            this.chkFillObjects.Location = new System.Drawing.Point(740, 250);
            this.chkFillObjects.Name = "chkFillObjects";
            this.chkFillObjects.Size = new System.Drawing.Size(97, 20);
            this.chkFillObjects.TabIndex = 7;
            this.chkFillObjects.Text = "Fill Objects";
            this.chkFillObjects.UseVisualStyleBackColor = false;
            this.chkFillObjects.Visible = false;
            // 
            // btnColour
            // 
            this.btnColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColour.Location = new System.Drawing.Point(762, 302);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(75, 23);
            this.btnColour.TabIndex = 8;
            this.btnColour.Text = "Colour";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Visible = false;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // chkRainbow
            // 
            this.chkRainbow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRainbow.AutoSize = true;
            this.chkRainbow.BackColor = System.Drawing.Color.Transparent;
            this.chkRainbow.ForeColor = System.Drawing.Color.White;
            this.chkRainbow.Location = new System.Drawing.Point(744, 276);
            this.chkRainbow.Name = "chkRainbow";
            this.chkRainbow.Size = new System.Drawing.Size(93, 20);
            this.chkRainbow.TabIndex = 9;
            this.chkRainbow.Text = "Rainbows!";
            this.chkRainbow.UseVisualStyleBackColor = false;
            this.chkRainbow.Visible = false;
            // 
            // cbxPhysics
            // 
            this.cbxPhysics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPhysics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPhysics.FormattingEnabled = true;
            this.cbxPhysics.ItemHeight = 16;
            this.cbxPhysics.Location = new System.Drawing.Point(716, 331);
            this.cbxPhysics.Name = "cbxPhysics";
            this.cbxPhysics.Size = new System.Drawing.Size(121, 24);
            this.cbxPhysics.TabIndex = 10;
            this.cbxPhysics.Visible = false;
            this.cbxPhysics.SelectedIndexChanged += new System.EventHandler(this.cbxPhysics_SelectedIndexChanged);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSpeed.Location = new System.Drawing.Point(713, 41);
            this.nudSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 23);
            this.nudSpeed.TabIndex = 11;
            this.nudSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSpeed.Visible = false;
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // nudSpawnAmount
            // 
            this.nudSpawnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSpawnAmount.Location = new System.Drawing.Point(713, 106);
            this.nudSpawnAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpawnAmount.Name = "nudSpawnAmount";
            this.nudSpawnAmount.Size = new System.Drawing.Size(120, 23);
            this.nudSpawnAmount.TabIndex = 12;
            this.nudSpawnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSpawnAmount.Visible = false;
            this.nudSpawnAmount.ValueChanged += new System.EventHandler(this.nudSpawnAmount_ValueChanged);
            // 
            // nudSize
            // 
            this.nudSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSize.Location = new System.Drawing.Point(713, 171);
            this.nudSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 23);
            this.nudSize.TabIndex = 13;
            this.nudSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSize.Visible = false;
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(859, 639);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.nudSpawnAmount);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.cbxPhysics);
            this.Controls.Add(this.chkRainbow);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.chkFillObjects);
            this.Controls.Add(this.chkRound);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSpawnAmount);
            this.Controls.Add(this.lblSpeed);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Main (F10 to Toggle UI, F11 to Toggle Fullscreen)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawnAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSpawnAmount;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Timer tmrClick;
        private System.Windows.Forms.CheckBox chkRound;
        private System.Windows.Forms.CheckBox chkFillObjects;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.CheckBox chkRainbow;
        private System.Windows.Forms.ComboBox cbxPhysics;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudSpawnAmount;
        private System.Windows.Forms.NumericUpDown nudSize;
    }
}

