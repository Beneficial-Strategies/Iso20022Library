// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action confirmation details.
/// </summary>
[IsoId("_kNOkkb-zEeeb2ZBoAlSG1Q")]
[DisplayName("Corporate Action Confirmation Details SD")]
public record CorporateActionConfirmationDetailsSD2
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_keMYwb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("_keMYw7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; }

    /// <summary>
    /// Decimal above which numbers are rounded for prorated options. For example if the rounding factor is 0.5, numbers of 0.5 and above will be rounded up.
    /// </summary>
    [IsoId("_keMYxb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProrationFraction { get; init; }
}
