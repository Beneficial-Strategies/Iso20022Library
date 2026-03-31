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
[IsoId("__YZO0WkIEeS7zPBpvm732w")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification15
{
    /// <summary>
    /// Identification of the MAC algorithm.
    /// </summary>
    [IsoId("__ll9UWkIEeS7zPBpvm732w")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm12Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the MAC algorithm.
    /// </summary>
    [IsoId("__ll9U2kIEeS7zPBpvm732w")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter7? Parameter { get; init; }
}
