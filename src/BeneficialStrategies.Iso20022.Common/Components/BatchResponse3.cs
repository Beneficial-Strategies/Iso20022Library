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
[IsoId("_cgRuQS8PEeu125Ip9zFcsQ")]
[DisplayName("Batch Response")]
public record BatchResponse3
{
    /// <summary>
    /// Performed transaction content.
    /// </summary>
    [IsoId("_crs7IS8PEeu125Ip9zFcsQ")]
    [DisplayName("Performed Transaction")]
    [IsoXmlTag("PrfrmdTx")]
    public ValueList<PerformedTransaction3> PerformedTransaction { get; init; } = [];
}
