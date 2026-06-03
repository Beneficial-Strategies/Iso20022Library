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
[IsoId("_E1lxcWl-EfCyxsm1jzUNug")]
[DisplayName("Transaction Amounts6")]
public record TransactionAmounts6
{
    [IsoId("_E3w7sWl-EfCyxsm1jzUNug")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; }

    [IsoId("_E3w7s2l-EfCyxsm1jzUNug")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    [IsoId("_E3w7u2l-EfCyxsm1jzUNug")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    [IsoId("_E3w7yWl-EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; }

    [IsoId("_E3w70Wl-EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Currency")]
    [IsoXmlTag("CrdhldrBllgCcy")]
    public ISO3NumericCurrencyCode? CardholderBillingCurrency { get; init; }

    [IsoId("_E3w732l-EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Effective Exchange Rate")]
    [IsoXmlTag("CrdhldrBllgFctvXchgRate")]
    public IsoBaseOne25Rate? CardholderBillingEffectiveExchangeRate { get; init; }

    [IsoId("_E3w752l-EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    [IsoId("_E3w76Wl-EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; }

    [IsoId("_E3w792l-EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; }

    [IsoId("_E3w8BWl-EfCyxsm1jzUNug")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public ValueList<DetailedAmount24> DetailedAmount { get; init; } = [];
}
