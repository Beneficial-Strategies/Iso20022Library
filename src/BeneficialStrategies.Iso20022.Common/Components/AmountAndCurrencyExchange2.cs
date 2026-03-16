// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information on the original amount and currency information.
/// </summary>
[IsoId("_SVf1xNp-Ed-ak6NoX_4Aeg_1205555994")]
[DisplayName("Amount And Currency Exchange")]
public record AmountAndCurrencyExchange2
{
    /// <summary>
    /// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party and provides currency exchange info in case the instructed amount and/or currency is/are different from the entry amount and/or currency.
    /// </summary>
    [IsoId("_SVf1xdp-Ed-ak6NoX_4Aeg_1205556020")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public AmountAndCurrencyExchangeDetails1? InstructedAmount { get; init; }

    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    [IsoId("_SVf1xtp-Ed-ak6NoX_4Aeg_1205556469")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public AmountAndCurrencyExchangeDetails1? TransactionAmount { get; init; }

    /// <summary>
    /// Identifies the countervalue amount and provides currency exchange information. Either the counter amount quoted in an FX deal, or the result of the currency information applied to an instructed amount, before deduction of charges.
    /// </summary>
    [IsoId("_SVf1x9p-Ed-ak6NoX_4Aeg_1205556132")]
    [DisplayName("Counter Value Amount")]
    [IsoXmlTag("CntrValAmt")]
    public AmountAndCurrencyExchangeDetails1? CounterValueAmount { get; init; }

    /// <summary>
    /// Information on the amount of money, based on terms of corporate action event and balance of underlying securities, entitled to/from the account owner.||Amount of money, based on terms of corporate action event and balance of underlying securities, entitled to/from the account owner.|In those situations, this amount may alternatively be called entitled amount.
    /// </summary>
    [IsoId("_SVf1yNp-Ed-ak6NoX_4Aeg_1205556080")]
    [DisplayName("Announced Posting Amount")]
    [IsoXmlTag("AnncdPstngAmt")]
    public AmountAndCurrencyExchangeDetails1? AnnouncedPostingAmount { get; init; }

    /// <summary>
    /// Provides proprietary amount information.
    /// </summary>
    [IsoId("_SVo_sNp-Ed-ak6NoX_4Aeg_1205556409")]
    [DisplayName("Proprietary Amount")]
    [IsoXmlTag("PrtryAmt")]
    public ValueList<AmountAndCurrencyExchangeDetails2> ProprietaryAmount { get; init; } = [];
}
