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
[IsoId("_obBZsYtuEeSLQutgI1Ulfw")]
[DisplayName("Automated Teller Machine")]
public partial record AutomatedTellerMachine8
{
    #nullable enable
    
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_on_esYtuEeSLQutgI1Ulfw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_on_es4tuEeSLQutgI1Ulfw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_on_etYtuEeSLQutgI1Ulfw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; } 
    
    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    [IsoId("_on_et4tuEeSLQutgI1Ulfw")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_on_euYtuEeSLQutgI1Ulfw")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public PostalAddress17? Location { get; init; } 
    
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_on_eu4tuEeSLQutgI1Ulfw")]
    [DisplayName("Location Category")]
    [IsoXmlTag("LctnCtgy")]
    public TransactionEnvironment2Code? LocationCategory { get; init; } 
    
    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_on_evYtuEeSLQutgI1Ulfw")]
    [DisplayName("Equipment")]
    [IsoXmlTag("Eqpmnt")]
    public ATMEquipment1? Equipment { get; init; } 
    
    
    #nullable disable
    
}
