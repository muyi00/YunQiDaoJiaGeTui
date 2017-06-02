using com.igetui.api.openservice;
using com.igetui.api.openservice.igetui;
using com.igetui.api.openservice.igetui.template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunQiDaoJiaGeTui
{
    public class GeTuiUtils
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

        private string pushJson = "";


        public void setPushData(string pushJson)
        {
            this.pushJson = pushJson;
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
        public string pushMessage()
        {
            AppMessage appMessage = getAppMessage();
            IGtPush push = new IGtPush(HOST, APPKEY, MASTERSECRET);
            return push.pushMessageToApp(appMessage);

        }


    }
}
