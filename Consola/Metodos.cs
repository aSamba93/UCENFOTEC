using Consola.Modelo;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using Newtonsoft.Json;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consola
{
    public class Metodos
    {
        //metodo que obtiene un caracter de un string
        public string caracterString()
        {
            string caracter = "V";
            return caracter;
        }
        //metodo que obtiene un caracter de un char
        public string caracterChar()
        {
            char caracter = 'i';
            return caracter.ToString();
        }
        //metodo que obtiene un caracter de un vector
        public string caracterVector()
        {
            String[] caracter = new String[1];
            caracter[0] = "s";
            return caracter[0];
        }
        //metodo que obtiene un caracter de un array
        public string caracterArray()
        {
            List<String> caracter = new List<string>();
            caracter.Add("u");
            return caracter[0];
        }
        //metodo que obtiene un caracter de un archivo txt
        public string caracterTxt()//a
        {
            TextReader samba = new StreamReader("samba.txt");
            var caracter = samba.ReadLine();
            return caracter;
        }
        //metodo que obtiene un caracter de un Queue
        public string caracterQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("l");
            string caracter = "";
            foreach(var c in queue)
            {
                caracter = c;
            }
            return caracter;
        }
        //metodo que obtiene un caracter de un dictionary
        public string caracterDictionary()
        {
            Dictionary<int, string> caracter = new Dictionary<int, string>();
            caracter.Add(1, " ");            
            return caracter[1];
        }
        //metodo que obtiene un caracter de un input
        public string caracterInput()
        {
            Console.WriteLine("Digite la letra S");
            return Console.ReadLine();
        }
        //metodo que obtiene un caracter de un archivo pdf
        public string caracterPDF()//t
        {
            var pdf = new PdfDocument(new PdfReader("samba.pdf"));
            string text = "";

            for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
            {
                var page = pdf.GetPage(i);
                text = PdfTextExtractor.GetTextFromPage(page)
;
            }

            return text.ToString();
        }
        //metodo que obtiene un caracter de un archivo html
        public string caracterHTML()//u
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader("samba.html"))
            {
                body = reader.ReadToEnd();
            }
            return body;
        }
        //metodo que obtiene un caracter de un archivo XML
        public string caracterXml()//d
        {
            XmlTextReader xmlText = new XmlTextReader("samba.xml");
            XmlDocument doc = new XmlDocument();
            XmlNode node = doc.ReadNode(xmlText);
            string letra = "";
            foreach (XmlNode chldNode in node.ChildNodes)
            {
                if (chldNode.Name == "caracter")
                    letra = chldNode.Attributes["c"].Value.Trim();

            }
            return letra;
        }
        //metodo que obtiene un caracter de un archivo plano
        public string caracterCSV()//i
        {
            string[] lineas = File.ReadAllLines("samba.csv");
            return lineas[0];
        }
        //metodo que obtiene un caracter de un Object
        public string caracterObject()//o
        {
            Texto caracter = new Texto();
            caracter.caracter = 'o';
            return caracter.caracter.ToString();

        }
        //metodo que obtiene un caracter con el codigo ASCII
        public string caracterASCII()//,
        {
            string aux = Convert.ToChar(44).ToString();
            return aux;
        }
        //metodo que obtiene un caracter de un matriz
        public string caracterMatriz()
        {
            string[,] caracter = new string[1,1];
            caracter[0, 0] = " ";
            return caracter[0, 0];
        }
        //metodo que obtiene un caracter de un float
        public string caracterFloat()
        {
            float caracter = 2;
            return caracter.ToString();
        }
        //metodo que obtiene un caracter de un int
        public string caracterInt()
        {
            int caracter = 0;
            return caracter.ToString();
        }
        //metodo que obtiene un caracter de un decimal
        public string caracterDecimal()
        {
            decimal caracter = 2;
            return caracter.ToString();
        }
        //metodo que obtiene un caracter de un archivo json
        public string caracterJson()//2
        {
            Texto texto = new Texto();
            string path = @"samba.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                texto = JsonConvert.DeserializeObject<Texto>(json);
            }
            return texto.caracter.ToString();
        }
        //metodo que obtiene un caracter de mi direccion Ip 
        public string caracterIp()//.
        {            
            String strHostName = string.Empty;
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            string ip = addr[1].ToString();
            char caracter = ip[3];
            return caracter.ToString();      
        }
        
        
    }
}
