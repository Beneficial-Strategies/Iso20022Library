// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError2Choice
{
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_77TPQ6MgEeCJ6YNENx4h-w_-1305206641")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public record CurrencyExchange : ExchangeRateReportOrError2Choice_
    {
        /// <summary>
        /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
        /// </summary>
        [IsoId("_77cZMKMgEeCJ6YNENx4h-w_150823148")]
        [DisplayName("Exchange Rate")]
        [IsoXmlTag("XchgRate")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        public required IsoBaseOneRate ExchangeRate { get; init; }

        /// <summary>
        /// Currency into which the base currency is converted, in a currency exchange.
        /// </summary>
        [IsoId("_77cZMaMgEeCJ6YNENx4h-w_-47235485")]
        [DisplayName("Quoted Currency")]
        [IsoXmlTag("QtdCcy")]
        public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; }

        /// <summary>
        /// Date and time at which an exchange rate is quoted.
        /// </summary>
        [IsoId("_77cZMqMgEeCJ6YNENx4h-w_1808142586")]
        [DisplayName("Quotation Date")]
        [IsoXmlTag("QtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime QuotationDate { get; init; }
    }
}
