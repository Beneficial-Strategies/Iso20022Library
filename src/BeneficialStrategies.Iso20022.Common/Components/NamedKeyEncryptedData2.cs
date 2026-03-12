// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key identified with a name.
/// </summary>
[IsoId("_t4lk8QivEeKn9O5oyej_zw")]
[DisplayName("Named Key Encrypted Data")]
public partial record NamedKeyEncryptedData2
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_uEpD8QivEeKn9O5oyej_zw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Name of the key encryption key (KEK).
    /// </summary>
    [IsoId("_uEpD9QivEeKn9O5oyej_zw")]
    [DisplayName("Key Name")]
    [IsoXmlTag("KeyNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? KeyName { get; init; } 
    
    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_uEpD-QivEeKn9O5oyej_zw")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public required EncryptedContent2 EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
