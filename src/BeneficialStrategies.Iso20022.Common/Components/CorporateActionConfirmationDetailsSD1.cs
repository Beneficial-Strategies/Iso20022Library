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
[IsoId("_K5o5ppFEEeanIpS4qvJ1tw")]
[DisplayName("Corporate Action Confirmation Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionConfirmationDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionConfirmationDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionConfirmationDetailsSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_K5o5p5FEEeanIpS4qvJ1tw")]
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
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_8hNwcJFFEeanIpS4qvJ1tw")]
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
    /// Decimal above which numbers are rounded for prorated options. (e.g., if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up).
    /// </summary>
    [IsoId("_K5o5xJFEEeanIpS4qvJ1tw")]
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
