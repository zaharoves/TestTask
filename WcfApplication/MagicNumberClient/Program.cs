using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicNumberClient.MagicNumberService;


namespace MagicNumberClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicNumberService.MagicNumberServiceClient client = new MagicNumberServiceClient();
            Console.WriteLine(client.MagicNumber());
            Console.ReadLine();
        }
    }
}
