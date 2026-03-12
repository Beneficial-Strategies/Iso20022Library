// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
[IsoId("_Dob-MR6iEeOolf0-cMYhrw")]
[DisplayName("Cash Account")]
public partial record CashAccount29
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_D_WpYx6iEeOolf0-cMYhrw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccountIdentification1Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    [IsoId("_D_WpZR6iEeOolf0-cMYhrw")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public FinancialInstitutionIdentification3Choice_? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
