using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;
using System.Net;
using System.IO;

namespace Money.Unifi.Tests
{
    [TestClass]
    public class SepaCreditTransferTests
    {
        [TestMethod]
        public void DeserializePaymentInstructionInformations()
        {
            Uri uri = new Uri("http://www.ebics.de/fileadmin/unsecured/anlage3/anlage3_pain001/pain_ex/pain.001.003.03.xml");

            XmlSerializerFactory factory = new XmlSerializerFactory();
            XmlSerializer ser = factory.CreateSerializer(typeof(Money.Unifi.pain_001_003_03.Document));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            Money.Unifi.pain_001_003_03.Document doc = (Money.Unifi.pain_001_003_03.Document)ser.Deserialize(responseStream);
            responseStream.Close();

            Assert.IsNotNull(doc);
            Assert.AreEqual("Message-ID-4711", doc.CstmrCdtTrfInitn.GrpHdr.MsgId);

            Console.WriteLine("MsgId = {0}, InitgPty.Nm = {1}", doc.CstmrCdtTrfInitn.GrpHdr.MsgId, doc.CstmrCdtTrfInitn.GrpHdr.InitgPty.Nm);

            foreach (Money.Unifi.pain_001_003_03.PaymentInstructionInformationSCT entry in doc.CstmrCdtTrfInitn.PmtInf)
            {
                Console.WriteLine("CtrlSum = {0}, NbOfTxs = {1}", entry.CtrlSum, entry.NbOfTxs);
            }
        }
    }
}
