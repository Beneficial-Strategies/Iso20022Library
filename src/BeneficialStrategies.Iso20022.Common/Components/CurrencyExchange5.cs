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
[IsoId("_QMGgUNp-Ed-ak6NoX_4Aeg_998870247")]
[DisplayName("Currency Exchange")]
public record CurrencyExchange5
{
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_QMGgUdp-Ed-ak6NoX_4Aeg_998870640")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveOrHistoricCurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_QMGgUtp-Ed-ak6NoX_4Aeg_998870649")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public ActiveOrHistoricCurrencyCode? TargetCurrency { get; init; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QMGgU9p-Ed-ak6NoX_4Aeg_998870278")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.||Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QMGgVNp-Ed-ak6NoX_4Aeg_998870308")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the foreign exchange contract.
    /// </summary>
    [IsoId("_QMGgVdp-Ed-ak6NoX_4Aeg_998870361")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ContractIdentification { get; init; }

    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_QMGgVtp-Ed-ak6NoX_4Aeg_998870330")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }
}
