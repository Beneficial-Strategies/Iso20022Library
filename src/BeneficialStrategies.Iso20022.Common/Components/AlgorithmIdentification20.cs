// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cryptographic algorithm and parameters for digital signatures.
/// </summary>
[IsoId("_L656AdtbEee9e6xduATmQg")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification20
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_MEmokdtbEee9e6xduATmQg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm19Code Algorithm { get; init; }

    /// <summary>
    /// Parameters of the RSASSA-PSS digital signature algorithm (RSA signature algorithm with appendix: Probabilistic Signature Scheme).
    /// </summary>
    [IsoId("_MEmok9tbEee9e6xduATmQg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter11? Parameter { get; init; }
}
