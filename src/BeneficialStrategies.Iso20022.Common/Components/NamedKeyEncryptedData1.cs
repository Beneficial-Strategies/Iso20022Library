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
[IsoId("_SwZI2gEcEeCQm6a_G2yO_w_-2092707437")]
[DisplayName("Named Key Encrypted Data")]
public partial record NamedKeyEncryptedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SwZI2wEcEeCQm6a_G2yO_w_-1898151729")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Name of the key encryption key (KEK).
    /// </summary>
    [IsoId("_SwZI3AEcEeCQm6a_G2yO_w_1298991585")]
    [DisplayName("Key Name")]
    [IsoXmlTag("KeyNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? KeyName { get; init; } 
    
    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_SwZI3QEcEeCQm6a_G2yO_w_1945917672")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public required EncryptedContent1 EncryptedContent { get; init; } 
    
    
    #nullable disable
    
}
