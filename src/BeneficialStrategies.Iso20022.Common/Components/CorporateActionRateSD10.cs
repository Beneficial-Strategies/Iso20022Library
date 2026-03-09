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
/// Provides additional information regarding corporate action option securities movement rate details.
/// </summary>
[IsoId("_IeDD4b5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Rate SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRateSD10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_IuabIb5XEeexmbB7KsjCwA")]
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
    /// Corresponding rate of the security being disbursed as a result of the corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_IuabI75XEeexmbB7KsjCwA")]
    [DisplayName("Declared Security Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdSctyRate")]
    #endif
    [IsoXmlTag("DclrdSctyRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRateSD7Choice_? DeclaredSecurityRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRateSD7Choice_? DeclaredSecurityRate { get; init; } 
    #else
    public CorporateActionRateSD7Choice_? DeclaredSecurityRate { get; set; } 
    #endif
    
    /// <summary>
    /// Denotes whether the rate is approximate.
    /// </summary>
    [IsoId("_IuabMb5XEeexmbB7KsjCwA")]
    [DisplayName("Estimated Rate Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdRateFlg")]
    #endif
    [IsoXmlTag("EstmtdRateFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? EstimatedRateFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EstimatedRateFlag { get; init; } 
    #else
    public System.String? EstimatedRateFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Rate at which the fee will be charged to a DTC participant.
    /// </summary>
    [IsoId("_IuabOb5XEeexmbB7KsjCwA")]
    [DisplayName("Declared Fee Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdFeeRate")]
    #endif
    [IsoXmlTag("DclrdFeeRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; init; } 
    #else
    public PriceFormatSD3Choice_? DeclaredFeeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
