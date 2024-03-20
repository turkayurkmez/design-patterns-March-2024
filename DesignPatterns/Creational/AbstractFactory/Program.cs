// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
/*
 *  Belirli bir seçime (ya da duruma) bağlı olarak gerekecek nesnelerin belli olduğu bir durum düşünün. 
 *  Örneğin, Ms SQL Server ya da Oracle gibi iki ayrı paltformdan biriyle çalışacak bir uygulama düşünelim.
 *    Oracle -> OracleCommand, OracleConnection, OracleDataAdapter
 *    SQL    -> SQLCommand, SQLConnection, SQLDataAdapter
 *    
 *    
 *    DataTools<MS> toolsForMicrosoft = new DataTools<MS>();
 *    toolsForMicrosoft.GetData();
 */

OracleDataToolsFactory oracle = new OracleDataToolsFactory();
var oracleConnection = oracle.CreateConnection();
var oracleCommand = oracle.CreateCommand();

oracleConnection.Connect();
oracleCommand.Execute();

DataTools<SqlDataToolsFactory> toolsForSQL = new DataTools<SqlDataToolsFactory>();
toolsForSQL.GetData();