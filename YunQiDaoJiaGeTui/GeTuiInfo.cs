using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunQiDaoJiaGeTui
{

    public class GeTuiInfo
    {
        public String corpCode;//企业编号
        public String userCode; //用户名
        public int checkVersion = 0; //是否检测app升级
        public int checkUpgrade = 0; //是否检查更新补丁
        public int isDebug = 0;//是否开启调试模式
        public int logLevel = 0;//日志输出级别1-5
        public int writeLog = 0;//日志是否写到文件中
        public int uploadLogFile = 0;//是否上传日志文件
        public int updatePermissions = 0;//是否同步权限
        public int clearACache = 0;//是否清空ACache缓存
    }
        /*
        public string CorpCode
        {
            get
            {
                return corpCode;
            }

            set
            {
                corpCode = value;
            }
        }

        public string UserCode
        {
            get
            {
                return userCode;
            }

            set
            {
                userCode = value;
            }
        }

        public int CheckVersion
        {
            get
            {
                return checkVersion;
            }

            set
            {
                checkVersion = value;
            }
        }

        public int CheckUpgrade
        {
            get
            {
                return checkUpgrade;
            }

            set
            {
                checkUpgrade = value;
            }
        }

        public int IsDebug
        {
            get
            {
                return isDebug;
            }

            set
            {
                isDebug = value;
            }
        }

        public int LogLevel
        {
            get
            {
                return logLevel;
            }

            set
            {
                logLevel = value;
            }
        }

        public int WriteLog
        {
            get
            {
                return writeLog;
            }

            set
            {
                writeLog = value;
            }
        }

        public int UploadLogFile
        {
            get
            {
                return uploadLogFile;
            }

            set
            {
                uploadLogFile = value;
            }
        }

        public int UpdatePermissions
        {
            get
            {
                return updatePermissions;
            }

            set
            {
                updatePermissions = value;
            }
        }

        public int ClearACache
        {
            get
            {
                return clearACache;
            }

            set
            {
                clearACache = value;
            }
        }
    }
    */
}
