using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aimoyu.Services
{
    public class PublicServices
    {
        /// <summary>
		/// 提示窗体
		/// </summary>
		/// <param name="message">可选参数 提示信息</param>
        /// <param name="interval">可选参数 多长时间关闭</param>
		/// <returns></returns>
		public static void MessageBoxShow(string message="",int interval=0)
        {
            //默认请加载
            if (message == "")
                message = "正在加载,请稍后...";
            if (interval == 0)
                interval = 2000;
            loading formShow = new loading
            {
                lMessage = message,
                interval= interval
            };
            formShow.Show();
        }
    }
}
