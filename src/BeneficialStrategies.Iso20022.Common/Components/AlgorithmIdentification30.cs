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
[IsoId("_-eaooS_IEeugIJ3Gvoevmg")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification30
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_-pvu4S_IEeugIJ3Gvoevmg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm25Code Algorithm { get; init; }

    /// <summary>
    /// Parameters of the RSASSA-PSS digital signature algorithm (RSA signature algorithm with appendix: Probabilistic Signature Scheme).
    /// </summary>
    [IsoId("_-pvu4y_IEeugIJ3Gvoevmg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter15? Parameter { get; init; }
}
