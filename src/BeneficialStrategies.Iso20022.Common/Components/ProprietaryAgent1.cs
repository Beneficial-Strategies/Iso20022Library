// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to identify a proprietary party.
/// </summary>
[IsoId("_RUOmCNp-Ed-ak6NoX_4Aeg_2134128505")]
[DisplayName("Proprietary Agent")]
public record ProprietaryAgent1
{
    /// <summary>
    /// Identifies the type of proprietary agent reported.
    /// </summary>
    [IsoId("_RUXv8Np-Ed-ak6NoX_4Aeg_2134128748")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Proprietary agent.
    /// </summary>
    [IsoId("_RUXv8dp-Ed-ak6NoX_4Aeg_2134128808")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification3 Agent { get; init; }
}
