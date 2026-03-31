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
[IsoId("_N5t8EZS8EemqYPWMBuVawg")]
[DisplayName("Modification Scope")]
public record ModificationScope41
{
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_ONWpw5S8EemqYPWMBuVawg")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
    /// </summary>
    [IsoId("_ONWpxZS8EemqYPWMBuVawg")]
    [DisplayName("Investment Plan")]
    [IsoXmlTag("InvstmtPlan")]
    public required InvestmentPlan16 InvestmentPlan { get; init; }
}
