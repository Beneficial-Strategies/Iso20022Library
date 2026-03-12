// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a key encryption key (KEK), using previously distributed symmetric key.
/// </summary>
[IsoId("_TNujQVEyEeyApZmLzm74zA")]
[DisplayName("KEK Identifier")]
public partial record KEKIdentifier7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    [IsoId("_TT6q0VEyEeyApZmLzm74zA")]
    [DisplayName("Key Identification")]
    [IsoXmlTag("KeyId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text KeyIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_TT6q01EyEeyApZmLzm74zA")]
    [DisplayName("Key Version")]
    [IsoXmlTag("KeyVrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text KeyVersion { get; init; } 
    
    /// <summary>
    /// Number of usages of the cryptographic key.
    /// </summary>
    [IsoId("_TT6q1VEyEeyApZmLzm74zA")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Identification used for derivation of a unique key from a master key provided for the data protection.
    /// </summary>
    [IsoId("_TT6q11EyEeyApZmLzm74zA")]
    [DisplayName("Derivation Identification")]
    [IsoXmlTag("DerivtnId")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public IsoMax500Binary? DerivationIdentification { get; init; } 
    
    
    #nullable disable
    
}
