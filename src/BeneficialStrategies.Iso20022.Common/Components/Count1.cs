// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a sequence number or a total.
/// </summary>
[IsoId("_RJDQxNp-Ed-ak6NoX_4Aeg_1838853440")]
[DisplayName("Count")]
public record Count1
{
    /// <summary>
    /// Sequence or total number.
    /// </summary>
    [IsoId("_RJDQxdp-Ed-ak6NoX_4Aeg_1906271406")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Number { get; init; }
}
