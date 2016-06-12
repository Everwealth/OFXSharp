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
        }

        [TestMethod]
        public void CanParserSantander()
        {
            var parser = new OFXDocumentParser();
            var ofxDocument = parser.Import(new FileStream(@"santander.ofx", FileMode.Open));
        }
    }
}
