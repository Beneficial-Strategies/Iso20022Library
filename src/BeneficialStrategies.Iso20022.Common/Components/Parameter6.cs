// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters associated to a cryptographic encryption algorithm.
/// </summary>
[IsoId("_jKs7kWi8EeS87LmvcA55sg")]
[DisplayName("Parameter")]
public partial record Parameter6
{
    #nullable enable
    
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_1Fd4AGi8EeS87LmvcA55sg")]
    [DisplayName("Encryption Format")]
    [IsoXmlTag("NcrptnFrmt")]
    public EncryptionFormat1Code? EncryptionFormat { get; init; } 
    
    /// <summary>
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    [IsoId("_jXzjcWi8EeS87LmvcA55sg")]
    [DisplayName("Initialisation Vector")]
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public IsoMax500Binary? InitialisationVector { get; init; } 
    
    /// <summary>
    /// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
    /// </summary>
    [IsoId("_67hP8Gi9EeS87LmvcA55sg")]
    [DisplayName("Byte Padding")]
    [IsoXmlTag("BPddg")]
    public BytePadding1Code? BytePadding { get; init; } 
    
    
    #nullable disable
    
}
