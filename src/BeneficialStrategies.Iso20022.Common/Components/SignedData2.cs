// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signature of data, with an asymmetric key.
/// </summary>
[IsoId("_HkKvIQisEeKn9O5oyej_zw")]
[DisplayName("Signed Data")]
public partial record SignedData2
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_HwhJEQisEeKn9O5oyej_zw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_HwhJFQisEeKn9O5oyej_zw")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification5> DigestAlgorithm { get; init; } = new ValueList<AlgorithmIdentification5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _HwhJFQisEeKn9O5oyej_zw
    
    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_HwhJGQisEeKn9O5oyej_zw")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_HwhJHQisEeKn9O5oyej_zw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? Certificate { get; init; } 
    
    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    [IsoId("_HwhJIQisEeKn9O5oyej_zw")]
    [DisplayName("Signer")]
    [IsoXmlTag("Sgnr")]
    public ValueList<Signer2> Signer { get; init; } = new ValueList<Signer2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _HwhJIQisEeKn9O5oyej_zw
    
    
    #nullable disable
    
}
