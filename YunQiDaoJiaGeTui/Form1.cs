
using com.igetui.api.openservice;
using com.igetui.api.openservice.igetui;
using com.igetui.api.openservice.igetui.template;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunQiDaoJiaGeTui
{
    public partial class Form1 : Form
    {

        private GeTuiUtils getui;
        private String pushJson = "";

        public delegate string PushMessageDelegate();
        public delegate void SetTextCallBack(string str);



        private PushMessageDelegate pushMessageDelegate;



        public Form1()
        {
            InitializeComponent();
            getui = new GeTuiUtils();
            


        }

        

        private void toJson_btn_Click(object sender, EventArgs e)
        {
            json_tbox.Text = "";
            pushJson = "";

            int logLevel = 0;
            try
            {
                logLevel = Convert.ToInt32(logLevel_tbox.Text);
                if (logLevel>5)
                {
                    logLevel = 5;
                }
                else if (logLevel<0)
                {
                    logLevel = 0;
                }
            }
            catch (Exception)
            {
                logLevel = 0;
            }

            GeTuiInfo info = new GeTuiInfo();
            info.corpCode = corpCode_tbox.Text;
            info.userCode = userCode_tbox.Text;
            info.checkVersion = checkVersion_cb.Checked == true ? 1 : 0;
            info.checkUpgrade = checkUpgrade_cb.Checked == true ? 1 : 0;
            info.isDebug = isDebug_cb.Checked == true ? 1 : 0;
            info.logLevel = logLevel;
            info.writeLog = writeLog_cb.Checked == true ? 1 : 0;
            info.uploadLogFile = uploadLogFile_cb.Checked == true ? 1 : 0;
            info.updatePermissions = updatePermissions_cb.Checked == true ? 1 : 0;
            info.clearACache = clearACache_cb.Checked == true ? 1 : 0;

            pushJson = JsonConvert.SerializeObject(info);
            json_tbox.Text= pushJson;
            
        }


        private void push_btn_Click(object sender, EventArgs e)
        {
            msg_lbox.Items.Clear();
            if (pushJson.Length == 0)
            {
                msg_lbox.Items.Add("推送推送内容不能为空");
                return;
            }
            push_btn.Enabled = false;
            getui.setPushData(pushJson);
            pushMessageDelegate = new PushMessageDelegate(getui.pushMessage);
            pushMessageDelegate.BeginInvoke(new AsyncCallback(pushFulfilCallback), null);

        }

        private void pushFulfilCallback(IAsyncResult ar)
        {
            if (ar == null)
            {
                return;
            }

            String str = pushMessageDelegate.EndInvoke(ar);
            Console.WriteLine(str);
            ssetText(str);

        }

        private void ssetText(string str)
        {
            if (this.msg_lbox.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(ssetText);
                this.Invoke(stcb, new object[] { str });
            }
            else
            {
                this.msg_lbox.Items.Add(str);
                push_btn.Enabled = true;
            }
        }


    }
}
