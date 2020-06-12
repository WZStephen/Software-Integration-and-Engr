using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace Messaging
{
    public class Service1 : IService1
    {
        string cache = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data\msg.xml");
        public void sendMsg(string senderID, string receiverID, string msg)
        {
            XDocument xmlDocMsgs = new XDocument();
            XNamespace nameSpace = "http://localhost:53750/Service1.svc";
            try
            {
                xmlDocMsgs = XDocument.Load(cache);
                XElement xmlElement = new XElement(nameSpace + "Message",
                    new XElement(nameSpace + "SenderID", senderID),
                    new XElement(nameSpace + "ReceiverID", receiverID),
                    new XElement(nameSpace + "TimeStamp", System.DateTime.Now.ToString()),
                    new XElement(nameSpace + "MessageContents", msg),
                    new XElement(nameSpace + "Read", "false"));

                xmlDocMsgs.Element(nameSpace + "Messages").Add(xmlElement);
                xmlDocMsgs.Save(cache);
            }
            catch (XmlException ex)
            {
                if (!(ex.Message.ToLower().Contains("root") && ex.Message.ToLower().Contains("element") && ex.Message.ToLower().Contains("not") && ex.Message.ToLower().Contains("found")))
                {
                    xmlDocMsgs = new XDocument(
                               new XDeclaration("1.0", "UTF-8", "yes"),
                               new XComment("CSE446 Messaging System Example"),
                               new XElement(nameSpace + "Messages",
                               new XElement(nameSpace + "Message",
                               new XElement(nameSpace + "SenderID", senderID),
                               new XElement(nameSpace + "ReceiverID", receiverID),
                               new XElement(nameSpace + "TimeStamp", System.DateTime.Now.ToString()),
                               new XElement(nameSpace + "MessageContents", msg),
                               new XElement(nameSpace + "Read", "false"))));
                    xmlDocMsgs.Save(cache);
                }
            }
        }

        public string[] receiveMsg(string receiverID, bool purge)
        {
            int index = 0;

            string[] returnMsg;
            XDocument xmlDocMsgs = XDocument.Load(cache);
            XNamespace nameSpace = "http://localhost:53750/Service1.svc";

            IEnumerable<XElement> element = from item in xmlDocMsgs.Root.Descendants(nameSpace + "Message")
            where item.Element(nameSpace + "ReceiverID").Value == receiverID && item.Element(nameSpace + "Read").Value.Equals("false")
            orderby (DateTime)item.Element(nameSpace + "TimeStamp") 
            descending select item;

            returnMsg = new string[element.Count() * 3];
            foreach (XElement item in element)
            {
                returnMsg[index++] = item.Element(nameSpace + "SenderID").Value;
                returnMsg[index++] = item.Element(nameSpace + "TimeStamp").Value;
                returnMsg[index++] = item.Element(nameSpace + "MessageContents").Value;
                item.Element(nameSpace + "Read").Value = "true";
            }

            if (purge == true)
            {
                foreach (XElement item in element)
                {
                    item.Remove();
                    xmlDocMsgs.Save(cache);
                }
            }
            xmlDocMsgs.Save(cache);
            foreach (XElement item in element)
            {
                item.Element(nameSpace + "Read").Value = "true";
            }
            return returnMsg;
        }
    }
}
