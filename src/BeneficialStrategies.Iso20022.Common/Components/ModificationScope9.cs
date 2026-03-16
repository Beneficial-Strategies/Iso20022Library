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
[IsoId("_RRPjftp-Ed-ak6NoX_4Aeg_-1307334017")]
[DisplayName("Modification Scope")]
public record ModificationScope9
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRZUcNp-Ed-ak6NoX_4Aeg_-1307333774")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
    /// </summary>
    [IsoId("_RRZUcdp-Ed-ak6NoX_4Aeg_-1190045534")]
    [DisplayName("Issue Allocation")]
    [IsoXmlTag("IsseAllcn")]
    public required NewIssueAllocation1 IssueAllocation { get; init; }
}
