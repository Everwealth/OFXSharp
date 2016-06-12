using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFXSharp.Tests
{
    [TestClass]
    public class CanParser
    {
        [TestMethod]
        public void CanParserItau()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(new FileStream(@"itau.ofx", FileMode.Open));
            Assert.AreEqual(3, ofxDocument.Transactions.Count);
            Assert.AreEqual(-666.66M, ofxDocument.Transactions.First().Amount);
        }

        [TestMethod]
        public void CanParserSantander()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(new FileStream(@"santander.ofx", FileMode.Open));

            Assert.IsTrue(ofxDocument.Transactions.Count > 0);

        }


        [TestMethod]
        public void CanParserANZ()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(new FileStream(@"ANZ.ofx", FileMode.Open));

            Assert.IsTrue(ofxDocument.Transactions.Count > 0);
        }

        [TestMethod]
        public void CanParserSample1()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(new FileStream(@"Sample1.ofx", FileMode.Open));

            Assert.IsTrue(ofxDocument.Transactions.Count > 0);
        }

        [TestMethod]
        public void CanParserSample2()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(new FileStream(@"Sample2.ofx", FileMode.Open));

            Assert.IsTrue(ofxDocument.Transactions.Count > 0);
        }
    }
}
