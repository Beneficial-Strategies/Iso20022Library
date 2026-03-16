// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Algorithm Identification31.
/// </summary>
[IsoId("_hn1SkY-AEe6oobnCtR50kw")]
[DisplayName("Algorithm Identification31")]
public partial record AlgorithmIdentification31
{
    #nullable enable

    /// <summary>
    /// Algorithm.
    /// </summary>
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm27Code Algorithm { get; init; } 

    /// <summary>
    /// Parameter.
    /// </summary>
    [DisplayName("Parameter")]
    [IsoXmlTag("Param")]
    public Parameter7? Parameter { get; init; } 

    
    #nullable disable
    
}
