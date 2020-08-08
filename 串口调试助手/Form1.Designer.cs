namespace 串口调试助手
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CheckPort = new System.Windows.Forms.Button();
            this.OpenPort = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hex = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Char = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReciveDataBlock = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SendDataBlock = new System.Windows.Forms.TextBox();
            this.SendData = new System.Windows.Forms.Button();
            this.ClearData = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckPort
            // 
            this.CheckPort.Location = new System.Drawing.Point(108, 237);
            this.CheckPort.Name = "CheckPort";
            this.CheckPort.Size = new System.Drawing.Size(75, 23);
            this.CheckPort.TabIndex = 0;
            this.CheckPort.Text = "检测串口";
            this.CheckPort.UseVisualStyleBackColor = true;
            this.CheckPort.Click += new System.EventHandler(this.CheckPort_Click);
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(18, 237);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(75, 23);
            this.OpenPort.TabIndex = 3;
            this.OpenPort.Text = "打开串口";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // Port
            // 
            this.Port.FormattingEnabled = true;
            this.Port.Location = new System.Drawing.Point(63, 23);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(119, 20);
            this.Port.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hex);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.Char);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.StopBits);
            this.groupBox1.Controls.Add(this.Parity);
            this.groupBox1.Controls.Add(this.DataBits);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.CheckPort);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.OpenPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 462);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // Hex
            // 
            this.Hex.AutoSize = true;
            this.Hex.Location = new System.Drawing.Point(108, 279);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(65, 16);
            this.Hex.TabIndex = 15;
            this.Hex.TabStop = true;
            this.Hex.Text = "Hex显示";
            this.Hex.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 136);
            this.listBox1.TabIndex = 8;
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // Char
            // 
            this.Char.AutoSize = true;
            this.Char.Location = new System.Drawing.Point(18, 279);
            this.Char.Name = "Char";
            this.Char.Size = new System.Drawing.Size(71, 16);
            this.Char.TabIndex = 14;
            this.Char.TabStop = true;
            this.Char.Text = "字符显示";
            this.Char.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "停止位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "端口号";
            // 
            // StopBits
            // 
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBits.Location = new System.Drawing.Point(63, 191);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(120, 20);
            this.StopBits.TabIndex = 8;
            // 
            // Parity
            // 
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.Parity.Location = new System.Drawing.Point(63, 149);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(119, 20);
            this.Parity.TabIndex = 7;
            // 
            // DataBits
            // 
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "9",
            "8",
            "7",
            "6",
            "5"});
            this.DataBits.Location = new System.Drawing.Point(63, 104);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(119, 20);
            this.DataBits.TabIndex = 6;
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200",
            "500000"});
            this.BaudRate.Location = new System.Drawing.Point(63, 62);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(119, 20);
            this.BaudRate.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReciveDataBlock);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 312);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区";
            // 
            // ReciveDataBlock
            // 
            this.ReciveDataBlock.FormattingEnabled = true;
            this.ReciveDataBlock.ItemHeight = 12;
            this.ReciveDataBlock.Location = new System.Drawing.Point(18, 23);
            this.ReciveDataBlock.Name = "ReciveDataBlock";
            this.ReciveDataBlock.Size = new System.Drawing.Size(436, 256);
            this.ReciveDataBlock.TabIndex = 6;
            this.ReciveDataBlock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReciveDataBlock_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "清空数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SendDataBlock);
            this.groupBox3.Controls.Add(this.SendData);
            this.groupBox3.Controls.Add(this.ClearData);
            this.groupBox3.Location = new System.Drawing.Point(217, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 144);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送区";
            // 
            // SendDataBlock
            // 
            this.SendDataBlock.Location = new System.Drawing.Point(18, 20);
            this.SendDataBlock.Multiline = true;
            this.SendDataBlock.Name = "SendDataBlock";
            this.SendDataBlock.Size = new System.Drawing.Size(436, 89);
            this.SendDataBlock.TabIndex = 4;
            // 
            // SendData
            // 
            this.SendData.Location = new System.Drawing.Point(272, 115);
            this.SendData.Name = "SendData";
            this.SendData.Size = new System.Drawing.Size(75, 23);
            this.SendData.TabIndex = 3;
            this.SendData.Text = "发送数据";
            this.SendData.UseVisualStyleBackColor = true;
            this.SendData.Click += new System.EventHandler(this.SendData_Click);
            // 
            // ClearData
            // 
            this.ClearData.Location = new System.Drawing.Point(353, 115);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(75, 23);
            this.ClearData.TabIndex = 2;
            this.ClearData.Text = "清空数据";
            this.ClearData.UseVisualStyleBackColor = true;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckPort;
        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox DataBits;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SendData;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.RadioButton Char;
        private System.Windows.Forms.RadioButton Hex;
        private System.Windows.Forms.TextBox SendDataBlock;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox ReciveDataBlock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}

