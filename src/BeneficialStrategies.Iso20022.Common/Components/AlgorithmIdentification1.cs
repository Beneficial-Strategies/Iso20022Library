// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cryptographic algorithm.
/// </summary>
[IsoId("_Sw--twEcEeCQm6a_G2yO_w_-1845073315")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification1
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_Sw--uAEcEeCQm6a_G2yO_w_-1157879065")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm1Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_Sw--uQEcEeCQm6a_G2yO_w_1001350985")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; }
}
