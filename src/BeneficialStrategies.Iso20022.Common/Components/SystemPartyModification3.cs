// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// System Party Modification3.
/// </summary>
[IsoId("_Y6_ygTE_Ee62xuUQ2zyZww")]
[DisplayName("System Party Modification3")]
public record SystemPartyModification3
{
    /// <summary>
    /// Requested Modification.
    /// </summary>
    [DisplayName("Requested Modification")]
    [IsoXmlTag("ReqdMod")]
    public required SystemPartyModification3Choice_ RequestedModification { get; init; }

    /// <summary>
    /// Scope Indication.
    /// </summary>
    [DisplayName("Scope Indication")]
    [IsoXmlTag("ScpIndctn")]
    public required DataModification1Code ScopeIndication { get; init; }
}
