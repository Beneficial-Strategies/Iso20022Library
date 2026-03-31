// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides amounts taken in to account to calculate the collateral position.
/// </summary>
[IsoId("_taYAHgLqEeutW5-TpeYJhA")]
[DisplayName("Summary Amounts")]
public record SummaryAmounts2
{
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    [IsoId("_taYAJwLqEeutW5-TpeYJhA")]
    [DisplayName("Threshold Amount")]
    [IsoXmlTag("ThrshldAmt")]
    public ActiveCurrencyAndAmount? ThresholdAmount { get; init; }

    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    [IsoId("_taYAKALqEeutW5-TpeYJhA")]
    [DisplayName("Threshold Type")]
    [IsoXmlTag("ThrshldTp")]
    public ThresholdType1Code? ThresholdType { get; init; }

    /// <summary>
    /// Total value of posted collateral (pre-haircut) held by the taker.
    /// </summary>
    [IsoId("_taYAIgLqEeutW5-TpeYJhA")]
    [DisplayName("Pre Haircut Collateral Value")]
    [IsoXmlTag("PreHrcutCollVal")]
    public ActiveCurrencyAndAmount? PreHaircutCollateralValue { get; init; }

    /// <summary>
    /// Total amount of collateral required (unrounded).
    /// </summary>
    [IsoId("_taYAJALqEeutW5-TpeYJhA")]
    [DisplayName("Adjusted Exposure")]
    [IsoXmlTag("AdjstdXpsr")]
    public ActiveCurrencyAndAmount? AdjustedExposure { get; init; }

    /// <summary>
    /// Total amount of collateral required (rounded).
    /// </summary>
    [IsoId("_taYAHwLqEeutW5-TpeYJhA")]
    [DisplayName("Collateral Required")]
    [IsoXmlTag("CollReqrd")]
    public ActiveCurrencyAndAmount? CollateralRequired { get; init; }

    /// <summary>
    /// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
    /// </summary>
    [IsoId("_5F0TgALqEeutW5-TpeYJhA")]
    [DisplayName("Return Excess Cash And Collateral Currency")]
    [IsoXmlTag("RtrXcssCshAndCollCcy")]
    public ValueList<ReturnExcessCash1> ReturnExcessCashAndCollateralCurrency { get; init; } = [];

    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of collateral).
    /// </summary>
    [IsoId("_taYAJgLqEeutW5-TpeYJhA")]
    [DisplayName("Minimum Transfer Amount")]
    [IsoXmlTag("MinTrfAmt")]
    public ActiveCurrencyAndAmount? MinimumTransferAmount { get; init; }

    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    [IsoId("_taYAJQLqEeutW5-TpeYJhA")]
    [DisplayName("Rounding Amount")]
    [IsoXmlTag("RndgAmt")]
    public ActiveCurrencyAndAmount? RoundingAmount { get; init; }

    /// <summary>
    /// Exposure value at previous valuation.
    /// </summary>
    [IsoId("_taYAIQLqEeutW5-TpeYJhA")]
    [DisplayName("Previous Exposure Value")]
    [IsoXmlTag("PrvsXpsrVal")]
    public ActiveCurrencyAndAmount? PreviousExposureValue { get; init; }

    /// <summary>
    /// Value of collateral at previous valuation.
    /// </summary>
    [IsoId("_taYAKgLqEeutW5-TpeYJhA")]
    [DisplayName("Previous Collateral Value")]
    [IsoXmlTag("PrvsCollVal")]
    public ActiveCurrencyAndAmount? PreviousCollateralValue { get; init; }

    /// <summary>
    /// Value of incoming collateral, to be settled.
    /// </summary>
    [IsoId("_taYAKQLqEeutW5-TpeYJhA")]
    [DisplayName("Total Pending Incoming Collateral")]
    [IsoXmlTag("TtlPdgIncmgColl")]
    public ActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; init; }

    /// <summary>
    /// Value of outgoing collateral, to be settled.
    /// </summary>
    [IsoId("_taYAKwLqEeutW5-TpeYJhA")]
    [DisplayName("Total Pending Outgoing Collateral")]
    [IsoXmlTag("TtlPdgOutgngColl")]
    public ActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; init; }

    /// <summary>
    /// Sum of accrued interest.
    /// </summary>
    [IsoId("_taYAIALqEeutW5-TpeYJhA")]
    [DisplayName("Total Accrued Interest Amount")]
    [IsoXmlTag("TtlAcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; init; }

    /// <summary>
    /// Sum of fees/commissions.
    /// </summary>
    [IsoId("_taYAIwLqEeutW5-TpeYJhA")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; }
}
