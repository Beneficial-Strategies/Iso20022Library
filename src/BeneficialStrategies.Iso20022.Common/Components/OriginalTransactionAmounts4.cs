// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the card transaction.
/// </summary>
[IsoId("_asDGcSH4EfCkq6-p7S3J1Q")]
[DisplayName("Original Transaction Amounts4")]
public record OriginalTransactionAmounts4
{
    /// <summary>
    /// Qualifier or type of amount.
    /// </summary>
    [IsoId("_aurjsSH4EfCkq6-p7S3J1Q")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; }

    /// <summary>
    /// Amount of the transaction expressed in the currency of the terminal or as a reversed amount of a previous authorisation.
    /// </summary>
    [IsoId("_aurjsyH4EfCkq6-p7S3J1Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the transaction amount.
    /// </summary>
    [IsoId("_aurjuyH4EfCkq6-p7S3J1Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Amount of the transaction in cardholder billing currency.
    /// </summary>
    [IsoId("_aurjySH4EfCkq6-p7S3J1Q")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; }

    /// <summary>
    /// Currency code of Cardholder and associated with cardholder billing amount.
    /// </summary>
    [IsoId("_aurj0SH4EfCkq6-p7S3J1Q")]
    [DisplayName("Cardholder Billing Currency")]
    [IsoXmlTag("CrdhldrBllgCcy")]
    public ISO3NumericCurrencyCode? CardholderBillingCurrency { get; init; }

    /// <summary>
    /// Effective exchange rate used in the conversion from transaction amount to cardholder billing amount.
    /// </summary>
    [IsoId("_aurj3yH4EfCkq6-p7S3J1Q")]
    [DisplayName("Cardholder Billing Effective Exchange Rate")]
    [IsoXmlTag("CrdhldrBllgFctvXchgRate")]
    public IsoBaseOne25Rate? CardholderBillingEffectiveExchangeRate { get; init; }

    /// <summary>
    /// Amount of the transaction in Reconciliation currency.
    /// </summary>
    [IsoId("_aurj5yH4EfCkq6-p7S3J1Q")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    /// <summary>
    /// Currency code of Reconciliation and associated with Reconciliation amount.
    /// </summary>
    [IsoId("_aurj6SH4EfCkq6-p7S3J1Q")]
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; }

    /// <summary>
    /// Effective exchange rate used in the conversion from transaction amount to reconciliation amount.
    /// </summary>
    [IsoId("_aurj9yH4EfCkq6-p7S3J1Q")]
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; }
}
