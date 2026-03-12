// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action securities movement fraction disposition details.
/// </summary>
[IsoId("_1T0gAzL3EeKU9IrkkToqcw_1213667222")]
[DisplayName("Fraction Disposition Type SD")]
public partial record FractionDispositionTypeSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1T0gBDL3EeKU9IrkkToqcw_167680877")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Used for the fractional rule that cannot be classified in ISO (fractional disposition) in the event that fractional disposition is calculated specific to the beneficial owner positions. Identifies a scenario where the issuer / market announced fractional security rounding at beneficial holder level. Used in conjunction with a rounding factor. For an example if rounding factor is 0.6, this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_1T0gBTL3EeKU9IrkkToqcw_-754135357")]
    [DisplayName("Fractional Security Rule")]
    [IsoXmlTag("FrctnlSctyRule")]
    public FractionalSecurityRule1Code? FractionalSecurityRule { get; init; } 
    
    /// <summary>
    /// Decimal above which numbers are rounded. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_1T9p8DL3EeKU9IrkkToqcw_49261840")]
    [DisplayName("Rounding Factor")]
    [IsoXmlTag("RndgFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? RoundingFactor { get; init; } 
    
    
    #nullable disable
    
}
