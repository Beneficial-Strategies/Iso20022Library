// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the currency exchange.
/// </summary>
[Description(@"Set of elements used to provide details of the currency exchange.")]
[IsoId("_rA87IT6lEe-QZYT2pcGFZw")]
[DisplayName("Currency Exchange26")]
public record CurrencyExchange26
{
    /// <summary>
    /// Agent who undertakes the conversion of funds from the unit currency to the quoted currency.
    /// </summary>
    /// <remarks>
    /// Usage: The ForeignExchangeAgent must receive the AgreedRate block unchanged.
    /// </remarks>
    [DisplayName("Foreign Exchange Agent")]
    [IsoXmlTag("FXAgt")]
    public BranchAndFinancialInstitutionIdentification8? ForeignExchangeAgent { get; init; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency. (Amount in UnitCurrency * ExchangeRate = Amount in QuotedCurrency)
    /// </summary>
    [DisplayName("Pre Agreed Exchange Rate")]
    [IsoXmlTag("PreAgrdXchgRate")]
    public required IsoBaseOneRate PreAgreedExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [DisplayName("Quotation Date Time")]
    [IsoXmlTag("QtnDtTm")]
    public IsoISODateTime? QuotationDateTime { get; init; }

    /// <summary>
    /// Currency into which the base (unit) currency is converted. In the example GBP 1.00 = USD 1.30, the unit currency is USD.
    /// </summary>
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveOrHistoricCurrencyCode? QuotedCurrency { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the quote issued by the ForeignExchangeAgent.
    /// </summary>
    /// <remarks>
    /// Usage: This identification must be passed on throughout the entire end-to-end chain.
    /// </remarks>
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    public IsoUUIDv4Identifier? QuoteIdentification { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example GBP 1.00 = USD 1.30, the unit currency is GBP.
    /// </summary>
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; }
}
