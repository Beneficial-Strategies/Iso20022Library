// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the billing rate.
/// </summary>
[IsoId("_6QGNppqlEeGSON8vddiWzQ_1919554496")]
[DisplayName("Billing Rate")]
public record BillingRate1
{
    /// <summary>
    /// Defines the type of rate or factor.
    /// </summary>
    [IsoId("_6QP-oJqlEeGSON8vddiWzQ_-585660341")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required BillingRateIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Value of the rate or factor identified in the rate identification.
    /// </summary>
    [IsoId("_6QP-oZqlEeGSON8vddiWzQ_-1751808782")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Value { get; init; }

    /// <summary>
    /// Number of days in the statement period. ||Usage: Used along with DaysInYear for time dependent per annum rate value.
    /// </summary>
    [IsoId("_6QP-opqlEeGSON8vddiWzQ_-1641402761")]
    [DisplayName("Days In Period")]
    [IsoXmlTag("DaysInPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysInPeriod { get; init; }

    /// <summary>
    /// Number of days in the year.||Usage: Used along with DaysInPeriod for time dependent per annum rate value.
    /// </summary>
    [IsoId("_6QP-o5qlEeGSON8vddiWzQ_-1276728980")]
    [DisplayName("Days In Year")]
    [IsoXmlTag("DaysInYr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DaysInYear { get; init; }
}
