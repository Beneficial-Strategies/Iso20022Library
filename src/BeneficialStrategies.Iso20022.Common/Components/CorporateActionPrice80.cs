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
/// Specifies various prices of a corporate action.
/// </summary>
[IsoId("_p4W0_Ti7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice80
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4W1ATi7Eeydid5dcNPKvg")]
    [DisplayName("Maximum Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxPric")]
    #endif
    [IsoXmlTag("MaxPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat59Choice_? MaximumPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat59Choice_? MaximumPrice { get; init; } 
    #else
    public PriceFormat59Choice_? MaximumPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4W1CTi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinPric")]
    #endif
    [IsoXmlTag("MinPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat59Choice_? MinimumPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat59Choice_? MinimumPrice { get; init; } 
    #else
    public PriceFormat59Choice_? MinimumPrice { get; set; } 
    #endif
    
    /// <summary>
    /// First acceptable price after the Minimum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4W1ETi7Eeydid5dcNPKvg")]
    [DisplayName("First Bid Increment Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstBidIncrmtPric")]
    #endif
    [IsoXmlTag("FrstBidIncrmtPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat59Choice_? FirstBidIncrementPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat59Choice_? FirstBidIncrementPrice { get; init; } 
    #else
    public PriceFormat59Choice_? FirstBidIncrementPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Last acceptable price before the Maximum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4W1Ezi7Eeydid5dcNPKvg")]
    [DisplayName("Last Bid Increment Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastBidIncrmtPric")]
    #endif
    [IsoXmlTag("LastBidIncrmtPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat59Choice_? LastBidIncrementPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat59Choice_? LastBidIncrementPrice { get; init; } 
    #else
    public PriceFormat59Choice_? LastBidIncrementPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
