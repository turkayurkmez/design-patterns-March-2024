// See https://aka.ms/new-console-template for more information
using InterfaceSegregation;

Console.WriteLine("Hello, World!");

/*
 *   Bir sınıf, bir interface'i implemente ediyorsa, o interface'den gelen tüm fonksiyonları implemente etmelidir.
 *   
 *   bir sınıf, bir interface'in sadece bazı fonksiyonlarını implemente edemez.
 *   
 *   
 *   
 */
SearchableComponent<Order> searchableComponent = new SearchableComponent<Order>();
OrderRepository repository = new OrderRepository();
searchableComponent.Search("a", repository);