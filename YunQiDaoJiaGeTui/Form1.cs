
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
        
        //参数设置 <-----参数需要重新设置----->
        //http的域名
        private static String HOST = "http://sdk.open.api.igexin.com/apiex.htm";
        //https的域名
        //private static String HOST = "https://api.getui.com/apiex.htm";
        //定义常量, appId、appKey、masterSecret 采用本文档 "第二步 获取访问凭证 "中获得的应用配置
        private static String APPID = "D2tbkSh0WTAyZuKZGXYH55";
        private static String APPKEY = "5dsvptzfnm5kaB5m4T7ic2";
        private static String MASTERSECRET = "MTTZyvsibm85i7bmzOCIc2";
        private String pushJson = "";

        //执行完成
        private delegate void fulfilDelegate();
        //执行中的提示
        private delegate void hintDelegate();

        public Form1()
        {
            InitializeComponent();
           

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
            if (pushJson.Length == 0)
            {
                msg_lbox.Items.Add("推送推送内容不能为空");
                return;
            }

            msg_lbox.Items.Clear();




           // push_btn.Enabled = false;
           // _GeTuiDelegate = new GeTuiDelegate(pushMessage);
           // IAsyncResult result = _GeTuiDelegate.BeginInvoke(pushJson, new AsyncCallback(GeTuiCallBack), null);
            //msg_lbox.Items.Add(_GeTuiDelegate.EndInvoke(result));//用于接收返回值 
            //push_btn.Enabled = true;

            Thread th = new Thread(new ThreadStart(pushMessage));
            th.Start();
        }

        private void GeTuiCallBack(IAsyncResult iasync)
        {
           // AsyncResult async = (AsyncResult)iasync;
           // GeTuiDelegate del = (GeTuiDelegate)async.AsyncDelegate;
           // Console.WriteLine("回调"+del.EndInvoke(iasync));
        }

        /// <summary>
        /// 推送内容
        /// </summary>
        /// <returns></returns>
        private AppMessage getAppMessage()
        {
            // 定义"AppMessage"类型消息对象，设置消息内容模板、发送的目标App列表、是否支持离线发送、以及离线消息有效期(单位毫秒)
            AppMessage message = new AppMessage();
            message.IsOffline = true;                         // 用户当前不在线时，是否离线存储,可选
            message.OfflineExpireTime = 1000 * 3600 * 12;     // 离线有效时间，单位为毫秒，可选
            message.Data = getTransmissionTemplate(pushJson);
            //判断是否客户端是否wifi环境下推送，2:4G/3G/2G,1为在WIFI环境下，0为无限制环境
            //message.PushNetWorkType = 0; 
            //message.Speed = 1000;

            List<String> appIdList = new List<String>();
            appIdList.Add(APPID);

            List<String> phoneTypeList = new List<String>();   //通知接收者的手机操作系统类型
            phoneTypeList.Add("ANDROID");


            List<String> provinceList = new List<String>();    //通知接收者所在省份
            //provinceList.Add("浙江");
            //provinceList.Add("上海");
            //provinceList.Add("北京");

            List<String> tagList = new List<string>();
            //tagList.Add("中文");

            message.AppIdList = appIdList;
            //message.PhoneTypeList = phoneTypeList;
            //message.ProvinceList = provinceList;
            //message.TagList = tagList;
            return message;
        }


        /// <summary>
        /// 透传模板动作内容
        /// </summary>
        /// <param name="pushJson">透传内容</param>
        /// <returns></returns>
        public TransmissionTemplate getTransmissionTemplate(String pushJson)
        {
            TransmissionTemplate template = new TransmissionTemplate();
            template.AppId = APPID;
            template.AppKey = APPKEY;
            template.TransmissionType = "1";          //应用启动类型，1：强制应用启动 2：等待应用启动
            template.TransmissionContent = pushJson;  //透传内容
            //设置客户端展示时间
            DateTime dt1 = DateTime.Now;
            String begin = dt1.ToString();
            DateTime dt2 = DateTime.Now;
            dt2.AddHours(2);
            String end = dt2.ToString();
            template.setDuration(begin, end);
            return template;
        }


        /// <summary>
        /// 推送消息
        /// </summary>
        /// <returns></returns>
        private void  pushMessage()
        {
            AppMessage appMessage = getAppMessage();
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            String str= push.pushMessageToApp(appMessage);
        }




    }
}
