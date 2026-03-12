// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
[IsoId("_krtoAWmQEeS7iYydEtv3Ug")]
[DisplayName("Signer")]
public partial record Signer3
{
    #nullable enable
    
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_k49Z0WmQEeS7iYydEtv3Ug")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_k49Z02mQEeS7iYydEtv3Ug")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public Recipient5Choice_? SignerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_k49Z1WmQEeS7iYydEtv3Ug")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification16 DigestAlgorithm { get; init; } 
    
    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_k49Z12mQEeS7iYydEtv3Ug")]
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification17 SignatureAlgorithm { get; init; } 
    
    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_k49Z2WmQEeS7iYydEtv3Ug")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public required IsoMax3000Binary Signature { get; init; } 
    
    
    #nullable disable
    
}
