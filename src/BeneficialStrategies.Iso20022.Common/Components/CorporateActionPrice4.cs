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
/// Specifies prices.
/// </summary>
[IsoId("_UKwuSNp-Ed-ak6NoX_4Aeg_-198423815")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Estimated price, eg, for valuation purposes.
    /// </summary>
    [IsoId("_UKwuSdp-Ed-ak6NoX_4Aeg_-187341801")]
    [DisplayName("Indicative Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndctvPric")]
    #endif
    [IsoXmlTag("IndctvPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat2Choice_? IndicativePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat2Choice_? IndicativePrice { get; init; } 
    #else
    public PriceFormat2Choice_? IndicativePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_UK6fQNp-Ed-ak6NoX_4Aeg_2014235941")]
    [DisplayName("Market Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPric")]
    #endif
    [IsoXmlTag("MktPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat2Choice_? MarketPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat2Choice_? MarketPrice { get; init; } 
    #else
    public PriceFormat2Choice_? MarketPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
