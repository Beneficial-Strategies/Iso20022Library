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
    /// <summary>
    /// Qualifier or type of amount.
    /// </summary>
    [IsoId("_AxffUWl9EfCyxsm1jzUNug")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount22Code? AmountQualifier { get; init; }

    /// <summary>
    /// Amount of the transaction expressed in the currency of the terminal or as a reversed amount of a previous authorisation.
    /// </summary>
    [IsoId("_AxffU2l9EfCyxsm1jzUNug")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the transaction amount.
    /// </summary>
    [IsoId("_AxffW2l9EfCyxsm1jzUNug")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ISO3NumericCurrencyCode Currency { get; init; }

    /// <summary>
    /// Amount of the transaction in cardholder billing currency.
    /// </summary>
    [IsoId("_AxffaWl9EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; }

    /// <summary>
    /// Currency code of Cardholder and associated with cardholder billing amount.
    /// </summary>
    [IsoId("_AxffcWl9EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Currency")]
    [IsoXmlTag("CrdhldrBllgCcy")]
    public ISO3NumericCurrencyCode? CardholderBillingCurrency { get; init; }

    /// <summary>
    /// Effective exchange rate used in the conversion from transaction amount to cardholder billing amount.
    /// </summary>
    [IsoId("_Axfff2l9EfCyxsm1jzUNug")]
    [DisplayName("Cardholder Billing Effective Exchange Rate")]
    [IsoXmlTag("CrdhldrBllgFctvXchgRate")]
    public IsoBaseOne25Rate? CardholderBillingEffectiveExchangeRate { get; init; }

    /// <summary>
    /// Amount of the transaction in Reconciliation currency.
    /// </summary>
    [IsoId("_Axffh2l9EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    /// <summary>
    /// Currency code of Reconciliation and associated with Reconciliation amount.
    /// </summary>
    [IsoId("_AxffiWl9EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; }

    /// <summary>
    /// Effective exchange rate used in the conversion from transaction amount to reconciliation amount.
    /// </summary>
    [IsoId("_Axffl2l9EfCyxsm1jzUNug")]
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; }

    /// <summary>
    /// Further details of some or all amounts in the transaction amount.
    /// </summary>
    [IsoId("_AxffpWl9EfCyxsm1jzUNug")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public ValueList<DetailedAmount24> DetailedAmount { get; init; } = [];
}
