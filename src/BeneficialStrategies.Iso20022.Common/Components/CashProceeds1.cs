// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash proceeds.
/// </summary>
[IsoId("_UP1bhtp-Ed-ak6NoX_4Aeg_1953970402")]
[DisplayName("Cash Proceeds")]
public partial record CashProceeds1
{
    #nullable enable
    
    /// <summary>
    /// Cash amount which is posted.
    /// </summary>
    [IsoId("_UP1bh9p-Ed-ak6NoX_4Aeg_1291538706")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; } 
    
    /// <summary>
    /// Reconciliation information.
    /// </summary>
    [IsoId("_UP1biNp-Ed-ak6NoX_4Aeg_1379272721")]
    [DisplayName("Reconciliation Details")]
    [IsoXmlTag("RcncltnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ReconciliationDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the debited securities account.
    /// </summary>
    [IsoId("_UP1bidp-Ed-ak6NoX_4Aeg_-876446591")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CashAccount19> AccountDetails { get; init; } = new ValueList<CashAccount19>(){};
    
    
    #nullable disable
    
}
