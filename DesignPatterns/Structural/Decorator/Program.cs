// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

/*
 *       Kahve
 *       Latte: Üzerine süt eklenmiş kahve
 *       Ekstra şeker
 * 
 *  
 */

FileStream fileStream = null;
MemoryStream stream = null;
NetworkStream networkStream = null;


//GZipStream gZipStream = new GZipStream(fileStream, CompressionMode.Compress);
//CryptoStream cryptoStream = new CryptoStream(gZipStream, null, CryptoStreamMode.Write);

/*
 *   Bellekte hali hazırda varolan bir nesneye yepyeni özellik (feature) kazandırmak için Decorator kullanılabilir.
 */


PromotionMail promotionMail = new PromotionMail();
SignedMail signedMail = new SignedMail(promotionMail, "Türkay Ürkmez");
signedMail.Send();

CryptedEmail cryptedEmail = new CryptedEmail(signedMail);
cryptedEmail.CryptoMailBody();
cryptedEmail.Send();