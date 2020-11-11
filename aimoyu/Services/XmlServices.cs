using aimoyu.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace aimoyu.Services
{
    public class XmlServices
    {
        public static string SetUpXmlPath = "D:/SetUp.xml";
        public static string HistoryXmlPath = "D:/HistoryBrowsing.xml";

        #region  用户设置
        /// <summary>
        /// 记录用户设置的XML路径
        /// </summary>

        /// <summary>
        /// 判断有无用户设置XML文件
        /// </summary>
        public bool TestingSetUp()
        {
            //根据地址判定有无XML文件
            return System.IO.File.Exists(SetUpXmlPath);
        }
        /// <summary>
        /// 初始化 用户设置XML
        /// </summary>
        public bool InitializationSetUp() {
            if (TestingSetUp())
                return false;
            //创建添加
            XmlDocument xmlDoc = new XmlDocument();
            //加入XML的声明段落 
            XmlNode xmlnode = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmlnode);
            //加入一个根元素 
            XmlElement xmlelem = xmlDoc.CreateElement("SetUp");
            XmlText xmltext = xmlDoc.CreateTextNode("");
            xmlelem.AppendChild(xmltext);
            xmlDoc.AppendChild(xmlelem);
            ////加入一个子元素 
            //XmlElement xmlelem1 = xmlDoc.CreateElement("User");
            //xmltext = xmlDoc.CreateTextNode("");
            //xmlelem1.AppendChild(xmltext);
            //为子元素增加两个属性 
            xmlelem.SetAttribute("Name", "宋体");//字体
            xmlelem.SetAttribute("Size", "14.25");//大小
            xmlelem.SetAttribute("Unit", "Point");//度量单位
            xmlelem.SetAttribute("Bold", "False");//是否粗体
            xmlelem.SetAttribute("GdiCharSet", "134");//语言
            xmlelem.SetAttribute("GdiVerticalFont", "False");//是否垂直
            xmlelem.SetAttribute("Italic", "False");//是否应用斜体
            xmlelem.SetAttribute("Strikeout", "False");//是否贯穿字体横线
            xmlelem.SetAttribute("Underline", "False");//是否有下划线
            xmlelem.SetAttribute("ForeColor", "WindowText");//前景色
            xmlelem.SetAttribute("rowSpacing", "20");//间距
            xmlelem.SetAttribute("BackColor", "F8F8FF ");//背景色
            //xmlDoc.ChildNodes.Item(1).AppendChild(xmlelem);
            xmlDoc.AppendChild(xmlelem);
            xmlDoc.Save(SetUpXmlPath);
            return true;
        }
        /// <summary>
        /// 保存字体样式
        /// </summary>
        /// <returns></returns>
        public void SaveSetUpXml(Font font, Color color) {
            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            SetUp.Attribute("Name").Value = font.Name;
            SetUp.Attribute("Size").Value = font.Size.ToString();
            SetUp.Attribute("Unit").Value = font.Unit.ToString();
            SetUp.Attribute("Bold").Value = font.Bold.ToString();
            SetUp.Attribute("GdiCharSet").Value = font.GdiCharSet.ToString();
            SetUp.Attribute("GdiVerticalFont").Value = font.GdiVerticalFont.ToString();
            SetUp.Attribute("Italic").Value = font.Italic.ToString();
            SetUp.Attribute("Strikeout").Value = font.Strikeout.ToString();
            SetUp.Attribute("Underline").Value = font.Underline.ToString();
            SetUp.Attribute("ForeColor").Value = color.Name;

            xdocument.Save(SetUpXmlPath);
        }

        /// <summary>
        /// 获取字体样式
        /// </summary>
        /// <returns></returns>
        public Font ObtainFont() {
            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            FontStyle style = FontStyle.Regular;
            if (Convert.ToBoolean(SetUp.Attribute("Bold").Value))
                style = FontStyle.Bold;
            if (Convert.ToBoolean(SetUp.Attribute("Italic").Value))
                style = FontStyle.Italic;
            if (Convert.ToBoolean(SetUp.Attribute("Underline").Value))
                style = FontStyle.Underline;
            if (Convert.ToBoolean(SetUp.Attribute("Strikeout").Value))
                style = FontStyle.Strikeout;
            if (Convert.ToBoolean(SetUp.Attribute("Bold").Value))
                style = FontStyle.Bold;
            if (Convert.ToBoolean(SetUp.Attribute("Bold").Value))
                style = FontStyle.Bold;
            float pt = float.Parse(SetUp.Attribute("Size").Value);
            System.Drawing.Font font = new Font(SetUp.Attribute("rowSpacing").Value,
                pt, style, GraphicsUnit.Point);
            return font;
        }
        /// <summary>
        /// 获取前景色
        /// </summary>
        /// <returns></returns>
        public Color ObtainForeColor() {

            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            Color color = Color.FromName(SetUp.Attribute("ForeColor").Value);
            return color;
        }
        /// <summary>
        /// 保存间距
        /// </summary>
        /// <returns></returns>
        public void SaveRowSpacing(int rowSpacing)
        {
            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            SetUp.Attribute("rowSpacing").Value = rowSpacing.ToString();
            xdocument.Save(SetUpXmlPath);
        }
        /// <summary>
        /// 获取间距
        /// </summary>
        /// <returns></returns>
        public int ObtainRowSpacing() {
            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            return Convert.ToInt32(SetUp.Attribute("rowSpacing").Value);
        }
        /// <summary>
        /// 保存背景色
        /// </summary>
        /// <returns></returns>
        public void SaveBackgroundColor(Color color)
        {
            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            SetUp.Attribute("BackColor").Value = color.Name;
            xdocument.Save(SetUpXmlPath);
        }
        /// <summary>
        /// 获取背景色
        /// </summary>
        /// <returns></returns>
        public Color ObtainBackgroundColor()
        {
            DetectInitialize();
            XDocument xdocument = XDocument.Load(SetUpXmlPath); //加载xml文件
            XElement SetUp = xdocument.Element("SetUp");
            Color color = ColorTranslator.FromHtml("#"+SetUp.Attribute("BackColor").Value);
            return color;
        }

        /// <summary>
        /// 如果么有初始化XML则创建
        /// </summary>
        public void DetectInitialize() {
            if (!TestingSetUp())
                InitializationSetUp();
        }
        #endregion

        #region 历史记录

        //获取当前用户所有浏览历史

        public static List<ChapterModel> GetAllChapter()
        {
            if (IsCreate())
            {
                XmlDocument doc = new XmlDocument(); //加载xml文件
                doc.Load(HistoryXmlPath);
                List<ChapterModel> list = new List<ChapterModel>();
                XmlNodeList dt = doc.SelectNodes("/dt/td");
                foreach (XmlNode item in dt)
                {
                    ChapterModel cp = new ChapterModel
                    {
                        Title = item.FirstChild.InnerText,
                        Path = item.FirstChild.NextSibling.InnerText,
                        History = item.FirstChild.NextSibling.NextSibling.InnerText,
                        Historyurl = item.FirstChild.NextSibling.NextSibling.NextSibling.InnerText
                    };
                    list.Add(cp);
                }
                return list;
            }
            else
            {
                return new List<ChapterModel>();
            }
           
        }

        /// <summary>
        /// 新增小说名称及主路径
        /// </summary>
        /// <param name="title">小说名称</param>
        /// <param name="path">小说主路径</param>
        public static void AddHomeDirectory(string title, string path)
        {
            if (!IsCreate())
            {
                //创建添加
                XmlDocument xmlDoc = new XmlDocument();
                //加入XML的声明段落 
                XmlNode xmlnode = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmlDoc.AppendChild(xmlnode);
                //加入一个根元素 
                XmlElement xmlelem = xmlDoc.CreateElement("dt");
                XmlElement xmltd= xmlDoc.CreateElement("td");
                XmlElement xmltitle = xmlDoc.CreateElement("title");
                xmltitle.InnerText = title;
                XmlElement xmlpath = xmlDoc.CreateElement("path");
                xmlpath.InnerText = path;
                XmlElement xmlhistory = xmlDoc.CreateElement("history");
                xmlhistory.InnerText = "";
                XmlElement xmlhistoryurl = xmlDoc.CreateElement("historyurl");
                xmlhistoryurl.InnerText = "";
                xmltd.AppendChild(xmltitle);
                xmltd.AppendChild(xmlpath);
                xmltd.AppendChild(xmlhistory);
                xmltd.AppendChild(xmlhistoryurl);
                xmlelem.AppendChild(xmltd);
                xmlDoc.AppendChild(xmlelem);
                xmlDoc.Save(HistoryXmlPath);
            }
            else
            {
                XmlDocument xdocument = new XmlDocument(); //加载xml文件
                xdocument.Load(HistoryXmlPath);
                XmlNodeList nodtlist = xdocument.SelectNodes("/dt/td/path");
                bool isfind = false;
                foreach (XmlNode item in nodtlist)
                {
                    if (item.LastChild.InnerText== path)
                    {
                        isfind = true;
                    }
                }
                if (!isfind)
                {
                    //加入一个根元素 
                    XmlElement xmltd = xdocument.CreateElement("td");
                    XmlElement xmltitle = xdocument.CreateElement("title");
                    xmltitle.InnerText = title;
                    XmlElement xmlpath = xdocument.CreateElement("path");
                    xmlpath.InnerText = path;
                    XmlElement xmlhistory = xdocument.CreateElement("history");
                    xmlhistory.InnerText = "";
                    XmlElement xmlhistoryurl = xdocument.CreateElement("historyurl");
                    xmlhistoryurl.InnerText = "";
                    xmltd.AppendChild(xmltitle);
                    xmltd.AppendChild(xmlpath);
                    xmltd.AppendChild(xmlhistory);
                    xmltd.AppendChild(xmlhistoryurl);
                    xdocument.DocumentElement.AppendChild(xmltd);
                    xdocument.Save(HistoryXmlPath);
                }

            }
        }

        /// <summary>
        /// 修改小说章节名称及路径
        /// </summary>
        /// <param name="path">小说主路径</param>
        /// <param name="history">章节名称</param>
        /// <param name="historyurl">章节路径</param>
        /// <returns></returns>
        public static void EditViceDirectory(string path, string history,string historyurl)
        {
            if (IsCreate())
            {
                XmlDocument xdocument = new XmlDocument(); //加载xml文件
                xdocument.Load(HistoryXmlPath);
                XmlNodeList nodtlist = xdocument.SelectNodes("/dt/td/path");
                foreach (XmlNode item in nodtlist)
                {
                    if (item.LastChild.InnerText == path)
                    {
                        item.NextSibling.InnerText = history;
                        item.NextSibling.NextSibling.InnerText = historyurl;
                        xdocument.Save(HistoryXmlPath);
                    }
                }
            }
        }

        //是否存在历史记录xml文件

        public static bool IsCreate()
        {
            return System.IO.File.Exists(HistoryXmlPath);
        }


        #endregion
    }
}
