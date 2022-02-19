using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            Console.WriteLine(""+
            metodos.caracterString()    +""+
            metodos.caracterChar()      +""+
            metodos.caracterVector()    +""+
            metodos.caracterArray()     +""+
            metodos.caracterTxt()       +""+
            metodos.caracterQueue()     +""+
            metodos.caracterDictionary()+""+
            metodos.caracterInput()     +""+
            metodos.caracterPDF()       +""+
            metodos.caracterHTML()      +""+ 
            metodos.caracterXml()       +""+
            metodos.caracterCSV()       +""+
            metodos.caracterObject()    +""+
            metodos.caracterASCII()     +""+
            metodos.caracterMatriz()    +""+
            metodos.caracterFloat()     +""+
            metodos.caracterInt()       +""+
            metodos.caracterDecimal()   +""+
            metodos.caracterJson()      +""+
            metodos.caracterIp()        
            );
        }
    }
}
