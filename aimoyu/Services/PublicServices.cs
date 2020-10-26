using aimoyu.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aimoyu.Services
{
    public class PublicServices
    {
        /// <summary>
		/// 提示窗体
		/// </summary>
        /// <param name="point">当前窗体坐标</param>
		/// <param name="message">可选参数 提示信息</param>
        /// <param name="interval">可选参数 多长时间关闭</param>
		/// <returns></returns>
		public static void MessageBoxShow(Point point, string message = "", int interval = 0)
        {
            //默认请加载
            if (message == "")
                message = "正在加载,请稍后...";
            if (interval == 0)
                interval = 700;
            loading formShow = new loading
            {
                lMessage = message,
                interval = interval,
                messagePoint = point
            };
            formShow.Show();
        }
    }
}
