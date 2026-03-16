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
[IsoId("_vVx-YqMOEeCojJW5vEuTEQ_933225086")]
[DisplayName("Summary Amounts")]
public record SummaryAmounts1
{
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    [IsoId("_AexcItokEeC60axPepSq7g_102667053")]
    [DisplayName("Threshold Amount")]
    [IsoXmlTag("ThrshldAmt")]
    public ActiveCurrencyAndAmount? ThresholdAmount { get; init; }

    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    [IsoId("_vVx-Y6MOEeCojJW5vEuTEQ_-1456058639")]
    [DisplayName("Threshold Type")]
    [IsoXmlTag("ThrshldTp")]
    public ThresholdType1Code? ThresholdType { get; init; }

    /// <summary>
    /// Total value of posted collateral (pre-haircut) held by the taker.
    /// </summary>
    [IsoId("_vVx-ZKMOEeCojJW5vEuTEQ_1210837912")]
    [DisplayName("Pre Haircut Collateral Value")]
    [IsoXmlTag("PreHrcutCollVal")]
    public ActiveCurrencyAndAmount? PreHaircutCollateralValue { get; init; }

    /// <summary>
    /// Total amount of collateral required (unrounded).
    /// </summary>
    [IsoId("_vVx-ZaMOEeCojJW5vEuTEQ_78396103")]
    [DisplayName("Adjusted Exposure")]
    [IsoXmlTag("AdjstdXpsr")]
    public ActiveCurrencyAndAmount? AdjustedExposure { get; init; }

    /// <summary>
    /// Total amount of collateral required (rounded).
    /// </summary>
    [IsoId("_vVx-ZqMOEeCojJW5vEuTEQ_1256493419")]
    [DisplayName("Collateral Required")]
    [IsoXmlTag("CollReqrd")]
    public ActiveCurrencyAndAmount? CollateralRequired { get; init; }

    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of collateral).
    /// </summary>
    [IsoId("_vVx-Z6MOEeCojJW5vEuTEQ_-1634168070")]
    [DisplayName("Minimum Transfer Amount")]
    [IsoXmlTag("MinTrfAmt")]
    public ActiveCurrencyAndAmount? MinimumTransferAmount { get; init; }

    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    [IsoId("_vVx-aKMOEeCojJW5vEuTEQ_344022506")]
    [DisplayName("Rounding Amount")]
    [IsoXmlTag("RndgAmt")]
    public ActiveCurrencyAndAmount? RoundingAmount { get; init; }

    /// <summary>
    /// Exposure value at previous valuation.
    /// </summary>
    [IsoId("_vV7IUKMOEeCojJW5vEuTEQ_-1037937575")]
    [DisplayName("Previous Exposure Value")]
    [IsoXmlTag("PrvsXpsrVal")]
    public ActiveCurrencyAndAmount? PreviousExposureValue { get; init; }

    /// <summary>
    /// Value of collateral at previous valuation.
    /// </summary>
    [IsoId("_vV7IUaMOEeCojJW5vEuTEQ_-1492369915")]
    [DisplayName("Previous Collateral Value")]
    [IsoXmlTag("PrvsCollVal")]
    public ActiveCurrencyAndAmount? PreviousCollateralValue { get; init; }

    /// <summary>
    /// Value of incoming collateral, to be settled.
    /// </summary>
    [IsoId("_vV7IUqMOEeCojJW5vEuTEQ_-2014052582")]
    [DisplayName("Total Pending Incoming Collateral")]
    [IsoXmlTag("TtlPdgIncmgColl")]
    public ActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; init; }

    /// <summary>
    /// Value of outgoing collateral, to be settled.
    /// </summary>
    [IsoId("_vV7IU6MOEeCojJW5vEuTEQ_-1006504724")]
    [DisplayName("Total Pending Outgoing Collateral")]
    [IsoXmlTag("TtlPdgOutgngColl")]
    public ActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; init; }

    /// <summary>
    /// Sum of accrued interest.
    /// </summary>
    [IsoId("_vV7IVKMOEeCojJW5vEuTEQ_-1233182887")]
    [DisplayName("Total Accrued Interest Amount")]
    [IsoXmlTag("TtlAcrdIntrstAmt")]
    public ActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; init; }

    /// <summary>
    /// Sum of fees/commissions.
    /// </summary>
    [IsoId("_vV7IVaMOEeCojJW5vEuTEQ_109882518")]
    [DisplayName("Total Fees")]
    [IsoXmlTag("TtlFees")]
    public ActiveCurrencyAndAmount? TotalFees { get; init; }
}
