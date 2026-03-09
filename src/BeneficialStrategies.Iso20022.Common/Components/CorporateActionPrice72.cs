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
[IsoId("_o9HQ8RbTEeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice72
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
    [IsoId("_pSRooxbTEeyroI8qKgB7Mg")]
    [DisplayName("Maximum Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxPric")]
    #endif
    [IsoXmlTag("MaxPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat44Choice_? MaximumPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat44Choice_? MaximumPrice { get; init; } 
    #else
    public PriceFormat44Choice_? MaximumPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_pSRoqxbTEeyroI8qKgB7Mg")]
    [DisplayName("Minimum Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinPric")]
    #endif
    [IsoXmlTag("MinPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat44Choice_? MinimumPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat44Choice_? MinimumPrice { get; init; } 
    #else
    public PriceFormat44Choice_? MinimumPrice { get; set; } 
    #endif
    
    /// <summary>
    /// First acceptable price after the Minimum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_qXkcwhbTEeyroI8qKgB7Mg")]
    [DisplayName("First Bid Increment Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstBidIncrmtPric")]
    #endif
    [IsoXmlTag("FrstBidIncrmtPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat44Choice_? FirstBidIncrementPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat44Choice_? FirstBidIncrementPrice { get; init; } 
    #else
    public PriceFormat44Choice_? FirstBidIncrementPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Last acceptable price before the Maximum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_9r6bQRbTEeyroI8qKgB7Mg")]
    [DisplayName("Last Bid Increment Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastBidIncrmtPric")]
    #endif
    [IsoXmlTag("LastBidIncrmtPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat44Choice_? LastBidIncrementPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat44Choice_? LastBidIncrementPrice { get; init; } 
    #else
    public PriceFormat44Choice_? LastBidIncrementPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
