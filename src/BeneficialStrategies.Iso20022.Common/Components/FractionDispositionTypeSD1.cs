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
/// Provides additional information regarding corporate action securities movement fraction disposition details.
/// </summary>
[IsoId("_1T0gAzL3EeKU9IrkkToqcw_1213667222")]
[DisplayName("Fraction Disposition Type SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FractionDispositionTypeSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FractionDispositionTypeSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FractionDispositionTypeSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1T0gBDL3EeKU9IrkkToqcw_167680877")]
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
    /// Used for the fractional rule that cannot be classified in ISO (fractional disposition) in the event that fractional disposition is calculated specific to the beneficial owner positions. Identifies a scenario where the issuer / market announced fractional security rounding at beneficial holder level. Used in conjunction with a rounding factor. For an example if rounding factor is 0.6, this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_1T0gBTL3EeKU9IrkkToqcw_-754135357")]
    [DisplayName("Fractional Security Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnlSctyRule")]
    #endif
    [IsoXmlTag("FrctnlSctyRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FractionalSecurityRule1Code? FractionalSecurityRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FractionalSecurityRule1Code? FractionalSecurityRule { get; init; } 
    #else
    public FractionalSecurityRule1Code? FractionalSecurityRule { get; set; } 
    #endif
    
    /// <summary>
    /// Decimal above which numbers are rounded. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_1T9p8DL3EeKU9IrkkToqcw_49261840")]
    [DisplayName("Rounding Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgFctr")]
    #endif
    [IsoXmlTag("RndgFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? RoundingFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RoundingFactor { get; init; } 
    #else
    public System.UInt64? RoundingFactor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
