// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_kbGu1dL8EeSDLevdaFPXHw")]
[DisplayName("Registered Contract")]
public partial record RegisteredContract2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract closure.
    /// </summary>
    [IsoId("_MFbuwdOcEeS75MhTUaTyUQ")]
    [DisplayName("Registered Contract Closure Identification")]
    [IsoXmlTag("RegdCtrctClsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; } 
    
    /// <summary>
    /// Party who registered the currency control contract.
    /// </summary>
    [IsoId("_zhVz8gq8EeWD-cmAqruRjw")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty2 ReportingParty { get; init; } 
    
    /// <summary>
    /// Agent who registered the currency control contract.
    /// </summary>
    [IsoId("_zhVz8wq8EeWD-cmAqruRjw")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    
    /// <summary>
    /// Original registered contract identification.
    /// </summary>
    [IsoId("_kbGu2NL8EeSDLevdaFPXHw")]
    [DisplayName("Original Registered Contract")]
    [IsoXmlTag("OrgnlRegdCtrct")]
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    
    /// <summary>
    /// Priority of the registered contract closure.
    /// </summary>
    [IsoId("_4AhPMNL8EeSDLevdaFPXHw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public required Priority2Code Priority { get; init; } 
    
    /// <summary>
    /// Reason of the closure.
    /// </summary>
    [IsoId("_kbGu19L8EeSDLevdaFPXHw")]
    [DisplayName("Closure Reason")]
    [IsoXmlTag("ClsrRsn")]
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_8FIT4dObEeS75MhTUaTyUQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
