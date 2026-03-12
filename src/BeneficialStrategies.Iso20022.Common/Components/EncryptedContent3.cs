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
[IsoId("_tsmQMWjAEeSP8Z8nx8HTuQ")]
[DisplayName("Encrypted Content")]
public partial record EncryptedContent3
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_t6HHwWjAEeSP8Z8nx8HTuQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; } 
    
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_t6HHw2jAEeSP8Z8nx8HTuQ")]
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public required AlgorithmIdentification14 ContentEncryptionAlgorithm { get; init; } 
    
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_t6HHxWjAEeSP8Z8nx8HTuQ")]
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public required IsoMax100KBinary EncryptedData { get; init; } 
    
    
    #nullable disable
    
}
