using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace DBhelp
{
    public class XMLDBhelp
    {
        /// <summary>
        /// XML文档对象
        /// </summary>
        public XmlDocument Xml { get; private set; }
        /// <summary>
        /// XML本地路径
        /// </summary>
        public string XmlPath { get; private set; }

        /// <summary>
        /// 实例化一个XML操作对象
        /// </summary>
        public XMLDBhelp()
        {
            this.Xml = new XmlDocument();
        }

        /// <summary>
        /// 载入一个XML文件
        /// </summary>
        /// <param name="path">Xml的Web路径</param>
        public void Load(string path)
        {
            if (!System.IO.File.Exists(path))
                throw new System.IO.FileNotFoundException("XML文件路径不能存在");
            this.XmlPath = path;
            this.Xml.Load(this.XmlPath);
        }

        /// <summary>
        /// 添加XML指令
        /// </summary>
        /// <param name="version">版本</param>
        /// <param name="encoding">编码</param>
        /// <param name="standalone">是否是独立文档，如果独立则不能引用外部DTD规范文件, 参考值(“YES”、“NO”)</param>
        public void CreateDeclaration(string version, string encoding, string standalone = null)
        {
            XmlDeclaration xd = this.Xml.CreateXmlDeclaration(version, encoding, standalone);
            if (!this.Xml.HasChildNodes)
                this.Xml.AppendChild(xd);
            else
                this.Xml.InsertBefore(this.Xml.FirstChild, xd);
        }

        /// <summary>
        /// 创建一个节点元素
        /// </summary>
        /// <param name="name">节点名称</param>
        /// <param name="innerText">节点的值，如果NULL则不产生闭合标签</param>
        /// <returns>返回：创建的节点元素对象</returns>
        public XmlElement Create(string name, string innerText = null)
        {
            XmlElement element = this.Xml.CreateElement(name);
            if (innerText != null)
                element.InnerText = innerText;
            return element;
        }

        /// <summary>
        /// 往指定的XPath中添加一个节点对象
        /// </summary>
        /// <param name="xpath">XPath 表达式</param>
        /// <param name="elem">节点元素对象</param>
        /// <param name="index">在指定的节点中添加元素，从0开始计数。注意：-1表示在所有元素中添加元素节点</param>
        /// <returns>收影响的XmlNode对象列表</returns>
        public List<XmlNode> Add(string xpath, XmlElement elem, int index = -1)
        {
            List<XmlNode> list = new List<XmlNode>();
            XmlNodeList nodes = Xml.SelectNodes(xpath);//.SelectSingleNode(xpath);
            if (nodes.Count > 0)
            {
                if (index <= -1)
                {
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        list.Add(nodes[i].AppendChild(elem));
                    }
                }
                else
                {
                    list.Add(nodes.Item(index).AppendChild(elem));
                    //if (nodes.Count < index + 1)
                    //    throw new ArgumentException("节点索引index超出了索引范围");
                    //else
                    //    list.Add(nodes[index].AppendChild(elem));
                }
            }
            return list;
        }

        /// <summary>
        /// 修改指定的XPath节点，如果该XPath具有多个节点也会全部替换。
        /// </summary>
        /// <param name="xpath">待修改的XPath 表达式</param>
        /// <param name="newNode">新的XmlNode对象</param>
        public void Update(string xpath, XmlNode newNode)
        {
            XmlNodeList nodeList = Xml.SelectNodes(xpath);
            foreach (XmlNode oldNode in nodeList)
            {
                ReplaceChild(oldNode, newNode);
            }
        }

        /// <summary>
        /// 替换指定的节点
        /// </summary>
        /// <param name="oldNode">旧节点</param>
        /// <param name="newNode">新节点</param>
        public void ReplaceChild(XmlNode oldNode, XmlNode newNode)
        {
            Xml.ReplaceChild(newNode, oldNode);
        }

        /// <summary>
        /// 删除XPath表达式的所有节点。
        /// </summary>
        /// <param name="xpath">XPath 表达式</param>
        public void Delete(string xpath)
        {
            XmlNodeList nodes = Xml.SelectNodes(xpath);
            Xml.RemoveAll();
        }

        /// <summary>
        /// 删除单个节点
        /// </summary>
        /// <param name="node">待删除的节点</param>
        public void Delete(XmlNode node)
        {
            Xml.RemoveChild(node);
        }

        /// <summary>
        /// 保存所有操作
        /// </summary>
        public void Save()
        {
            if (string.IsNullOrEmpty(this.XmlPath))
                throw new ArgumentNullException("文件保存路径不存在，请为XmlPath属性提供值。");
            Xml.Save(this.XmlPath);
        }

        /// <summary>
        /// 保存所有操作到指定的XML文件路径
        /// </summary>
        /// <param name="path">文件路径</param>
        public void Save(string path)
        {
            this.XmlPath = path;
            this.Save();
        }

        /// <summary>
        /// 异步保存所有操作
        /// </summary>
        /// <returns></returns>
        //public async Task AsyncSave()
        //{
        //    await Task.Factory.StartNew((args) =>
        //    {
        //        object[] argArr = (object[])args;
        //        ((XmlDocument)argArr[0]).Save(argArr[1].ToString());
        //    }, new object[] { Xml, this.XmlPath });
        //}

        /// <summary>
        /// 根据XPath表达式获取第一个节点对象
        /// </summary>
        /// <param name="xpath">Xpath 表达式</param>
        /// <returns>返回：NULL / 查询到的第一个XmlNode对象</returns>
        public XmlNode GetNode(string xpath)
        {
            return Xml.SelectSingleNode(xpath);
        }

        /// <summary>
        /// 根据XPath表达式获取节点列表
        /// </summary>
        /// <param name="xpath">XPath 表达式</param>
        /// <returns>返回：节点集合</returns>
        public XmlNodeList GetNodes(string xpath)
        {
            return Xml.SelectNodes(xpath);
        }

        /// <summary>
        /// 判断指定XPath表达式在XML文档中是否存在
        /// </summary>
        /// <param name="xpath">XPath表达式</param>
        /// <returns>返回：True/False</returns>
        public bool HasXpathElement(string xpath)
        {
            if (GetNode(xpath) != null)
                return true;
            else
                return false;
        }

    }
}
