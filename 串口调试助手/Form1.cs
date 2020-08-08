using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  //需要用到的串口类
//using System.Threading;
using System.Management;

namespace 串口调试助手
{
    public partial class Form1 : Form
    {
        public bool isHex = false;  //Data显示标志位
        public bool isOpen = false; //串口打开标志位
        public SerialPort serialPort;
        public bool Clossing;
        public bool Listening;
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            serialPort = new SerialPort();
            InitPortSet();
            SetToolTIP();
            //SearchComName();
        }

        public void Flag_Init()
        {
            Clossing = false;
            Listening = false;
        }
    
        void SearchComName()
        {
            listBox1.Items.Clear();
            string[] ss = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            for (int i = 0; i < ss.Length; i++)
            {
                listBox1.Items.Add(ss[i]);
            }
        }

        public enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }

        public static string[] MulGetHardwareInfo(HardwareEnum hardType, string propKey)
        {

            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value.ToString().Contains("COM"))
                        {
                            strs.Add(hardInfo.Properties[propKey].Value.ToString());
                        }

                    }
                    searcher.Dispose();
                }
                return strs.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            {
                strs = null;
            }
        }
        public void InitPortSet()
        {
            CheckPortFunc();
            SearchComName();
            Port.SelectedIndex = 0;
            BaudRate.SelectedIndex = 6;
            DataBits.SelectedIndex = 1;
            Parity.SelectedIndex = 0;
            StopBits.SelectedIndex = 0;
            Hex.Checked = true;
        }
        public void CheckPortFunc()
        {
            Port.Items.Clear();

            for (int i = 0; i < 30; i++)
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    //listBox1.Items.Add("COM"+(i+1).ToString()+"可用");
                    Port.Items.Add("COM" + (i + 1).ToString());
                }
                catch (Exception)
                {
                    //listBox1.Items.Add("COM" + (i + 1).ToString() + "不可用或不存在");
                    continue;
                }
        }

        private void CheckPort_Click(object sender, EventArgs e)    //检测可用串口
        {
            CheckPortFunc();
            SearchComName();
        }

        public bool CheckPortSet()  //检验串口设置
        {
            if (Port.Text.Trim() == "")     //  Trim()是用来删除头空白和尾空白的字符
                return false;
            if (BaudRate.Text.Trim() == "")     
                return false;
            if (DataBits.Text.Trim() == "")    
                return false;
            if (Parity.Text.Trim() == "")     
                return false;
            if (StopBits.Text.Trim() == "")    
                return false;
            return true;
        }

        public void SetPort()   //设置串口属性
        {
            serialPort = new SerialPort();
            serialPort.PortName = Port.Text.Trim();
            serialPort.BaudRate = Convert.ToInt32(BaudRate.Text.Trim());
            serialPort.DataBits = Convert.ToInt16(DataBits.Text.Trim());
            //奇偶校验
            if(Parity.Text.Trim() == "奇校验")
            {
                serialPort.Parity = System.IO.Ports.Parity.Odd;
            }
            if (Parity.Text.Trim() == "偶数校验")
            {
                serialPort.Parity = System.IO.Ports.Parity.Even;
            }
            else
            {
                serialPort.Parity = System.IO.Ports.Parity.None;
            }
            //停止位
            //if (StopBits.Text == "0")
            //{
            //    serialPort.StopBits = System.IO.Ports.StopBits.None;
            //}
            if (StopBits.Text.Trim() == "1")
            {
                serialPort.StopBits = System.IO.Ports.StopBits.One;
            }
            if (StopBits.Text.Trim() == "1.5")
            {
                serialPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
            }
            if (StopBits.Text.Trim() == "2")
            {
                serialPort.StopBits = System.IO.Ports.StopBits.Two;
            }
            serialPort.ReadTimeout = -1;    //设置超时读取时间  此处相当于不设置吗？
            serialPort.RtsEnable = true;        //????  

            //todo:此处需要加接受函数丢在这个时间里面  表示一个中断吧，接收到了数据自动执行？？？
            serialPort.DataReceived += new SerialDataReceivedEventHandler(ReviveData);  

            if (Hex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }           
        }

        public void CtrPortSet(bool init)
        {
            Port.Enabled = init;
            BaudRate.Enabled = init;
            DataBits.Enabled = init;
            Parity.Enabled = init;
            StopBits.Enabled = init;
            Hex.Enabled = init;
            Char.Enabled = init;
        }

        private void OpenPort_Click(object sender, EventArgs e)
        {           
            //串口未打开
            if(!isOpen)
            {
                //1.线检查串口配置是否都已选择                              
                if(!CheckPortSet())
                {
                    MessageBox.Show("未配置串口属性","错误提示");
                    return;
                }
                //2.配置串口
                SetPort();
                try
                {
                    //3.打开串口
                    serialPort.Open();
                    isOpen = true;
                    OpenPort.Text = "关闭串口";
                    //4.将串口设置部分都失能
                    CtrPortSet(false);
                    Flag_Init();
                }
                catch(Exception)
                {
                    isOpen = false;
                    MessageBox.Show("无法打开串口或被占用","错误提示");
                }
            }
            else
            {
                try
                {
                    Clossing = true;
                    while (Listening) Application.DoEvents();
                    serialPort.Close();
                    isOpen = false;
                    OpenPort.Text = "打开串口";
                    CtrPortSet(true);                    
                }
                catch(Exception)
                {
                    MessageBox.Show("无法关闭串口", "错误提示");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        public void MyClearData()
        {
            SendDataBlock.Text = "";
            SendDataBlock.Text = "";
        }

        //发送函数
        private void SendData_Click(object sender, EventArgs e)
        {
            if(isOpen)
            {
                try
                {
                    serialPort.WriteLine(SendDataBlock.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("发送数据错误","错误提示");
                    return;
                }
            }
        }

        //接受函数
        public void ReviveData(object sender, SerialDataReceivedEventArgs e)
        {
            if (Clossing == true)
                return;
            //System.Threading.Thread.Sleep(20);
            byte[] ReciveData = new byte[serialPort.BytesToRead];
            //if (ReciveData.Length == 0)
                //return;
            String ReciveText = null;
            this.Invoke((EventHandler)delegate
            {
                try
                {
                    Listening = true;
                    if (!isHex)
                    {
                        serialPort.Read(ReciveData, 0, ReciveData.Length);
                        ReciveDataBlock.Items.Add("[" + GetTimeStamp() + "]" + System.Text.Encoding.Default.GetString(ReciveData));
                    }
                    else
                    {
                        serialPort.Read(ReciveData, 0, ReciveData.Length);
                        for (int i = 0; i < ReciveData.Length - 1; i++)
                        {
                            ReciveText += ("0x" + ReciveData[i].ToString("X2") + " ");
                        }
                        ReciveDataBlock.Items.Add("[" + GetTimeStamp() + "]" + ReciveText);
                        //ReciveText += "\n";
                    }
                }
                catch (Exception ex)
                {
                    ReciveDataBlock.Items.Add(MessageBox.Show($"{0}", ex.Message));
                }
                finally
                {
                    Listening = false;
                    serialPort.DiscardInBuffer(); //丢弃来自字符串缓冲区的数字
                }
            });
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            MyClearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReciveDataBlock.Items.Clear(); ;
        }

        public string GetTimeStamp()
        {
            DateTime t = DateTime.Now;
            return t.ToString("dd/hh:mm:ss:fff");
        }

        public void SetToolTIP()
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            //toolTip1.SetToolTip(this.listBox1, "listBox1");
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.listBox1.SelectedIndices.Count >= 0)
            {
                if (this.listBox1.SelectedIndex >= 0)
                {
                    if (toolTip1.GetToolTip(listBox1) != listBox1.Items[this.listBox1.SelectedIndex].ToString())
                    {
                        this.toolTip1.Active = true;
                        this.toolTip1.SetToolTip(this.listBox1, this.listBox1.Items[this.listBox1.SelectedIndex].ToString());
                    }
                }
            }
            else
            {
                this.toolTip1.Active = false;
            }
        }

        private void ReciveDataBlock_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.ReciveDataBlock.SelectedIndices.Count >= 0)
            {
                if (this.ReciveDataBlock.SelectedIndex >= 0)
                {
                    if (toolTip1.GetToolTip(ReciveDataBlock) != ReciveDataBlock.Items[this.ReciveDataBlock.SelectedIndex].ToString())
                    {
                        this.toolTip1.Active = true;
                        this.toolTip1.SetToolTip(this.ReciveDataBlock, this.ReciveDataBlock.Items[this.ReciveDataBlock.SelectedIndex].ToString());
                    }
                }
            }
            else
            {
                this.toolTip1.Active = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }
    }
}
