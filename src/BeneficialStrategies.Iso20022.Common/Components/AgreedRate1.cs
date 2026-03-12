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
[IsoId("_QLW5ctp-Ed-ak6NoX_4Aeg_290674057")]
[DisplayName("Agreed Rate")]
public partial record AgreedRate1
{
    #nullable enable
    
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QLW5c9p-Ed-ak6NoX_4Aeg_290674060")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QLW5dNp-Ed-ak6NoX_4Aeg_290674058")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public CurrencyCode? UnitCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_QLW5ddp-Ed-ak6NoX_4Aeg_290674059")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public CurrencyCode? QuotedCurrency { get; init; } 
    
    
    #nullable disable
    
}
