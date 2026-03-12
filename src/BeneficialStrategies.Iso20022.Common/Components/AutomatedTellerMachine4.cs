// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM information.
/// </summary>
[IsoId("_c6-zIYqsEeSIDtZ76p6McQ")]
[DisplayName("Automated Teller Machine")]
public partial record AutomatedTellerMachine4
{
    #nullable enable
    
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_dIGpIYqsEeSIDtZ76p6McQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_dIGpI4qsEeSIDtZ76p6McQ")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_dIGpJYqsEeSIDtZ76p6McQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    [IsoId("_dIGpJ4qsEeSIDtZ76p6McQ")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_dIGpKYqsEeSIDtZ76p6McQ")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; } 
    
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_dIGpK4qsEeSIDtZ76p6McQ")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; } 
    
    /// <summary>
    /// Capabilities of the ATM terminal performing the transaction.
    /// </summary>
    [IsoId("_dIGpLYqsEeSIDtZ76p6McQ")]
    [DisplayName("Capabilities")]
    [IsoXmlTag("Cpblties")]
    public PointOfInteractionCapabilities5? Capabilities { get; init; } 
    
    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_dIGpL4qsEeSIDtZ76p6McQ")]
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; } 
    
    /// <summary>
    /// List of ATM devices out of service.
    /// </summary>
    [IsoId("_GAjz4IquEeSIDtZ76p6McQ")]
    [DisplayName("Available Device")]
    [IsoXmlTag("AvlblDvc")]
    public ATMDevice2Code? AvailableDevice { get; init; } 
    
    
    #nullable disable
    
}
