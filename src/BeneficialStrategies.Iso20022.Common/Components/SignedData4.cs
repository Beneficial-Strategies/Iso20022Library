// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signatures of data from one or several signers.
/// </summary>
[IsoId("_c-zcIWmPEeS7iYydEtv3Ug")]
[DisplayName("Signed Data")]
public partial record SignedData4
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_dL4O0WmPEeS7iYydEtv3Ug")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Identification of digest algorithm applied before signature.
    /// </summary>
    [IsoId("_dL4O02mPEeS7iYydEtv3Ug")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification16> DigestAlgorithm { get; init; } = new ValueList<AlgorithmIdentification16>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _dL4O02mPEeS7iYydEtv3Ug
    
    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_dL4O1WmPEeS7iYydEtv3Ug")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_dL4O12mPEeS7iYydEtv3Ug")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? Certificate { get; init; } 
    
    /// <summary>
    /// Digital signature and identification of a signer.
    /// </summary>
    [IsoId("_dL4O2WmPEeS7iYydEtv3Ug")]
    [DisplayName("Signer")]
    [IsoXmlTag("Sgnr")]
    public ValueList<Signer3> Signer { get; init; } = new ValueList<Signer3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _dL4O2WmPEeS7iYydEtv3Ug
    
    
    #nullable disable
    
}
