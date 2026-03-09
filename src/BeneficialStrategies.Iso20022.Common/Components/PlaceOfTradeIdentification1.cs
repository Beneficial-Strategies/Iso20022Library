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
/// Identification of market in which a trade transaction has been executed.
/// </summary>
[IsoId("_xU1ak2wsEeWLq_lbZ2Mhyw")]
[DisplayName("Place Of Trade Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PlaceOfTradeIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification and type of the place of trade.
    /// </summary>
    [IsoId("_xU1alGwsEeWLq_lbZ2Mhyw")]
    [DisplayName("Market Type And Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktTpAndId")]
    #endif
    [IsoXmlTag("MktTpAndId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification84? MarketTypeAndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification84? MarketTypeAndIdentification { get; init; } 
    #else
    public MarketIdentification84? MarketTypeAndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a place of trade.
    /// </summary>
    [IsoId("_xU1alWwsEeWLq_lbZ2Mhyw")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    
    #nullable disable
    
}
