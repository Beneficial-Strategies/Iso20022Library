// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
[IsoId("_SpYh5AEcEeCQm6a_G2yO_w_153222959")]
[DisplayName("Agreed Rate")]
public partial record AgreedRate2
{
    #nullable enable
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_SpYh5QEcEeCQm6a_G2yO_w_39383893")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_SpYh5gEcEeCQm6a_G2yO_w_-843849394")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public required CurrencyCode UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_SpYh5wEcEeCQm6a_G2yO_w_-1840921747")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public required CurrencyCode QuotedCurrency { get; init; } 
    
    
    #nullable disable
    
}
