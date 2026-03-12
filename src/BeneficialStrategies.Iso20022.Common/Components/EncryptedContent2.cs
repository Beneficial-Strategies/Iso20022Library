// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key.
/// </summary>
[IsoId("_Z_proQivEeKn9O5oyej_zw")]
[DisplayName("Encrypted Content")]
public partial record EncryptedContent2
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_aLjZoQivEeKn9O5oyej_zw")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; } 
    
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_aLjZpQivEeKn9O5oyej_zw")]
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public required AlgorithmIdentification6 ContentEncryptionAlgorithm { get; init; } 
    
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_aLjZqQivEeKn9O5oyej_zw")]
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public required IsoMax10000Binary EncryptedData { get; init; } 
    
    
    #nullable disable
    
}
