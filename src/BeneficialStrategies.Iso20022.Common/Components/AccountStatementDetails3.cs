// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Statement Details3.
/// </summary>
[IsoId("_0vELYYJJEe6dZ_jHhjXHQg")]
[DisplayName("Account Statement Details3")]
public record AccountStatementDetails3
{
    /// <summary>
    /// Acceptor Name And Location.
    /// </summary>
    [DisplayName("Acceptor Name And Location")]
    [IsoXmlTag("AccptrNmAndLctn")]
    public Max99Text? AcceptorNameAndLocation { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

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
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Long Description.
    /// </summary>
    [DisplayName("Long Description")]
    [IsoXmlTag("LngDesc")]
    public Max256Text? LongDescription { get; init; }

    /// <summary>
    /// Pending.
    /// </summary>
    [DisplayName("Pending")]
    [IsoXmlTag("Pdg")]
    public TrueFalseIndicator? Pending { get; init; }

    /// <summary>
    /// Posting Date.
    /// </summary>
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public DateOnly? PostingDate { get; init; }

    /// <summary>
    /// Short Description.
    /// </summary>
    [DisplayName("Short Description")]
    [IsoXmlTag("ShrtDesc")]
    public Max70Text? ShortDescription { get; init; }

    /// <summary>
    /// Transaction Date.
    /// </summary>
    [DisplayName("Transaction Date")]
    [IsoXmlTag("TxDt")]
    public required DateOnly TransactionDate { get; init; }
}
