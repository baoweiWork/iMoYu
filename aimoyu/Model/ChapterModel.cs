using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aimoyu.Model
{
    public class ChapterModel
    {
        /// <summary>
        /// 小说名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 小说主路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 章节名称
        /// </summary>
        public string History { get; set; }
        /// <summary>
        /// 章节路径
        /// </summary>
        public string Historyurl { get; set; }
    }
}
