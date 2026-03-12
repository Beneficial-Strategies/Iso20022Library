// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements defining the balance details.
/// </summary>
[IsoId("_SYLWU9p-Ed-ak6NoX_4Aeg_-1921961120")]
[DisplayName("Cash Balance")]
public partial record CashBalance1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the nature of a balance, eg, opening booked balance.
    /// </summary>
    [IsoId("_SYLWVNp-Ed-ak6NoX_4Aeg_411546015")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Provides further details on the credit line information.
    /// </summary>
    [IsoId("_SYLWVdp-Ed-ak6NoX_4Aeg_577366369")]
    [DisplayName("Credit Line")]
    [IsoXmlTag("CdtLine")]
    public CreditLine1? CreditLine { get; init; } 
    
    /// <summary>
    /// Currency and amount of money of the cash balance.
    /// </summary>
    [IsoId("_SYLWVtp-Ed-ak6NoX_4Aeg_-1921961008")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance is a credit or a debit balance. A zero balance is considered to be a credit balance.
    /// </summary>
    [IsoId("_SYLWV9p-Ed-ak6NoX_4Aeg_-1921960682")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the date (and time) of the balance.
    /// </summary>
    [IsoId("_SYLWWNp-Ed-ak6NoX_4Aeg_-1921960605")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateAndDateTimeChoice_ Date { get; init; } 
    
    /// <summary>
    /// Set of elements used to indicate when the booked amount of money will become available, ie can be accessed and start generating interest. ||Usage: this type of info is eg used in US, and is linked to particular instruments, such as cheques.|Example: When a cheque is deposited, it will be booked on the deposit day, but the funds will only be accessible as of the indicated availability day (according to national banking regulations).
    /// </summary>
    [IsoId("_SYLWWdp-Ed-ak6NoX_4Aeg_1099826436")]
    [DisplayName("Availability")]
    [IsoXmlTag("Avlbty")]
    public CashBalanceAvailability1? Availability { get; init; } 
    
    
    #nullable disable
    
}
