using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aimoyu.Services
{
    public class ThreadServices
    {

        //声明一个delegate（委托）类型：TestDelegate，该类型可以搭载返回值为空，参数只有一个的方法。 
        public delegate void WebDataDelegate(string i);
        //无参数委托
        public delegate void WebDataDelegate2();

        //声明一个TestDelegate类型的对象。该对象代表了返回值为空，参数只有一个的方法。它可以搭载N个方法。 
        public WebDataDelegate mainThread;
        public WebDataDelegate2 mainThread2;

        /// <summary>
        /// 查询一次结束
        /// </summary>
        private bool deleBool = false;
        private bool deleBool2 = false;
        //一个参数的查询方法
        public void QueryData(string i="")
        {
            while (!deleBool)
            {
                mainThread(i); //调用委托对象 
                Thread.Sleep(200);  //线程等待1000毫秒 
                deleBool = true;
            }
        }
        public void QueryData()
        {
            while (!deleBool2)
            {
                mainThread2(); //调用委托对象 
                Thread.Sleep(200);  //线程等待1000毫秒 
                deleBool2 = true;
            }
        }
    }
}
