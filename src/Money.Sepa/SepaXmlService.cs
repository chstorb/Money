using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Money.Sepa
{
    using System.Runtime.InteropServices;

    [Guid("60AC1327-3C34-4323-9CFA-7A900C655DEC"),
        ComVisible(true)]
    public interface ISepaXmlService
    {
        void WriteCreditTransferToFile(string fileName, Money.Sepa.CreditTransfer.Document doc);
        void ReadCreditTransferFromFile(string fileName, Money.Sepa.CreditTransfer.Document doc);

        void WriteDirectDebitToFile(string fileName, Money.Sepa.DirectDebit.Document doc);
        void ReadDirectDebitFromFile(string fileName, Money.Sepa.DirectDebit.Document doc);

        void WriteStatusReportToFile(string fileName, Money.Sepa.StatusReport.Document doc);
        void ReadStatusReportFromFile(string fileName, Money.Sepa.StatusReport.Document doc);
    }

    [Guid("D71ED5B6-2788-4AA9-89FE-395BD5655E50"),
        ComVisible(true),
        ClassInterface(ClassInterfaceType.None)]
    public partial class SepaXmlService : ISepaXmlService
    {
        public SepaXmlService()
        { 
        }

        public void WriteCreditTransferToFile(string fileName, Money.Sepa.CreditTransfer.Document doc)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Money.Sepa.CreditTransfer.Document));
            FileStream fs = new FileStream(fileName, FileMode.Create);
            XmlWriter writer = new XmlTextWriter(fs, Encoding.UTF8);
            serializer.Serialize(writer, doc);
            fs.Close();
        }

        public void ReadCreditTransferFromFile(string fileName, Money.Sepa.CreditTransfer.Document doc)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Money.Sepa.CreditTransfer.Document));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            doc = (Money.Sepa.CreditTransfer.Document)serializer.Deserialize(fs);
            fs.Close();
        }

        public void WriteDirectDebitToFile(string fileName, Money.Sepa.DirectDebit.Document doc)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Money.Sepa.DirectDebit.Document));
            FileStream fs = new FileStream(fileName, FileMode.Create);
            XmlWriter writer = new XmlTextWriter(fs, Encoding.UTF8);
            serializer.Serialize(writer, doc);
            fs.Close();
        }

        public void ReadDirectDebitFromFile(string fileName, Money.Sepa.DirectDebit.Document doc)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Money.Sepa.DirectDebit.Document));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            doc = (Money.Sepa.DirectDebit.Document)serializer.Deserialize(fs);
            fs.Close();
        }

        public void WriteStatusReportToFile(string fileName, Money.Sepa.StatusReport.Document doc)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Money.Sepa.StatusReport.Document));
            FileStream fs = new FileStream(fileName, FileMode.Create);
            XmlWriter writer = new XmlTextWriter(fs, Encoding.UTF8);
            serializer.Serialize(writer, doc);
            fs.Close();
        }

        public void ReadStatusReportFromFile(string fileName, Money.Sepa.StatusReport.Document doc)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Money.Sepa.StatusReport.Document));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            doc = (Money.Sepa.StatusReport.Document)serializer.Deserialize(fs);
            fs.Close();
        }
    }
} 
