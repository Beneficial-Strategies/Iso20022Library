// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key.
/// </summary>
[IsoId("_7YnJMdtWEee9e6xduATmQg")]
[DisplayName("Cryptographic Key")]
public partial record CryptographicKey13
{
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_7hfYYdtWEee9e6xduATmQg")]
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
    [IsoId("_7hfYY9tWEee9e6xduATmQg")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_7hfYZdtWEee9e6xduATmQg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_7hfYZ9tWEee9e6xduATmQg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType3Code? Type { get; init; } 
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_7hfYadtWEee9e6xduATmQg")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public KeyUsage1Code? Function { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_7hfYa9tWEee9e6xduATmQg")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_7hfYbdtWEee9e6xduATmQg")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; } 
    
    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    [IsoId("_7hfYb9tWEee9e6xduATmQg")]
    [DisplayName("Key Value")]
    [IsoXmlTag("KeyVal")]
    public ContentInformationType19? KeyValue { get; init; } 
    
    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_xWAQANv_EeeKpa-yxjuKzQ")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    
    /// <summary>
    /// Additional Information needed by the receiver to securely process the management of the security element.
    /// </summary>
    [IsoId("_xzO9kNwKEeeKpa-yxjuKzQ")]
    [DisplayName("Additional Management Information")]
    [IsoXmlTag("AddtlMgmtInf")]
    public GenericInformation1? AdditionalManagementInformation { get; init; } 
    
    
    #nullable disable
    
}
