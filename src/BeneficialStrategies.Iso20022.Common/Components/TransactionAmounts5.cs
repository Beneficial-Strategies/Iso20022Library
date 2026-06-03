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
[IsoId("_AvOOcWl9EfCyxsm1jzUNug")]
[DisplayName("Transaction Amounts5")]
public record TransactionAmounts5
{
    [IsoId("_AxffUWl9EfCyxsm1jzUNug")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; }

    [IsoId("_AxffU2l9EfCyxsm1jzUNug")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    [IsoId("_AxffW2l9EfCyxsm1jzUNug")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ISO3NumericCurrencyCode Currency { get; init; }

    [IsoId("_AxffaWl9EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; }

    [IsoId("_AxffcWl9EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Currency")]
    [IsoXmlTag("CrdhldrBllgCcy")]
    public ISO3NumericCurrencyCode? CardholderBillingCurrency { get; init; }

    [IsoId("_Axfff2l9EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Effective Exchange Rate")]
    [IsoXmlTag("CrdhldrBllgFctvXchgRate")]
    public IsoBaseOne25Rate? CardholderBillingEffectiveExchangeRate { get; init; }

    [IsoId("_Axffh2l9EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    [IsoId("_AxffiWl9EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; }

    [IsoId("_Axffl2l9EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; }

    [IsoId("_AxffpWl9EfCyxsm1jzUNug")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public ValueList<DetailedAmount24> DetailedAmount { get; init; } = [];
}
