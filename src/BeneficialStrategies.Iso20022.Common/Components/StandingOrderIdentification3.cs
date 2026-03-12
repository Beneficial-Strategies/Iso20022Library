// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the elements used to uniquely identify a standing order.
/// </summary>
[IsoId("_790-0aMgEeCJ6YNENx4h-w_-1379161396")]
[DisplayName("Standing Order Identification")]
public partial record StandingOrderIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
    /// </summary>
    [IsoId("_790-0qMgEeCJ6YNENx4h-w_-1404472770")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount24 Account { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_790-06MgEeCJ6YNENx4h-w_2086659832")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    
    
    #nullable disable
    
}
