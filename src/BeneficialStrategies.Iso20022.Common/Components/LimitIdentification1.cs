// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the identification details to uniquely identify a limit within the system.
/// </summary>
[IsoId("_79PI8aMgEeCJ6YNENx4h-w_730901350")]
[DisplayName("Limit Identification")]
public partial record LimitIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [IsoId("_79PI8qMgEeCJ6YNENx4h-w_1960983168")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_79PI86MgEeCJ6YNENx4h-w_-340171683")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    [IsoId("_79PI9KMgEeCJ6YNENx4h-w_200278245")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LimitType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_79PI9aMgEeCJ6YNENx4h-w_688763835")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_79PI9qMgEeCJ6YNENx4h-w_878107001")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
