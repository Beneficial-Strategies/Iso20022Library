// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original amount.
/// </summary>
[IsoId("_l5QfsQ5rEe2xs7BqO31w6w")]
[DisplayName("Amount And Currency Exchange")]
public record AmountAndCurrencyExchange4
{
    /// <summary>
    /// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party and provides currency exchange information in case the instructed amount and/or currency is/are different from the entry amount and/or currency.
    /// </summary>
    [IsoId("_mEI6Aw5rEe2xs7BqO31w6w")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public AmountAndCurrencyExchangeDetails5? InstructedAmount { get; init; }

    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    [IsoId("_mEI6BQ5rEe2xs7BqO31w6w")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public AmountAndCurrencyExchangeDetails5? TransactionAmount { get; init; }

    /// <summary>
    /// Set of elements used to provide the countervalue amount and currency exchange information. |Usage: This can be either the counter amount quoted in an FX deal, or the result of the currency information applied to an instructed amount, before deduction of charges.
    /// </summary>
    [IsoId("_mEI6Bw5rEe2xs7BqO31w6w")]
    [DisplayName("Counter Value Amount")]
    [IsoXmlTag("CntrValAmt")]
    public AmountAndCurrencyExchangeDetails5? CounterValueAmount { get; init; }

    /// <summary>
    /// Amount of money, based on terms of corporate action event and balance of underlying securities, entitled to/from the account owner.|In some situations, this amount may alternatively be called entitled amount.
    /// </summary>
    [IsoId("_mEI6CQ5rEe2xs7BqO31w6w")]
    [DisplayName("Announced Posting Amount")]
    [IsoXmlTag("AnncdPstngAmt")]
    public AmountAndCurrencyExchangeDetails5? AnnouncedPostingAmount { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the original amount and currency exchange.
    /// </summary>
    [IsoId("_mEI6Cw5rEe2xs7BqO31w6w")]
    [DisplayName("Proprietary Amount")]
    [IsoXmlTag("PrtryAmt")]
    public AmountAndCurrencyExchangeDetails6? ProprietaryAmount { get; init; }
}
