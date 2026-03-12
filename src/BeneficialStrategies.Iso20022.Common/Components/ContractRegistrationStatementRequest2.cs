// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the statement requested elements.
/// </summary>
[IsoId("_Nl-rYW49EeiU9cctagi5ow")]
[DisplayName("Contract Registration Statement Request")]
public partial record ContractRegistrationStatementRequest2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the contract registration statement request.
    /// </summary>
    [IsoId("_NvhB4W49EeiU9cctagi5ow")]
    [DisplayName("Statement Request Identification")]
    [IsoXmlTag("StmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text StatementRequestIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the period for which the statement is requested.
    /// </summary>
    [IsoId("_NvhB4249EeiU9cctagi5ow")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required ReportingPeriod4 ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_NvhB5W49EeiU9cctagi5ow")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; } 
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_NvhB5249EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    
    /// <summary>
    /// Identifies the requested registered contract.
    /// </summary>
    [IsoId("_NvhB6W49EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Identification")]
    [IsoXmlTag("RegdCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RegisteredContractIdentification { get; init; } 
    
    /// <summary>
    /// Defines the criteria to be returned in the statement in response to the request.
    /// </summary>
    [IsoId("_NvhB8W49EeiU9cctagi5ow")]
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public ContractRegistrationStatementCriteria1? ReturnCriteria { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_NvhB8249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
