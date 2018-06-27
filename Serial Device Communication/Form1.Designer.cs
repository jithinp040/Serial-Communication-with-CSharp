namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.cSelectPort = new System.Windows.Forms.ComboBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.textReceived = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Clear = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // cSelectPort
            // 
            this.cSelectPort.FormattingEnabled = true;
            this.cSelectPort.Location = new System.Drawing.Point(122, 24);
            this.cSelectPort.Name = "cSelectPort";
            this.cSelectPort.Size = new System.Drawing.Size(202, 29);
            this.cSelectPort.TabIndex = 1;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(363, 22);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(99, 31);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(69, 90);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(516, 98);
            this.textMsg.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(486, 205);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 31);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(486, 366);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(99, 31);
            this.btnReceive.TabIndex = 7;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // textReceived
            // 
            this.textReceived.Location = new System.Drawing.Point(69, 251);
            this.textReceived.Multiline = true;
            this.textReceived.Name = "textReceived";
            this.textReceived.Size = new System.Drawing.Size(516, 98);
            this.textReceived.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(322, 366);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 31);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "clearData";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(178, 366);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(99, 31);
            this.Scan.TabIndex = 9;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 340);
            this.textBox1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(630, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 385);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.textReceived);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.cSelectPort);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cSelectPort;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox textReceived;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

