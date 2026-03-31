// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity providing data for risk assessment
/// </summary>
[IsoId("_sMaVcNv-EeeOusYHZbyj7w")]
[DisplayName("Risk Assessment Data Entity Provider")]
public record RiskAssessmentDataEntityProvider1
{
    /// <summary>
    /// Type of entity providing data for risk assessment.
    /// </summary>
    [IsoId("_YLgWcNv_EeeOusYHZbyj7w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType28Code? Type { get; init; }

    /// <summary>
    /// Other type of entity providing risk assessment data.
    /// </summary>
    [IsoId("_d1xKkNv_EeeOusYHZbyj7w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }
}
