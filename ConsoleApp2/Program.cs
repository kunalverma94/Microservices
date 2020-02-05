using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            //Thread t = new Thread(()=> {
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();
            //    while (true)
            //    {
            //        Console.WriteLine("---------------------------------");
            //        Console.WriteLine("Elapsed ${0}", sw.Elapsed);
            //        Console.WriteLine(GC.GetTotalMemory(true));
            //        Console.WriteLine("---------------------------------");

            //        Thread.Sleep(5000);
            //    }
            //});
            //Console.WriteLine("sending....................");
            //t.Start();
            Console.WriteLine("Elapsed ${0}", sw.Elapsed);
            Console.WriteLine(GC.GetTotalMemory(true));
            string SenderEmail = "kunal94vverma@gmail.com";
            string SenderPassword = "ZEO4141589";
            string RecieverEmail = "kunalverma94@yahoo.com";
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(SenderEmail, SenderPassword),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            try
            {
                Console.WriteLine("Elapsed ${0}", sw.Elapsed);
                Console.WriteLine(GC.GetTotalMemory(true));
                client.Send(new MailMessage(SenderEmail, RecieverEmail, "test", "<h1>mail body</h1>") { IsBodyHtml = true });
                    Console.WriteLine("sent...");
                Console.WriteLine("Elapsed ${0}", sw.Elapsed);
                Console.WriteLine(GC.GetTotalMemory(true));
            }
            catch (Exception E)
            {

                Console.WriteLine(E);
            }
            finally {
                client.Dispose();
                Console.WriteLine("Elapsed ${0}", sw.Elapsed);
                Console.WriteLine(GC.GetTotalMemory(true));

            }

        }
    }
}
