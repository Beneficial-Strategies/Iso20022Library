// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_j3RgUZQ_EemqYPWMBuVawg")]
[DisplayName("Modification Scope")]
public record ModificationScope40
{
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_kMs9wZQ_EemqYPWMBuVawg")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_kMs9w5Q_EemqYPWMBuVawg")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public required Intermediary46 Intermediary { get; init; }
}
