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
[IsoId("_QanQYQqLEeiboanPnhAdHA")]
[DisplayName("KEK Identifier")]
public partial record KEKIdentifier6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    [IsoId("_QnQlQQqLEeiboanPnhAdHA")]
    [DisplayName("Key Identification")]
    [IsoXmlTag("KeyId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text KeyIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_QnQlQwqLEeiboanPnhAdHA")]
    [DisplayName("Key Version")]
    [IsoXmlTag("KeyVrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? KeyVersion { get; init; } 
    
    /// <summary>
    /// Number of usages of the cryptographic key.
    /// </summary>
    [IsoId("_QnQlRQqLEeiboanPnhAdHA")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Identification used for derivation of a unique key from a master key provided for the data protection.
    /// </summary>
    [IsoId("_QnQlRwqLEeiboanPnhAdHA")]
    [DisplayName("Derivation Identification")]
    [IsoXmlTag("DerivtnId")]
    [IsoSimpleType(IsoSimpleType.Min5Max16Binary)]
    public IsoMin5Max16Binary? DerivationIdentification { get; init; } 
    
    
    #nullable disable
    
}
