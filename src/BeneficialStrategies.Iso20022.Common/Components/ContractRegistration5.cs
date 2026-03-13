// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control contract registration details.
/// </summary>
[IsoId("_tWwUwbGIEeuSTr8k0UEM8A")]
[DisplayName("Contract Registration")]
public partial record ContractRegistration5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the contract registration.
    /// </summary>
    [IsoId("_tYjEgbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Registration Identification")]
    [IsoXmlTag("CtrctRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ContractRegistrationIdentification { get; init; } 
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_tYjEg7GIEeuSTr8k0UEM8A")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; } 
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_tYjEhbGIEeuSTr8k0UEM8A")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    
    /// <summary>
    /// Details about the opening of the contract registration.
    /// </summary>
    [IsoId("_tYjEh7GIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Registration Opening")]
    [IsoXmlTag("CtrctRegnOpng")]
    public ValueList<ContractRegistration6> ContractRegistrationOpening { get; init; } = [];
    // ID for the above is _tYjEh7GIEeuSTr8k0UEM8A
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_tYjEj7GIEeuSTr8k0UEM8A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
