// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action confirmation details.
/// </summary>
[IsoId("_K5o5ppFEEeanIpS4qvJ1tw")]
[DisplayName("Corporate Action Confirmation Details SD")]
public partial record CorporateActionConfirmationDetailsSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_K5o5p5FEEeanIpS4qvJ1tw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_8hNwcJFFEeanIpS4qvJ1tw")]
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; } 
    
    /// <summary>
    /// Decimal above which numbers are rounded for prorated options. (e.g., if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up).
    /// </summary>
    [IsoId("_K5o5xJFEEeanIpS4qvJ1tw")]
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProrationFraction { get; init; } 
    
    
    #nullable disable
    
}
