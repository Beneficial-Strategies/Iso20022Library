// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifiers of account and account owner.
/// </summary>
[IsoId("_2rrW4CDrEeav65mEytrgaA")]
[DisplayName("Account Owner And Identification")]
public partial record AccountOwnerAndIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Account identifier.
    /// </summary>
    [IsoId("_UhRGkCDsEeav65mEytrgaA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required CashAccount24 Account { get; init; } 
    
    /// <summary>
    /// Account owner identification.
    /// </summary>
    [IsoId("_eOrnECDsEeav65mEytrgaA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    
    
    #nullable disable
    
}
