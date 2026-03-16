// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Equalisation Methodology Type2.
/// </summary>
[IsoId("_o4QsYSVKEe6pm5v5rjJOgQ")]
[DisplayName("Equalisation Methodology Type2")]
public record EqualisationMethodologyType2
{
    /// <summary>
    /// Equalisation Methodology Type Code.
    /// </summary>
    [DisplayName("Equalisation Methodology Type Code")]
    [IsoXmlTag("EqulstnMthdlgyTpCd")]
    public required EqualisationMethodologyType1Code EqualisationMethodologyTypeCode { get; init; }

    /// <summary>
    /// Related Subscription.
    /// </summary>
    [DisplayName("Related Subscription")]
    [IsoXmlTag("RltdSbcpt")]
    public ValueList<RelatedSubscription1> RelatedSubscription { get; init; } = [];
}
