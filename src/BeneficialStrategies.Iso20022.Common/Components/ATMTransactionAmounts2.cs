// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit of amounts for the customer.
/// </summary>
[IsoId("_OR7VUIp7EeS3NqNpgnMh2w")]
[DisplayName("ATM Transaction Amounts")]
public partial record ATMTransactionAmounts2
{
    #nullable enable
    
    /// <summary>
    /// Currency of the limits, if different from the requested amount.
    /// </summary>
    [IsoId("_dck6kIp7EeS3NqNpgnMh2w")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Maximum amount allowed in the authorised currency if the withdrawal was not approved.
    /// </summary>
    [IsoId("_h2EDUIp7EeS3NqNpgnMh2w")]
    [DisplayName("Maximum Authorisable Amount")]
    [IsoXmlTag("MaxAuthsbAmt")]
    public ImpliedCurrencyAndAmount? MaximumAuthorisableAmount { get; init; } 
    
    /// <summary>
    /// Minimum amount allowed for a withdrawal in the authorised currency.
    /// </summary>
    [IsoId("_lZwMgIp7EeS3NqNpgnMh2w")]
    [DisplayName("Minimum Allowed Amount")]
    [IsoXmlTag("MinAllwdAmt")]
    public ImpliedCurrencyAndAmount? MinimumAllowedAmount { get; init; } 
    
    /// <summary>
    /// Maximum amount allowed for a withdrawal in the authorised currency.
    /// </summary>
    [IsoId("_oWjU0Ip7EeS3NqNpgnMh2w")]
    [DisplayName("Maximum Allowed Amount")]
    [IsoXmlTag("MaxAllwdAmt")]
    public ImpliedCurrencyAndAmount? MaximumAllowedAmount { get; init; } 
    
    /// <summary>
    /// Remaining daily amount of the customer totals after the withdrawal.
    /// </summary>
    [IsoId("_q-fncIp7EeS3NqNpgnMh2w")]
    [DisplayName("Daily Balance")]
    [IsoXmlTag("DalyBal")]
    public DetailedAmount4? DailyBalance { get; init; } 
    
    /// <summary>
    /// Remaining weekly amount of the customer totals after the withdrawal.
    /// </summary>
    [IsoId("_tYRiQIp7EeS3NqNpgnMh2w")]
    [DisplayName("Weekly Balance")]
    [IsoXmlTag("WklyBal")]
    public DetailedAmount4? WeeklyBalance { get; init; } 
    
    /// <summary>
    /// Remaining monthly amount of the customer totals after the withdrawal.
    /// </summary>
    [IsoId("_vXmVsIp7EeS3NqNpgnMh2w")]
    [DisplayName("Monthly Balance")]
    [IsoXmlTag("MnthlyBal")]
    public DetailedAmount4? MonthlyBalance { get; init; } 
    
    
    #nullable disable
    
}
