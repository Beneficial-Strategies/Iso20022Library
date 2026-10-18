// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_M5wl0IW7EeiDBOVr6AJAFA")]
public interface ICurrencyExchange13 : IIsoComponent
{
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_NF4WQYW7EeiDBOVr6AJAFA")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    ActiveCurrencyCode SourceCurrency { get; }

    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_NF4WQ4W7EeiDBOVr6AJAFA")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    ActiveCurrencyCode TargetCurrency { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_NF4WRYW7EeiDBOVr6AJAFA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    IsoBaseOneRate ExchangeRate { get; }

    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_NF4WSYW7EeiDBOVr6AJAFA")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    ActiveCurrencyCode? UnitCurrency { get; }
}
