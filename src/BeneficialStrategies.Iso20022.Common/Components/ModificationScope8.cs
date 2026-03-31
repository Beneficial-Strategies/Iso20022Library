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
[IsoId("_RRZUctp-Ed-ak6NoX_4Aeg_1378854894")]
[DisplayName("Modification Scope")]
public record ModificationScope8
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRZUc9p-Ed-ak6NoX_4Aeg_1378854912")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
    /// </summary>
    [IsoId("_RRZUdNp-Ed-ak6NoX_4Aeg_1378854955")]
    [DisplayName("Investment Plan")]
    [IsoXmlTag("InvstmtPlan")]
    public required InvestmentPlan5 InvestmentPlan { get; init; }
}
