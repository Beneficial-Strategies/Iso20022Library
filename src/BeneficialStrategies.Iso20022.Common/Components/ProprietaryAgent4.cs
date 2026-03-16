// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a proprietary party.
/// </summary>
[IsoId("_HH3jG24-EeiU9cctagi5ow")]
[DisplayName("Proprietary Agent")]
public record ProprietaryAgent4
{
    /// <summary>
    /// Specifies the type of proprietary agent.
    /// </summary>
    [IsoId("_HRG-k24-EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Organisation established primarily to provide financial services.
    /// </summary>
    [IsoId("_HRG-lW4-EeiU9cctagi5ow")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }
}
