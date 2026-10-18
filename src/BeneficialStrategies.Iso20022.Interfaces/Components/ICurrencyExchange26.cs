// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the currency exchange.
/// </summary>
[IsoId("_rA87IT6lEe-QZYT2pcGFZw")]
public interface ICurrencyExchange26 : IIsoComponent
{
    /// <summary>
    /// Agent who undertakes the conversion of funds from the unit currency to the quoted currency.
    /// </summary>
    /// <remarks>
    /// Usage: The ForeignExchangeAgent must receive the AgreedRate block unchanged.
    /// </remarks>
    [DisplayName("Foreign Exchange Agent")]
    [IsoXmlTag("FXAgt")]
    IBranchAndFinancialInstitutionIdentification8? ForeignExchangeAgent { get; }

    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency. (Amount in UnitCurrency * ExchangeRate = Amount in QuotedCurrency)
    /// </summary>
    [DisplayName("Pre Agreed Exchange Rate")]
    [IsoXmlTag("PreAgrdXchgRate")]
    IsoBaseOneRate PreAgreedExchangeRate { get; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [DisplayName("Quotation Date Time")]
    [IsoXmlTag("QtnDtTm")]
    IsoISODateTime? QuotationDateTime { get; }

    /// <summary>
    /// Currency into which the base (unit) currency is converted. In the example GBP 1.00 = USD 1.30, the unit currency is USD.
    /// </summary>
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    ActiveOrHistoricCurrencyCode? QuotedCurrency { get; }

    /// <summary>
    /// Unique identification to unambiguously identify the quote issued by the ForeignExchangeAgent.
    /// </summary>
    /// <remarks>
    /// Usage: This identification must be passed on throughout the entire end-to-end chain.
    /// </remarks>
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    IsoUUIDv4Identifier? QuoteIdentification { get; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example GBP 1.00 = USD 1.30, the unit currency is GBP.
    /// </summary>
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    ActiveOrHistoricCurrencyCode? UnitCurrency { get; }
}
