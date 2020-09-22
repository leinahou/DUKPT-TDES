using System;
using System.Text;
using DUKPTCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string bdk = "0123456789ABCDEFFEDCBA9876543210";
            string ksn = "629949012C0000000003";
            byte[] superSecretMessage = Encoding.UTF8.GetBytes("1234");
            byte[] encryptedData = DUKPT.Encrypt(bdk, ksn, superSecretMessage, DUKPTVariant.PIN);
            String hexres = BitConverter.ToString(encryptedData);
            hexres = hexres.Replace("-", "");
            Console.WriteLine("Encrypted Data: " + hexres);

            byte[] decryptedData = DUKPT.Decrypt(bdk, ksn, encryptedData, DUKPTVariant.PIN);
            string superSecretMessage1 = Encoding.UTF8.GetString(decryptedData);
            Console.WriteLine("Decrypted Data: " + superSecretMessage1);
        }
    }
}
