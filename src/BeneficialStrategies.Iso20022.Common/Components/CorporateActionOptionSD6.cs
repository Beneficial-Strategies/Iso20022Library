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
/// Provides additional information regarding corporate action option details.
/// </summary>
[IsoId("_uBb14UlQEeK8UrXTVVBVxw")]
[DisplayName("Corporate Action Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOptionSD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOptionSD6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOptionSD6( System.String reqPlaceAndName,System.String reqDefaultOptionFlag )
    {
        PlaceAndName = reqPlaceAndName;
        DefaultOptionFlag = reqDefaultOptionFlag;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_uZmeQUlQEeK8UrXTVVBVxw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    [IsoId("_uZmeRUlQEeK8UrXTVVBVxw")]
    [DisplayName("Extended Option Features")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedOptnFeatrs")]
    #endif
    [IsoXmlTag("XtndedOptnFeatrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    #else
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the option is declared as default by the issuer / offeror, and will be treated as default by the issuer / offeror if no elections is made.
    /// </summary>
    [IsoId("_uZmeT0lQEeK8UrXTVVBVxw")]
    [DisplayName("Default Option Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltOptnFlg")]
    #endif
    [IsoXmlTag("DfltOptnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator DefaultOptionFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DefaultOptionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DefaultOptionFlag { get; init; } 
    #else
    public System.String DefaultOptionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    [IsoId("_BpPtgElSEeK8UrXTVVBVxw")]
    [DisplayName("Optional Dividend Supplementary Data Required Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnlDvddSplmtryDataReqrdFlg")]
    #endif
    [IsoXmlTag("OptnlDvddSplmtryDataReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    #else
    public System.String? OptionalDividendSupplementaryDataRequiredFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
