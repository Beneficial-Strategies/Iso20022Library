// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic key.
/// </summary>
[IsoId("_47wD8bTwEeeQy4o2AayYHg")]
[DisplayName("Cryptographic Key")]
public partial record CryptographicKey12
{
    #nullable enable
    
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_5EX0cbTwEeeQy4o2AayYHg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_5EX0c7TwEeeQy4o2AayYHg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Identification { get; init; } 
    
    /// <summary>
    /// Identification of the security domain.
    /// </summary>
    [IsoId("_5EX0dbTwEeeQy4o2AayYHg")]
    [DisplayName("Security Domain Identification")]
    [IsoXmlTag("SctyDomnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecurityDomainIdentification { get; init; } 
    
    /// <summary>
    /// Additional identification of the key, for instance to derive the key.
    /// </summary>
    [IsoId("_5EX0d7TwEeeQy4o2AayYHg")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_5EX0ebTwEeeQy4o2AayYHg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; } 
    
    /// <summary>
    /// Sequence counter of the cryptographic key.
    /// </summary>
    [IsoId("_5EX0e7TwEeeQy4o2AayYHg")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_5EX0fbTwEeeQy4o2AayYHg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType3Code? Type { get; init; } 
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_5EX0f7TwEeeQy4o2AayYHg")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public KeyUsage1Code? Function { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_5EX0gbTwEeeQy4o2AayYHg")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_5EX0g7TwEeeQy4o2AayYHg")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; } 
    
    /// <summary>
    /// Value for checking a cryptographic key.
    /// </summary>
    [IsoId("_5EX0hbTwEeeQy4o2AayYHg")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    
    /// <summary>
    /// Value of the public component of a RSA key.
    /// </summary>
    [IsoId("_5EX0h7TwEeeQy4o2AayYHg")]
    [DisplayName("Public Key Value")]
    [IsoXmlTag("PblcKeyVal")]
    public PublicRSAKey1? PublicKeyValue { get; init; } 
    
    /// <summary>
    /// Element containing the key information.
    /// </summary>
    [IsoId("_5EX0ibTwEeeQy4o2AayYHg")]
    [DisplayName("Key Choice Value")]
    [IsoXmlTag("KeyChcVal")]
    public KeyChoiceValue2_? KeyChoiceValue { get; init; } 
    
    
    #nullable disable
    
}
