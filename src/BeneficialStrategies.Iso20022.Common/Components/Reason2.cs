// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason for an action.
/// </summary>
[IsoId("_RJ8oo9p-Ed-ak6NoX_4Aeg_949144780")]
[DisplayName("Reason")]
public record Reason2
{
    /// <summary>
    /// Detailed description of the rejection.
    /// </summary>
    [IsoId("_RJ8opNp-Ed-ak6NoX_4Aeg_987008657")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Description { get; init; }
}
