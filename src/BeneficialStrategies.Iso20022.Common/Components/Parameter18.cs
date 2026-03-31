// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameter18.
/// </summary>
[IsoId("_eF9wAZWvEe6FeYYOKs6hxw")]
[DisplayName("Parameter18")]
public record Parameter18
{
    /// <summary>
    /// Digest Algorithm.
    /// </summary>
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm26Code? DigestAlgorithm { get; init; }
}
