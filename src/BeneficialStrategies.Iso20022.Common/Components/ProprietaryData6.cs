// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for proprietary information. Business content of this element is not specified.
/// </summary>
[IsoId("_1gW-cYKYEee7hrXqLO3yQg")]
[DisplayName("Proprietary Data")]
public record ProprietaryData6
{
    /// <summary>
    /// Proprietary content.
    /// </summary>
    [IsoId("_1oY5E4KYEee7hrXqLO3yQg")]
    [DisplayName("Any")]
    [IsoXmlTag("Any")]
    public required SkipPayload Any { get; init; }
}
