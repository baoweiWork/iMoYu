using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace aimoyu
{
    public class XmlHelper
    {

        //------------【函数：为节点node创建新的子节点node】------------

        //filePath为Excel文件路径名
        //nodeName节点名称
        //nodeID节点属性名称
        //nodeIDValue节点属性值
        //nodeText节点内容
        //FatherNode父节点
        //------------------------------------------------------------------------
        public static bool AppendNodeToNode(string filePath, string nodeName, string nodeID, string nodeIDValue, string nodeText, string FatherNode)
        {
            bool result = true;
            try
            {
                //判断文件是否存在
                if (File.Exists(filePath) && nodeName != "" && FatherNode != "")
                {
                    XmlDocument xmlDoc = new XmlDocument();//新建XML文件
                    xmlDoc.Load(filePath);//加载XML文件

                    XmlElement xm = xmlDoc.CreateElement(nodeName);
                    xm.SetAttribute(nodeID, nodeIDValue);
                    xm.InnerText = nodeText;

                    XmlNode root = xmlDoc.GetElementsByTagName(FatherNode)[0];
                    root.AppendChild(xm);

                    xmlDoc.Save(filePath);

                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }


    }
}
