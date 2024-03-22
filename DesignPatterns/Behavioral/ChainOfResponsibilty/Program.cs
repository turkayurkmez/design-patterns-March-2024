// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilty;

Console.WriteLine("Hello, World!");
/*
 * app.UseRouting();
 * app.UseCors()
 * app.UseAuthentication();
 * app.UseAuthorization();
 *
 *  Arka arkaya çalışması gereken, genellikle aynı nesne üzerinde denetim (ya manipülasyon) sağlayan  bir mekanizma olsun (Yukarıda asp.net'de httpRequest örneği var). Bu mekanizmayı en ideal bir biçimde nasıl tasarlarız?
 */

CheckOwnerResponsible ownerResponsible = new CheckOwnerResponsible();
CheckInAndOutDateResponsible checkInAndOutDateResponsible = new CheckInAndOutDateResponsible();
CompleteAndSaveToDatabaseResponsible completeAndSaveToDatabaseResponsible = new CompleteAndSaveToDatabaseResponsible();

ownerResponsible.Next = checkInAndOutDateResponsible;
checkInAndOutDateResponsible.Next = completeAndSaveToDatabaseResponsible;

Reservation reservation = new Reservation() { Owner = "Türkay", CheckIn = DateTime.Now.AddDays(10), CheckOut = DateTime.Now.AddDays(20), ParticipantsCount = 50 };

ownerResponsible.Handler(reservation);


