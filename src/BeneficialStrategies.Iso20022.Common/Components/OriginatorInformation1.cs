// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the originator. It is present only if required by the key management algorithm.
/// </summary>
[IsoId("__XpcEOCwEee83LAjB5Kqdw")]
[DisplayName("Originator Information")]
public partial record OriginatorInformation1
{
    #nullable enable
    
    /// <summary>
    /// It may contain originator certificates associated with several different key management algorithms.
    /// </summary>
    [IsoId("_RHj98OCyEee83LAjB5Kqdw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? Certificate { get; init; } 
    
    
    #nullable disable
    
}
