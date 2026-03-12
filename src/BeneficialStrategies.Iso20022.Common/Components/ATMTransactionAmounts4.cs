// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal limits for the account.
/// </summary>
[IsoId("_umPyoYq6EeSHjtO_wHA7PQ")]
[DisplayName("ATM Transaction Amounts")]
public partial record ATMTransactionAmounts4
{
    #nullable enable
    
    /// <summary>
    /// True if limits may be displayed on the ATM to the customer.
    /// </summary>
    [IsoId("__XeUIIq6EeSHjtO_wHA7PQ")]
    [DisplayName("Display Flag")]
    [IsoXmlTag("DispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DisplayFlag { get; init; } 
    
    /// <summary>
    /// Amount available for withdrawal on the account.
    /// </summary>
    [IsoId("_uzXBl4q6EeSHjtO_wHA7PQ")]
    [DisplayName("Available Amount")]
    [IsoXmlTag("AvlblAmt")]
    public ImpliedCurrencyAndAmount? AvailableAmount { get; init; } 
    
    /// <summary>
    /// Remaining daily amount of the customer totals for withdrawals on the account.
    /// </summary>
    [IsoId("_uzXBmYq6EeSHjtO_wHA7PQ")]
    [DisplayName("Daily Balance")]
    [IsoXmlTag("DalyBal")]
    public DetailedAmount4? DailyBalance { get; init; } 
    
    /// <summary>
    /// Remaining weekly amount of the customer totals for withdrawals on the account.
    /// </summary>
    [IsoId("_uzXBm4q6EeSHjtO_wHA7PQ")]
    [DisplayName("Weekly Balance")]
    [IsoXmlTag("WklyBal")]
    public DetailedAmount4? WeeklyBalance { get; init; } 
    
    /// <summary>
    /// Remaining monthly amount of the customer totals for withdrawals on the account.
    /// </summary>
    [IsoId("_uzXBnYq6EeSHjtO_wHA7PQ")]
    [DisplayName("Monthly Balance")]
    [IsoXmlTag("MnthlyBal")]
    public DetailedAmount4? MonthlyBalance { get; init; } 
    
    
    #nullable disable
    
}
