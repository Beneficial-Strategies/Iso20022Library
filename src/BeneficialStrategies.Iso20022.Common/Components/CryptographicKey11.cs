// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic Key component.
/// </summary>
[IsoId("_Dfc_ILTkEeeQy4o2AayYHg")]
[DisplayName("Cryptographic Key")]
public partial record CryptographicKey11
{
    #nullable enable
    
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_DozvcbTkEeeQy4o2AayYHg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_Dozvc7TkEeeQy4o2AayYHg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Identification { get; init; } 
    
    /// <summary>
    /// Identification of the security domain.
    /// </summary>
    [IsoId("_DozvdbTkEeeQy4o2AayYHg")]
    [DisplayName("Security Domain Identification")]
    [IsoXmlTag("SctyDomnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecurityDomainIdentification { get; init; } 
    
    /// <summary>
    /// Additional identification of the key, for instance to derive the key.
    /// </summary>
    [IsoId("_Dozvd7TkEeeQy4o2AayYHg")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_DozvebTkEeeQy4o2AayYHg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Version { get; init; } 
    
    /// <summary>
    /// Sequence counter of the cryptographic key.
    /// </summary>
    [IsoId("_Dozve7TkEeeQy4o2AayYHg")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceCounter { get; init; } 
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_DozvfbTkEeeQy4o2AayYHg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CryptographicKeyType3Code Type { get; init; } 
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_Dozvf7TkEeeQy4o2AayYHg")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = [];
    // ID for the above is _Dozvf7TkEeeQy4o2AayYHg
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_DozvgbTkEeeQy4o2AayYHg")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ActivationDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_Dozvg7TkEeeQy4o2AayYHg")]
    [DisplayName("Deactivation Date")]
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DeactivationDate { get; init; } 
    
    /// <summary>
    /// Value for checking a cryptographic key.
    /// </summary>
    [IsoId("_DozvhbTkEeeQy4o2AayYHg")]
    [DisplayName("Key Check Value")]
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    
    /// <summary>
    /// Current status of the key.
    /// </summary>
    [IsoId("_Dozvh7TkEeeQy4o2AayYHg")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required ATMStatus3Code CurrentStatus { get; init; } 
    
    /// <summary>
    /// Reason for which the key has been stopped.
    /// </summary>
    [IsoId("_DozvibTkEeeQy4o2AayYHg")]
    [DisplayName("Failure Reason")]
    [IsoXmlTag("FailrRsn")]
    public FailureReason6Code? FailureReason { get; init; } 
    
    
    #nullable disable
    
}
