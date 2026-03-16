// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Batch Response message.
/// </summary>
[IsoId("_DpHiYNxWEeioifFt1dhnJA")]
[DisplayName("Batch Response")]
public record BatchResponse1
{
    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_M84MwNxWEeioifFt1dhnJA")]
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public PerformedTransaction1? PerformedTransaction { get; init; }
}
