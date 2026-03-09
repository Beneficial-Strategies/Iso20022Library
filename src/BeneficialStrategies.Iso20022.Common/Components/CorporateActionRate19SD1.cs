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
/// Extension to capture new to old ratio with extra digits.
/// </summary>
[IsoId("_gCCBwHcYEeGgn5GmpWx6yw")]
[DisplayName("Corporate Action Rate 19 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate19SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionRate19SD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionRate19SD1( LongQuantityToQuantityRatio2 reqLongQuantityToQuantity )
    {
        LongQuantityToQuantity = reqLongQuantityToQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_1TV0hXceEeGgn5GmpWx6yw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Ratio expressed as a quotient of high precision quantities.
    /// </summary>
    [IsoId("_igkj8HccEeGgn5GmpWx6yw")]
    [DisplayName("Long Quantity To Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LngQtyToQty")]
    #endif
    [IsoXmlTag("LngQtyToQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LongQuantityToQuantityRatio2 LongQuantityToQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LongQuantityToQuantityRatio2 LongQuantityToQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LongQuantityToQuantityRatio2 LongQuantityToQuantity { get; init; } 
    #else
    public LongQuantityToQuantityRatio2 LongQuantityToQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
