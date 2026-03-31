// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary Agent5.
/// </summary>
[IsoId("_xmnquTEyEe6g-ffJsqGiSA")]
[DisplayName("Proprietary Agent5")]
public record ProprietaryAgent5
{
    /// <summary>
    /// Agent.
    /// </summary>
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification8 Agent { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IsoMax35Text Type { get; init; }
}
