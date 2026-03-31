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
[IsoId("_HJS6cRRdEeOKWo1NF21OVw")]
[DisplayName("Modification Scope")]
public record ModificationScope18
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_HhjpcxRdEeOKWo1NF21OVw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
    /// </summary>
    [IsoId("_HhjpdRRdEeOKWo1NF21OVw")]
    [DisplayName("Investment Plan")]
    [IsoXmlTag("InvstmtPlan")]
    public required InvestmentPlan8 InvestmentPlan { get; init; }
}
