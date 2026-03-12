// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Technique whereby a position in the underlying is traded for a futures position in the physical commodity markets.
/// </summary>
[IsoId("_Syi-L9p-Ed-ak6NoX_4Aeg_1763199616")]
[DisplayName("Exchange For Physical Trade Parameters")]
public partial record ExchangeForPhysicalTradeParameters1
{
    #nullable enable
    
    /// <summary>
    /// Unexpected divergence between the price behaviour of an underlying position or portfolio and the price behaviour of a hedging position or benchmark.
    /// </summary>
    [IsoId("_SysvINp-Ed-ak6NoX_4Aeg_2093820213")]
    [DisplayName("Outside Index")]
    [IsoXmlTag("OutsdIndx")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? OutsideIndex { get; init; } 
    
    /// <summary>
    /// Difference between the value of a future and the value of the underlying equities after allowing for the discounted cash flows associated with the underlying stocks.
    /// </summary>
    [IsoId("_SysvIdp-Ed-ak6NoX_4Aeg_2094742650")]
    [DisplayName("Fair Value")]
    [IsoXmlTag("FairVal")]
    public ActiveCurrencyAndAmount? FairValue { get; init; } 
    
    /// <summary>
    /// Value of a futures position involved in an Exchange For Physical trade.
    /// </summary>
    [IsoId("_SysvItp-Ed-ak6NoX_4Aeg_2094742693")]
    [DisplayName("Value For Futures")]
    [IsoXmlTag("ValForFutrs")]
    public ActiveCurrencyAndAmount? ValueForFutures { get; init; } 
    
    
    #nullable disable
    
}
