// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Assessments for the component of the point of interaction.
/// </summary>
[IsoId("_0nUakAyQEeKa_56Jbsi1RQ")]
[DisplayName("Point Of Interaction Component Assessment")]
public record PointOfInteractionComponentAssessment1
{
    /// <summary>
    /// Type of assessment of the component.
    /// </summary>
    [IsoId("_Buco4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentAssessment1Code Type { get; init; }

    /// <summary>
    /// Body which has delivered the assessment.
    /// </summary>
    [IsoId("_L3GT4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> Assigner { get; init; } = [];

    // ID for the above is _L3GT4AyREeKa_56Jbsi1RQ

    /// <summary>
    /// Date when the assessment has been delivered.
    /// </summary>
    [IsoId("_TwUS4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Delivery Date")]
    [IsoXmlTag("DlvryDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeliveryDate { get; init; }

    /// <summary>
    /// Date when the assessment will expire.
    /// </summary>
    [IsoId("_cJlD4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpirationDate { get; init; }

    /// <summary>
    /// Unique assessment number for the component.
    /// </summary>
    [IsoId("_jKL_4AyREeKa_56Jbsi1RQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Number { get; init; }
}
