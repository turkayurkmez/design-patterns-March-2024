using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Gelecek olan veriyi modelledik
    /// </summary>
	public class Currency
    {
        public double Selling { get; set; }
        public double Buying { get; set; }

        public string FromProvider { get; set; }
    }

    /// <summary>
    /// Hem source hem de target aynı arayüzü kullanırlar:
    /// </summary>
    public interface ICurrencyAdapter
    {
        public List<Currency> GetCurrencies();
    }

    /// <summary>
    /// XML Adaptörü. Kaynak: XML belgesi, 
    ///               Hedef: List<Currency>
    /// </summary>
    public class XMLCurrencyProvider : ICurrencyAdapter
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency>() { new() { FromProvider = "XML Provider" } };
        }
    }
    /// <summary>
    /// Json Adaptörü. Kaynak: Json belgesi, 
    ///               Hedef: List<Currency>
    /// </summary>
    public class JSONCurrencyProvider : ICurrencyAdapter
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency>() { new() { FromProvider = "Json Provider" } };
        }
    }

    public class CurrencyAdaptee
    {
        public List<Currency> GetCurrencies(ICurrencyAdapter currencyAdapter) => currencyAdapter.GetCurrencies();
    }
}
