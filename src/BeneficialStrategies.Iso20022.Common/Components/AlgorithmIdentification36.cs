// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Algorithm Identification36.
/// </summary>
[IsoId("_JCWzUJWvEe6FeYYOKs6hxw")]
[DisplayName("Algorithm Identification36")]
public partial record AlgorithmIdentification36
{
    #nullable enable

    /// <summary>
    /// Algorithm.
    /// </summary>
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    public required Algorithm26Code Algorithm { get; init; } 

    
    #nullable disable
    
}
