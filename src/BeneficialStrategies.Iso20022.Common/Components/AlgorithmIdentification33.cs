// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Algorithm Identification33.
/// </summary>
[IsoId("_GFUmgY-FEe6oobnCtR50kw")]
[DisplayName("Algorithm Identification33")]
public record AlgorithmIdentification33
{
    /// <summary>
    /// Algorithm.
    /// </summary>
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm29Code Algorithm { get; init; }

    /// <summary>
    /// Parameter.
    /// </summary>
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter16? Parameter { get; init; }
}
