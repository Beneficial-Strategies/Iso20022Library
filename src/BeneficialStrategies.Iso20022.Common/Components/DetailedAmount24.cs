// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_5qbWAWl8EfCyxsm1jzUNug")]
[DisplayName("Detailed Amount24")]
public record DetailedAmount24
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_5s1w0Wl8EfCyxsm1jzUNug")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583AmountTypeCode Type { get; init; }

    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_5s1w1Wl8EfCyxsm1jzUNug")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Detailed amount expressed in the transaction currency.
    /// </summary>
    [IsoId("_5s1w12l8EfCyxsm1jzUNug")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Detailed amount expressed in the cardholder billing currency.
    /// </summary>
    [IsoId("_5s1w2Wl8EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; }

    /// <summary>
    /// Detailed amount expressed in the reconciliation currency.
    /// </summary>
    [IsoId("_5s1w22l8EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("_5s1w3Wl8EfCyxsm1jzUNug")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax70Text? Description { get; init; }
}
