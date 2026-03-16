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
[IsoId("_RrBVZ9p-Ed-ak6NoX_4Aeg_467657186")]
[DisplayName("Proprietary Data")]
public record ProprietaryData3
{
    /// <summary>
    /// Proprietary content.
    /// </summary>
    [IsoId("_RrBVaNp-Ed-ak6NoX_4Aeg_467657279")]
    [DisplayName("Any")]
    [IsoXmlTag("Any")]
    public required SkipProcessing Any { get; init; }
}
