// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_QLp0Ztp-Ed-ak6NoX_4Aeg_2077728599")]
[DisplayName("Currency Exchange")]
public record CurrencyExchange3
{
    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    [IsoId("_QLzlYNp-Ed-ak6NoX_4Aeg_-2102720186")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_QLzlYdp-Ed-ak6NoX_4Aeg_-2102720169")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public CurrencyCode? TargetCurrency { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QLzlYtp-Ed-ak6NoX_4Aeg_-2102720523")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public CurrencyCode? UnitCurrency { get; init; }

    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.||Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QLzlY9p-Ed-ak6NoX_4Aeg_-2102720481")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the foreign exchange contract.
    /// </summary>
    [IsoId("_QLzlZNp-Ed-ak6NoX_4Aeg_-2102720204")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ContractIdentification { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_QLzlZdp-Ed-ak6NoX_4Aeg_-2102720246")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }
}
