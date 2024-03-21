// See https://aka.ms/new-console-template for more information
using Singleton;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//Singleton: Sadece bir adet (tekil) olan nesne
MailConfigurator mailConfigurator = MailConfigurator.Create();
mailConfigurator.Host = "gmail.com";

Console.WriteLine();

MailConfigurator mailConfigurator1 = MailConfigurator.Create();
Console.WriteLine(mailConfigurator1.Host);
mailConfigurator1.Host = "outlook.com";
Console.WriteLine(mailConfigurator.Host);

MailConfigurator.Create().Host = "yahoo.com";

Console.WriteLine($"Şu an oluşturulan nesnenin host değeri:  {MailConfigurator.Create().Host}");

SqlDataAdapter dataAdapter = new SqlDataAdapter();
DataTable dataTable = new DataTable();
dataAdapter.Fill(dataTable);