// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further detailed information on the exchange rate that has been used in the payment transaction.
/// </summary>
[IsoId("_t0booVkyEeGeoaLUQk__nA_667162887")]
public interface IExchangeRate1 : IIsoComponent
{
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_t0boolkyEeGeoaLUQk__nA_-816743916")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    ActiveOrHistoricCurrencyCode? UnitCurrency { get; }

    /// <summary>
    /// The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_t0boo1kyEeGeoaLUQk__nA_2015981061")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    IsoBaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Specifies the type used to complete the currency exchange.
    /// </summary>
    [IsoId("_t0bopFkyEeGeoaLUQk__nA_1712924546")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    ExchangeRateType1Code? RateType { get; }

    /// <summary>
    /// Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent.
    /// </summary>
    [IsoId("_t0bopVkyEeGeoaLUQk__nA_198863021")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    IsoMax35Text? ContractIdentification { get; }
}
