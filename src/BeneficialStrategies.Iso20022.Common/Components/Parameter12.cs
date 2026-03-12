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
[IsoId("_McDMUdtoEee9e6xduATmQg")]
[DisplayName("Parameter")]
public partial record Parameter12
{
    #nullable enable
    
    /// <summary>
    /// Format of data before encryption, if the format is not plaintext or implicit.
    /// </summary>
    [IsoId("_MlYHcdtoEee9e6xduATmQg")]
    [DisplayName("Encryption Format")]
    [IsoXmlTag("NcrptnFrmt")]
    public EncryptionFormat2Code? EncryptionFormat { get; init; } 
    
    /// <summary>
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    [IsoId("_MlYHc9toEee9e6xduATmQg")]
    [DisplayName("Initialisation Vector")]
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public IsoMax500Binary? InitialisationVector { get; init; } 
    
    /// <summary>
    /// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
    /// </summary>
    [IsoId("_MlYHddtoEee9e6xduATmQg")]
    [DisplayName("Byte Padding")]
    [IsoXmlTag("BPddg")]
    public BytePadding1Code? BytePadding { get; init; } 
    
    
    #nullable disable
    
}
