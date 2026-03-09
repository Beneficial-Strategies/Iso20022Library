// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Technique whereby a position in the underlying is traded for a futures position in the physical commodity markets.
/// </summary>
[IsoId("_Syi-L9p-Ed-ak6NoX_4Aeg_1763199616")]
[DisplayName("Exchange For Physical Trade Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExchangeForPhysicalTradeParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unexpected divergence between the price behaviour of an underlying position or portfolio and the price behaviour of a hedging position or benchmark.
    /// </summary>
    [IsoId("_SysvINp-Ed-ak6NoX_4Aeg_2093820213")]
    [DisplayName("Outside Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdIndx")]
    #endif
    [IsoXmlTag("OutsdIndx")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? OutsideIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? OutsideIndex { get; init; } 
    #else
    public System.Decimal? OutsideIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the value of a future and the value of the underlying equities after allowing for the discounted cash flows associated with the underlying stocks.
    /// </summary>
    [IsoId("_SysvIdp-Ed-ak6NoX_4Aeg_2094742650")]
    [DisplayName("Fair Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FairVal")]
    #endif
    [IsoXmlTag("FairVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? FairValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? FairValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? FairValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value of a futures position involved in an Exchange For Physical trade.
    /// </summary>
    [IsoId("_SysvItp-Ed-ak6NoX_4Aeg_2094742693")]
    [DisplayName("Value For Futures")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValForFutrs")]
    #endif
    [IsoXmlTag("ValForFutrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ValueForFutures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ValueForFutures { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ValueForFutures { get; set; } 
    #endif
    
    
    #nullable disable
    
}
