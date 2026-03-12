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
[IsoId("_7-RqwKMgEeCJ6YNENx4h-w_-1377923250")]
[DisplayName("Standing Order Identification")]
public partial record StandingOrderIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_7-RqwaMgEeCJ6YNENx4h-w_-159770283")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
    /// </summary>
    [IsoId("_7-RqwqMgEeCJ6YNENx4h-w_-1549552003")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount24 Account { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_7-Rqw6MgEeCJ6YNENx4h-w_1595290372")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    
    
    #nullable disable
    
}
