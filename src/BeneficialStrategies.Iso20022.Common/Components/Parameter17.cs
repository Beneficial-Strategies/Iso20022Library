// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameter17.
/// </summary>
[IsoId("_0hv94Y-LEe6oobnCtR50kw")]
[DisplayName("Parameter17")]
public partial record Parameter17
{
    #nullable enable

    /// <summary>
    /// Digest Algorithm.
    /// </summary>
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public Algorithm26Code? DigestAlgorithm { get; init; } 

    /// <summary>
    /// Encryption Format.
    /// </summary>
    [DisplayName("Encryption Format")]
    [IsoXmlTag("NcrptnFrmt")]
    public EncryptionFormat2Code? EncryptionFormat { get; init; } 

    /// <summary>
    /// Mask Generator Algorithm.
    /// </summary>
    [DisplayName("Mask Generator Algorithm")]
    [IsoXmlTag("MskGnrtrAlgo")]
    public AlgorithmIdentification34? MaskGeneratorAlgorithm { get; init; } 

    
    #nullable disable
    
}
