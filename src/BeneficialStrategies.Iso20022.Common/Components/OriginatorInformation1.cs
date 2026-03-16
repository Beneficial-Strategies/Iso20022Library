// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the originator. It is present only if required by the key management algorithm.
/// </summary>
[IsoId("__XpcEOCwEee83LAjB5Kqdw")]
[DisplayName("Originator Information")]
public record OriginatorInformation1
{
    /// <summary>
    /// It may contain originator certificates associated with several different key management algorithms.
    /// </summary>
    [IsoId("_RHj98OCyEee83LAjB5Kqdw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax5000Binary> Certificate { get; init; } = [];
}
