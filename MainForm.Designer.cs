namespace SerialMonitor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cboxComport = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboxBaudrate = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tboxData = new System.Windows.Forms.TextBox();
            this.tboxReceive = new System.Windows.Forms.TextBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.cboxLinetype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxComport
            // 
            this.cboxComport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxComport.FormattingEnabled = true;
            this.cboxComport.Location = new System.Drawing.Point(8, 11);
            this.cboxComport.Name = "cboxComport";
            this.cboxComport.Size = new System.Drawing.Size(272, 21);
            this.cboxComport.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(373, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboxBaudrate
            // 
            this.cboxBaudrate.AllowDrop = true;
            this.cboxBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaudrate.Location = new System.Drawing.Point(261, 278);
            this.cboxBaudrate.Name = "cboxBaudrate";
            this.cboxBaudrate.Size = new System.Drawing.Size(103, 21);
            this.cboxBaudrate.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(289, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(373, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tboxData
            // 
            this.tboxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxData.Location = new System.Drawing.Point(8, 44);
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(356, 20);
            this.tboxData.TabIndex = 3;
            this.tboxData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxData_KeyPress);
            // 
            // tboxReceive
            // 
            this.tboxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxReceive.BackColor = System.Drawing.SystemColors.Window;
            this.tboxReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxReceive.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxReceive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxReceive.Location = new System.Drawing.Point(8, 71);
            this.tboxReceive.Multiline = true;
            this.tboxReceive.Name = "tboxReceive";
            this.tboxReceive.ReadOnly = true;
            this.tboxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxReceive.Size = new System.Drawing.Size(440, 199);
            this.tboxReceive.TabIndex = 5;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutput.Location = new System.Drawing.Point(373, 277);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 8;
            this.btnClearOutput.Text = "Clear output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // cboxLinetype
            // 
            this.cboxLinetype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxLinetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLinetype.FormattingEnabled = true;
            this.cboxLinetype.Location = new System.Drawing.Point(130, 278);
            this.cboxLinetype.Name = "cboxLinetype";
            this.cboxLinetype.Size = new System.Drawing.Size(121, 21);
            this.cboxLinetype.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 308);
            this.Controls.Add(this.cboxLinetype);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.tboxReceive);
            this.Controls.Add(this.tboxData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cboxBaudrate);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboxComport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(472, 347);
            this.Name = "MainForm";
            this.Text = "Arduino Serial Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboxBaudrate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.TextBox tboxReceive;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.ComboBox cboxLinetype;
    }
}

