// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action securities movement fraction disposition details.
/// </summary>
[IsoId("_PhIFEb5XEeexmbB7KsjCwA")]
[DisplayName("Fraction Disposition Type SD")]
public record FractionDispositionTypeSD3
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_PxVrUb5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Decimal above which numbers are rounded. For an example if rounding factor is 0.6 this means that fractional units greater than or equal to 6 will be rounded up and less than 6 will be rounded down.
    /// </summary>
    [IsoId("_PxVrU75XEeexmbB7KsjCwA")]
    [DisplayName("Rounding Factor")]
    [IsoXmlTag("RndgFctr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? RoundingFactor { get; init; }
}
