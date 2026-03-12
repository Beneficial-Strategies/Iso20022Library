// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Bank account used by a central counterparty to allow for the convenient settlement of obligations between a central counterparty and a clearing member, typically in commercial bank money.
/// </summary>
[IsoId("_gOkuQBXsEeejf-cbr8l5qw")]
[DisplayName("Payment Account")]
public partial record PaymentAccount1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the currency of the account
    /// </summary>
    [IsoId("_ps1YcBXsEeejf-cbr8l5qw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Total value of actual flows to and from clearing members via payment banks in the embedded system in each currency.
    /// </summary>
    [IsoId("_EicI8BXtEeejf-cbr8l5qw")]
    [DisplayName("Net Payment")]
    [IsoXmlTag("NetPmt")]
    public required AmountAndDirection86 NetPayment { get; init; } 
    
    /// <summary>
    /// Number of payment bank account pay‐ins breaching the allowed time between instruction and confirmation. Usage: nil returns to be included for late payment confirmations in all cleared currencies.
    /// </summary>
    [IsoId("_U8pRkBXtEeejf-cbr8l5qw")]
    [DisplayName("Late Payment Confirmation")]
    [IsoXmlTag("LatePmtConf")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public required IsoMax10NumericText LatePaymentConfirmation { get; init; } 
    
    
    #nullable disable
    
}
