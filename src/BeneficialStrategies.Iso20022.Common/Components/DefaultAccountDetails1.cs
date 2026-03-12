// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about successor account for automated default funds transfer.
/// </summary>
[IsoId("_7rRPoCDmEeav65mEytrgaA")]
[DisplayName("Default Account Details")]
public partial record DefaultAccountDetails1
{
    #nullable enable
    
    /// <summary>
    /// Account owner identification.
    /// </summary>
    [IsoId("_Q7KfYCDoEeav65mEytrgaA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    
    /// <summary>
    /// Account identification.
    /// </summary>
    [IsoId("_X8ZGcCDoEeav65mEytrgaA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount24 Account { get; init; } 
    
    /// <summary>
    /// Information about time and event fund transfer.
    /// </summary>
    [IsoId("_kgosACc8Eea7avjfd7yDAA")]
    [DisplayName("Daily Fund Transfer")]
    [IsoXmlTag("DalyFndTrf")]
    public DailyFundTransfer1Choice_? DailyFundTransfer { get; init; } 
    
    
    #nullable disable
    
}
