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
[IsoId("_RRZUddp-Ed-ak6NoX_4Aeg_1555387855")]
[DisplayName("Modification Scope")]
public record ModificationScope7
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRZUdtp-Ed-ak6NoX_4Aeg_1555387898")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information related to intermediaries.
    /// </summary>
    [IsoId("_RRZUd9p-Ed-ak6NoX_4Aeg_1555387934")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public required Intermediary13 Intermediary { get; init; }
}
