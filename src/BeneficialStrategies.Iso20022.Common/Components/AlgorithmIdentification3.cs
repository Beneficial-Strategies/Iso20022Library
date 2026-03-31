// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cryptographic algorithm and parameters for the MAC computation.
/// </summary>
[IsoId("_34gZcQipEeKn9O5oyej_zw")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification3
{
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    [IsoId("_4Ej4cQipEeKn9O5oyej_zw")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm3Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the algorithm.
    /// </summary>
    [IsoId("_4Ej4dQipEeKn9O5oyej_zw")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter1? Parameter { get; init; }
}
