// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rules governing an undertaking such as a guarantee or standby letter of credit.
/// </summary>
[IsoId("_OTgzMjIy-AOSNFX-8224493")]
[DisplayName("Governance Rules")]
public record GovernanceRules2
{
    /// <summary>
    /// Local identification to be used in IDREFs.
    /// </summary>
    [IsoId("_OTgzMjI5-AOSNFX-8224493")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ID)]
    public required IsoID Identification { get; init; }

    /// <summary>
    /// Identification of the governance rules.
    /// </summary>
    [IsoId("_OTgzMjMw-AOSNFX-8224493")]
    [DisplayName("Rule Identification")]
    [IsoXmlTag("RuleId")]
    public required GovernanceIdentification1Choice_ RuleIdentification { get; init; }

    /// <summary>
    /// Law applicable to the undertaking.
    /// </summary>
    [IsoId("_OTgzMjMx-AOSNFX-8224493")]
    [DisplayName("Applicable Law")]
    [IsoXmlTag("AplblLaw")]
    public Location1? ApplicableLaw { get; init; }

    /// <summary>
    /// Place at or system under which any dispute related to the undertaking is to be resolved, such as court or arbitration. This is also known as &apos;forum&apos;.
    /// </summary>
    [IsoId("_OTgzMjMy-AOSNFX-8224493")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Location1? Jurisdiction { get; init; }
}
