using Microsoft.VisualStudio.TestTools.UnitTesting;
using unittest_ika;
// Tekij�: Heikki Luukkonen
namespace Ikatestit.Tests
{
    [TestClass]
    public class testit
    {
        ikatsek ikatsek = new ikatsek();
        [TestMethod]
        public void OletLapsi()
        {
            //arrange
            string ika = "13";
            string oletus = "Olet lapsi";
            //act
            string tulos = ikatsek.Aloitus(ika);
            //assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void OletAikuinen()
        {
            //arrange
            string ika = "18";
            string oletus = "Olet aikuinen";
            //act
            string tulos = ikatsek.Aloitus(ika);
            //assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void OletElakelainen()
        {
            //arrange
            string ika = "72";
            string oletus = "Olet el�kel�inen";
            //act
            string tulos = ikatsek.Aloitus(ika);
            //assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void NegatiivinenLuku()
        {
            //arrange
            string ika = "-19";
            string oletus = "Sy�tetty arvo oli virheellinen.";
            //act
            string tulos = ikatsek.Aloitus(ika);
            //assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void DesimaaliSyote()
        {
            //arrange
            string ika = "1.2";
            string oletus = "Virheellinen sy�te, sy�tteen tulee sis�lt�� vain numeroita.";
            //act
            string tulos = ikatsek.Aloitus(ika);
            //assert
            Assert.AreEqual(oletus, tulos);
        }
        [TestMethod]
        public void KirjainSyote()
        {
            //arrange
            string ika = "Kuuskytkaks";
            string oletus = "Virheellinen sy�te, sy�tteen tulee sis�lt�� vain numeroita.";
            //act
            string tulos = ikatsek.Aloitus(ika);
            //assert
            Assert.AreEqual(oletus, tulos);
        }
    }
}