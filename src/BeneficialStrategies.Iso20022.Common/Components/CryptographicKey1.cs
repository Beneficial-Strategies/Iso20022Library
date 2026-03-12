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
[IsoId("_K8nIQn1DEeCF8NjrBemJWQ_387457534")]
[DisplayName("Cryptographic Key")]
public partial record CryptographicKey1
{
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_K8nIQ31DEeCF8NjrBemJWQ_559775138")]
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
    [IsoId("_K8nIRH1DEeCF8NjrBemJWQ_-1354243077")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_K8nIRX1DEeCF8NjrBemJWQ_-624647251")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Exact10Text)]
    public required IsoExact10Text Version { get; init; } 
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_K8nIRn1DEeCF8NjrBemJWQ_-2129184862")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CryptographicKeyType1Code? Type { get; init; } 
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_K8nIR31DEeCF8NjrBemJWQ_-756931989")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = new SimpleValueList<KeyUsage1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _K8nIR31DEeCF8NjrBemJWQ_-756931989
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_K8nISH1DEeCF8NjrBemJWQ_838743499")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_K8nISX1DEeCF8NjrBemJWQ_1414724439")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; } 
    
    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    [IsoId("_K8wSMH1DEeCF8NjrBemJWQ_-1603310801")]
    [DisplayName("Key Value")]
    [IsoXmlTag("KeyVal")]
    public required ContentInformationType2 KeyValue { get; init; } 
    
    
    #nullable disable
    
}
