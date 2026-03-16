// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract Registration Statement Request3.
/// </summary>
[IsoId("_2zxE8TEyEe6g-ffJsqGiSA")]
[DisplayName("Contract Registration Statement Request3")]
public partial record ContractRegistrationStatementRequest3
{
    #nullable enable

    /// <summary>
    /// Registered Contract Identification.
    /// </summary>
    [DisplayName("Registered Contract Identification")]
    [IsoXmlTag("RegdCtrctId")]
    public required IsoMax35Text RegisteredContractIdentification { get; init; } 

    /// <summary>
    /// Registration Agent.
    /// </summary>
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification8 RegistrationAgent { get; init; } 

    /// <summary>
    /// Reporting Party.
    /// </summary>
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty6 ReportingParty { get; init; } 

    /// <summary>
    /// Reporting Period.
    /// </summary>
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required ReportingPeriod4 ReportingPeriod { get; init; } 

    /// <summary>
    /// Return Criteria.
    /// </summary>
    [DisplayName("Return Criteria")]
    [IsoXmlTag("RtrCrit")]
    public ContractRegistrationStatementCriteria1? ReturnCriteria { get; init; } 

    /// <summary>
    /// Statement Request Identification.
    /// </summary>
    [DisplayName("Statement Request Identification")]
    [IsoXmlTag("StmtReqId")]
    public required IsoMax35Text StatementRequestIdentification { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    
    #nullable disable
    
}
