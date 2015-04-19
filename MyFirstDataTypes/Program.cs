using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new System.Net.WebException();
                throw new System.IO.FileNotFoundException();
                throw new OutOfMemoryException();
            }
            catch (System.Net.WebException webex)
            {
                Console.WriteLine("We cannot retrieve the request web resource");
            }
            catch (System.IO.FileNotFoundException fileEx)
            {
                Console.WriteLine("We cannot fid the file needed to save the Document");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot Error");
            }
            finally
            {
                Console.WriteLine("We're in the finally block");
            }
        }
    }
}





