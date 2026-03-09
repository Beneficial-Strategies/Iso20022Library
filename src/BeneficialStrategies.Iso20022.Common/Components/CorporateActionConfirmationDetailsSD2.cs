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
/// Provides additional information regarding corporate action confirmation details.
/// </summary>
[IsoId("_kNOkkb-zEeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Confirmation Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionConfirmationDetailsSD2
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
    [IsoId("_keMYwb-zEeeb2ZBoAlSG1Q")]
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
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_keMYw7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Proration Rounding Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnRndgInd")]
    #endif
    [IsoXmlTag("PrratnRndgInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    #else
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Decimal above which numbers are rounded for prorated options. For example if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up.
    /// </summary>
    [IsoId("_keMYxb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Proration Fraction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrratnFrctn")]
    #endif
    [IsoXmlTag("PrratnFrctn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProrationFraction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProrationFraction { get; init; } 
    #else
    public System.UInt64? ProrationFraction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
