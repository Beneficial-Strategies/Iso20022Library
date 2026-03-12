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
[IsoId("_SwiSxQEcEeCQm6a_G2yO_w_423305328")]
[DisplayName("Signed Data")]
public partial record SignedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SwiSxgEcEeCQm6a_G2yO_w_877392597")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_SwiSxwEcEeCQm6a_G2yO_w_569453236")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification1> DigestAlgorithm { get; init; } = new ValueList<AlgorithmIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SwiSxwEcEeCQm6a_G2yO_w_569453236
    
    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_SwiSyAEcEeCQm6a_G2yO_w_251676575")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_SwiSyQEcEeCQm6a_G2yO_w_-997515130")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? Certificate { get; init; } 
    
    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    [IsoId("_SwiSygEcEeCQm6a_G2yO_w_-1329278332")]
    [DisplayName("Signer")]
    [IsoXmlTag("Sgnr")]
    public ValueList<Signer1> Signer { get; init; } = new ValueList<Signer1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SwiSygEcEeCQm6a_G2yO_w_-1329278332
    
    
    #nullable disable
    
}
