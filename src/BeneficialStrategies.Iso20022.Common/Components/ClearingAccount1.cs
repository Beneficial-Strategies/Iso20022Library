// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct of a central counterparty that defines the relationship between collateral, margin and position accounts and upon default of a clearing member defines the segregation of losses on positions and assets held in such accounts.
/// </summary>
[IsoId("_zZQ3oZXeEeaEh9L5Y0ZaKQ")]
[DisplayName("Clearing Account")]
public partial record ClearingAccount1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the type of clearing account.
    /// </summary>
    [IsoId("_4qXrUKsbEeayv9XxdmMwKQ")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public required ClearingAccountType3Code AccountType { get; init; } 
    
    /// <summary>
    /// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
    /// </summary>
    [IsoId("_fXQ-0HX_Eee_qcLXasnA4g")]
    [DisplayName("Collateral Account Owner")]
    [IsoXmlTag("CollAcctOwnr")]
    public ValueList<CollateralAccount5> CollateralAccountOwner { get; init; } = [];
    // ID for the above is _fXQ-0HX_Eee_qcLXasnA4g
    
    
    #nullable disable
    
}
