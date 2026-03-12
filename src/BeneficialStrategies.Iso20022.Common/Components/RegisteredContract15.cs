// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_KS3KYbb9Eeu9Cp6InX88Vw")]
[DisplayName("Registered Contract")]
public partial record RegisteredContract15
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract closure.
    /// </summary>
    [IsoId("_KUN1Qbb9Eeu9Cp6InX88Vw")]
    [DisplayName("Registered Contract Closure Identification")]
    [IsoXmlTag("RegdCtrctClsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; } 
    
    /// <summary>
    /// Party who registered the currency control contract.
    /// </summary>
    [IsoId("_KUOcV7b9Eeu9Cp6InX88Vw")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; } 
    
    /// <summary>
    /// Agent who registered the currency control contract.
    /// </summary>
    [IsoId("_KUOcWbb9Eeu9Cp6InX88Vw")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    
    /// <summary>
    /// Original registered contract identification.
    /// </summary>
    [IsoId("_KUOcW7b9Eeu9Cp6InX88Vw")]
    [DisplayName("Original Registered Contract")]
    [IsoXmlTag("OrgnlRegdCtrct")]
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    
    /// <summary>
    /// Priority of the registered contract closure.
    /// </summary>
    [IsoId("_KUOcY7b9Eeu9Cp6InX88Vw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; } 
    
    /// <summary>
    /// Reason of the closure.
    /// </summary>
    [IsoId("_KUOcZbb9Eeu9Cp6InX88Vw")]
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    
    /// <summary>
    /// Contract cession details.
    /// </summary>
    [IsoId("_kmRMwLb9Eeu9Cp6InX88Vw")]
    [DisplayName("Cession")]
    [IsoXmlTag("Cssn")]
    public ContractCessionData1? Cession { get; init; } 
    
    /// <summary>
    /// Documents provided as attachments to the contract registration closure request.
    /// </summary>
    [IsoId("_XWoJYLcCEeu9Cp6InX88Vw")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public DocumentGeneralInformation5? Attachment { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KUOcZ7b9Eeu9Cp6InX88Vw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
