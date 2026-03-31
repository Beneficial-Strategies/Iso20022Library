// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rules governing an undertaking such as a guarantee or standby letter of credit.
/// </summary>
[IsoId("_94TXpnltEeG7BsjMvd1mEw_101008065")]
[DisplayName("Governance Rules")]
public record GovernanceRules1
{
    /// <summary>
    /// Identification of the governance rules.
    /// </summary>
    [IsoId("_94TXp3ltEeG7BsjMvd1mEw_-150505630")]
    [DisplayName("Rule Identification")]
    [IsoXmlTag("RuleId")]
    public required GovernanceIdentification1Choice_ RuleIdentification { get; init; }

    /// <summary>
    /// Law applicable to the undertaking.
    /// </summary>
    [IsoId("_94TXqHltEeG7BsjMvd1mEw_-1056936320")]
    [DisplayName("Applicable Law")]
    [IsoXmlTag("AplblLaw")]
    public Location1? ApplicableLaw { get; init; }

    /// <summary>
    /// Place at or system under which any dispute related to the undertaking is to be resolved, such as court or arbitration. This is also known as &apos;forum&apos;.
    /// </summary>
    [IsoId("_94TXqXltEeG7BsjMvd1mEw_1402302275")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public ValueList<Location1> Jurisdiction { get; init; } = [];
}
