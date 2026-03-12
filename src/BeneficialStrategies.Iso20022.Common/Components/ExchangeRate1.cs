// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further detailed information on the exchange rate that has been used in the payment transaction.
/// </summary>
[IsoId("_t0booVkyEeGeoaLUQk__nA_667162887")]
[DisplayName("Exchange Rate")]
public partial record ExchangeRate1
{
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_t0boolkyEeGeoaLUQk__nA_-816743916")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; } 
    
    /// <summary>
    /// The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_t0boo1kyEeGeoaLUQk__nA_2015981061")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Specifies the type used to complete the currency exchange.
    /// </summary>
    [IsoId("_t0bopFkyEeGeoaLUQk__nA_1712924546")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType1Code? RateType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent.
    /// </summary>
    [IsoId("_t0bopVkyEeGeoaLUQk__nA_198863021")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ContractIdentification { get; init; } 
    
    
    #nullable disable
    
}
