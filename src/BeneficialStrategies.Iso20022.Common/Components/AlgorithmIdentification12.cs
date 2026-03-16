// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mask generator function cryptographic algorithm and parameters.
/// </summary>
[IsoId("_TH2DUWi5EeS87LmvcA55sg")]
[DisplayName("Algorithm Identification")]
public record AlgorithmIdentification12
{
    /// <summary>
    /// Mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_TUzhQWi5EeS87LmvcA55sg")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm8Code Algorithm { get; init; }

    /// <summary>
    /// Parameters associated to the mask generator function cryptographic algorithm.
    /// </summary>
    [IsoId("_TU0IUWi5EeS87LmvcA55sg")]
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter5? Parameter { get; init; }
}
