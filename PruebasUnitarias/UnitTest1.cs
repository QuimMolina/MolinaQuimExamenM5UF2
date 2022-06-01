using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MolinaQuimExamenM5UF2;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CuantasVocales()
        {
            string msg;
            string prueba = "aáÄeèéëïióöuuauúùü";
            List<int> resultCorrecto = new List<int>();
            List<int> resultadoFinal = new List<int>();

            //He contado las vocales de a frase de prueba, aqui están correctas
                resultCorrecto.Add(4);
                resultCorrecto.Add(4);
                resultCorrecto.Add(2);
                resultCorrecto.Add(2);
                resultCorrecto.Add(6);

            resultadoFinal = ClRecu.QuantesVocals(prueba);
                int i = 0;
            foreach (char c in resultCorrecto)
            {
                msg = "TESTING ---> " + resultCorrecto[i] + " == " + resultadoFinal[i];
                Assert.AreEqual(resultCorrecto[i], resultadoFinal[i]);
                Console.WriteLine(msg);
                i++;
            }


           
        }
        [TestMethod]

        public void PalabrasMasRepetidas()
        {
            string frase1 = "pues la verdad es que me me caes mal";
            string frase2 = "pues no me caes mal";
            string msg;
            int i = 0;
            // me 3 veces, pues 2 veces, caes 2 veces, mal 2 veces

            List<string> resultCorrecto = new List<string>();
            List<string> resultadoFinal = new List<string>();
            resultCorrecto.Add("me");
            resultCorrecto.Add("pues");
            resultCorrecto.Add("caes");
            resultCorrecto.Add("mal");

            resultadoFinal = ClRecu.ParaulesMesRepetides(frase1, frase2);

            foreach (string s in resultCorrecto)
            {
                msg = "TESTING ---> " + resultCorrecto[i] + " == " + resultadoFinal[i];
                Assert.AreEqual(resultCorrecto[i], resultadoFinal[i]);
                Console.WriteLine(msg);
                i++;
            }
        }

        [TestMethod]
        public void Codifica()
        {
            string msg;
            //msg = "TESTING ---> " + "HOLA/072079076065" + " == " + ClRecu.elMeuEncode("HOLA", 3);
            msg = "TESTING ---> " + "HOLA/00072000790007600065" + " == " + ClRecu.elMeuEncode("HOLA", 5);
            Console.WriteLine(msg);
            Assert.ReferenceEquals("00072000790007600065", ClRecu.elMeuEncode("HOLA", 5));
        }
        [TestMethod]
        public void DeCodifica()
        {
            string msg;
            //msg = "TESTING ---> " + "HOLA/072079076065" + " == " + ClRecu.elMeuEncode("HOLA", 3);
            msg = "TESTING ---> " + "HOLA/00072000790007600065" + " == " + ClRecu.elMeuDecode("00072000790007600065", 5);
            Console.WriteLine(msg);
            Assert.ReferenceEquals("00072000790007600065", ClRecu.elMeuDecode("00072000790007600065", 5));
        }
    }
}
