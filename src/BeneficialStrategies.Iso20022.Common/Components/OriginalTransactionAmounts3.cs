// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Transaction Amounts3.
/// </summary>
[IsoId("_-zs7IW3nEe6dwbOqHXrHWg")]
[DisplayName("Original Transaction Amounts3")]
public partial record OriginalTransactionAmounts3
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Amount Qualifier.
    /// </summary>
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; } 

    /// <summary>
    /// Cardholder Billing Amount.
    /// </summary>
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; } 

    /// <summary>
    /// Cardholder Billing Currency.
    /// </summary>
    [DisplayName("Cardholder Billing Currency")]
    [IsoXmlTag("CrdhldrBllgCcy")]
    public ISO3NumericCurrencyCode? CardholderBillingCurrency { get; init; } 

    /// <summary>
    /// Cardholder Billing Effective Exchange Rate.
    /// </summary>
    [DisplayName("Cardholder Billing Effective Exchange Rate")]
    [IsoXmlTag("CrdhldrBllgFctvXchgRate")]
    public IsoBaseOne25Rate? CardholderBillingEffectiveExchangeRate { get; init; } 

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ISO3NumericCurrencyCode Currency { get; init; } 

    /// <summary>
    /// Reconciliation Amount.
    /// </summary>
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; } 

    /// <summary>
    /// Reconciliation Currency.
    /// </summary>
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; } 

    /// <summary>
    /// Reconciliation Effective Exchange Rate.
    /// </summary>
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; } 

    
    #nullable disable
    
}
