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
[IsoId("_XWbdgQjbEeS5F6qHcKOrew")]
[DisplayName("Modification Scope")]
public record ModificationScope25
{
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_Xxg3AwjbEeS5F6qHcKOrew")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; }

    /// <summary>
    /// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
    /// </summary>
    [IsoId("_Xxg3BQjbEeS5F6qHcKOrew")]
    [DisplayName("Investment Plan")]
    [IsoXmlTag("InvstmtPlan")]
    public required InvestmentPlan11 InvestmentPlan { get; init; }
}
