// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fees not included in the transaction.
/// </summary>
[IsoId("_IllSoRRKEfC_aaedwHHlmw")]
[DisplayName("Additional Fee4")]
public record AdditionalFee4
{
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    [IsoId("_IssnQRRKEfC_aaedwHHlmw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583FeeTypeCode Type { get; init; }

    /// <summary>
    /// Identification of fee program.
    /// </summary>
    [IsoId("_IssnRRRKEfC_aaedwHHlmw")]
    [DisplayName("Program")]
    [IsoXmlTag("Prgm")]
    public IsoMax35Text? Program { get; init; }

    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    [IsoId("_IssnRxRKEfC_aaedwHHlmw")]
    [DisplayName("Descriptor")]
    [IsoXmlTag("Dscrptr")]
    public IsoMax35Text? Descriptor { get; init; }

    /// <summary>
    /// Fee rate.
    /// </summary>
    [IsoId("_u4eT4BRMEfC_aaedwHHlmw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoBaseOneRate? Rate { get; init; }

    /// <summary>
    /// Fix amount per transaction in currency for the type of amount.
    /// </summary>
    [IsoId("_IIJoYBRNEfC_aaedwHHlmw")]
    [DisplayName("Rate Fix")]
    [IsoXmlTag("RateFix")]
    public ImpliedCurrencyAndAmount? RateFix { get; init; }

    /// <summary>
    /// Contains code list for a credit or debit transaction.
    /// </summary>
    [IsoId("_IssnSRRKEfC_aaedwHHlmw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    [IsoId("_IssnSxRKEfC_aaedwHHlmw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency for the type of amount.
    /// </summary>
    [IsoId("_IssnTRRKEfC_aaedwHHlmw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Amount of the transaction in Reconciliation currency.
    /// </summary>
    [IsoId("_IssnTxRKEfC_aaedwHHlmw")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    /// <summary>
    /// Currency code of Reconciliation and associated with Reconciliation amount.
    /// </summary>
    [IsoId("_IssnURRKEfC_aaedwHHlmw")]
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; }

    /// <summary>
    /// Effective exchange rate used in the conversion from transaction amount to reconciliation amount.
    /// </summary>
    [IsoId("_IssnXxRKEfC_aaedwHHlmw")]
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; }

    /// <summary>
    /// A code to identify the type of party who assign the fee.
    /// </summary>
    [IsoId("_IssnbRRKEfC_aaedwHHlmw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public ATICAPartyType1Code? Assigner { get; init; }

    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    [IsoId("_IssncRRKEfC_aaedwHHlmw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax140Text? Description { get; init; }
}
