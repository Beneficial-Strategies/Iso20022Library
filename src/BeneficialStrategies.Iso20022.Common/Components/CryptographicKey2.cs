// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key to exchange.
/// </summary>
[IsoId("_VOuXYQvdEeK9Xewg3qiFQA")]
[DisplayName("Cryptographic Key")]
public partial record CryptographicKey2
{
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_VaoFYQvdEeK9Xewg3qiFQA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Identification { get; init; } 
    
    /// <summary>
    /// Additional identification of the key.
    /// Usage
    /// For derived unique key per transaction (DUKPT) keys, the key serial number (KSN) with the 21 bits of the transaction counter set to zero.
    /// </summary>
    [IsoId("_VaoFZQvdEeK9Xewg3qiFQA")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_VaoFaQvdEeK9Xewg3qiFQA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Exact10Text)]
    public required IsoExact10Text Version { get; init; } 
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_VaoFbQvdEeK9Xewg3qiFQA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType2Code? Type { get; init; } 
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_VaoFcQvdEeK9Xewg3qiFQA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = new SimpleValueList<KeyUsage1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VaoFcQvdEeK9Xewg3qiFQA
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_VaoFdQvdEeK9Xewg3qiFQA")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_VaoFeQvdEeK9Xewg3qiFQA")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; } 
    
    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    [IsoId("_VaoFfQvdEeK9Xewg3qiFQA")]
    [DisplayName("Key Value")]
    [IsoXmlTag("KeyVal")]
    public required ContentInformationType5 KeyValue { get; init; } 
    
    
    #nullable disable
    
}
