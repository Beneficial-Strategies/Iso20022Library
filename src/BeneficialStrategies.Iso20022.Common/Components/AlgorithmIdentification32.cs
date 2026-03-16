// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Algorithm Identification32.
/// </summary>
[IsoId("_hKFxMY-BEe6oobnCtR50kw")]
[DisplayName("Algorithm Identification32")]
public record AlgorithmIdentification32
{
    /// <summary>
    /// Algorithm.
    /// </summary>
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm28Code Algorithm { get; init; }

    /// <summary>
    /// Parameter.
    /// </summary>
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter12? Parameter { get; init; }
}
