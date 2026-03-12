// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError4Choice
{
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_MqM5Q9fiEeqoweZZxm4TPQ")]
    [DisplayName("Currency Exchange")]
    public partial record CurrencyExchange : ExchangeRateReportOrError4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
        /// </summary>
        [IsoId("_MsMdUdfiEeqoweZZxm4TPQ")]
        [DisplayName("Exchange Rate")]
        [IsoXmlTag("XchgRate")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public required IsoBaseOneRate ExchangeRate { get; init; } 
        
        /// <summary>
        /// Currency into which the base currency is converted, in a currency exchange.
        /// </summary>
        [IsoId("_MsMdU9fiEeqoweZZxm4TPQ")]
        [DisplayName("Quoted Currency")]
        [IsoXmlTag("QtdCcy")]
        public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
        
        /// <summary>
        /// Date and time at which an exchange rate is quoted.
        /// </summary>
        [IsoId("_MsMdVdfiEeqoweZZxm4TPQ")]
        [DisplayName("Quotation Date")]
        [IsoXmlTag("QtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime QuotationDate { get; init; } 
        
        /// <summary>
        /// Lowest limit defined for the exchange rate.
        /// Usage: The currency authority publishes the exchange rate based on the price formed in the foreign exchange market, allowing it to float up and down within the prescribed fluctuation range. It is the lowest exchange rate supported in foreign exchange market transactions.
        /// </summary>
        [IsoId("_T-IZ4NfiEeqoweZZxm4TPQ")]
        [DisplayName("Low Limit")]
        [IsoXmlTag("LwLmt")]
        public ExchangeRateOrPercentage1Choice_? LowLimit { get; init; } 
        
        /// <summary>
        /// Highest limit defined for the exchange rate.
        /// Usage: The currency authority publishes the exchange rate based on the price formed in the foreign exchange market, allowing it to float up and down within the prescribed fluctuation range. It is the highest exchange rate supported in foreign exchange market transactions.
        /// </summary>
        [IsoId("_U428wdfiEeqoweZZxm4TPQ")]
        [DisplayName("High Limit")]
        [IsoXmlTag("HghLmt")]
        public ExchangeRateOrPercentage1Choice_? HighLimit { get; init; } 
        
        
        #nullable disable
        
    }
}
