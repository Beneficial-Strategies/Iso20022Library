// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral valuation.
/// </summary>
[IsoId("_Spl8ARInEeyZaPkaPAzTvQ")]
[DisplayName("Collateral Amount")]
public record CollateralAmount17
{
    /// <summary>
    /// Total value of posted collateral (post-haircut) expressed in the reporting currency.
    /// </summary>
    [IsoId("_TDEzARInEeyZaPkaPAzTvQ")]
    [DisplayName("Value Of Collateral Held")]
    [IsoXmlTag("ValOfCollHeld")]
    public required ActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; init; }

    /// <summary>
    /// Total exposure amount between the giver and taker expressed in the reporting currency. It includes the transaction amount and the accrued interests minus any  unsettled amount.
    /// </summary>
    [IsoId("_TDEzAxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Exposure")]
    [IsoXmlTag("TtlXpsr")]
    public required ActiveOrHistoricCurrencyAndAmount TotalExposure { get; init; }

    /// <summary>
    /// Transaction Amount as instructed by the client.
    /// </summary>
    [IsoId("_TDEzBRInEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TransactionAmount { get; init; }

    /// <summary>
    /// Breakdown of transaction amount (required value for the exposure)  into market value lots based on  the term for the underlying trades.
    /// </summary>
    [IsoId("_TDEzBxInEeyZaPkaPAzTvQ")]
    [DisplayName("Transaction Amount Breakdown")]
    [IsoXmlTag("TxAmtBrkdwn")]
    public CollateralTransactionAmountBreakdown2? TransactionAmountBreakdown { get; init; }

    /// <summary>
    /// The difference between the total collateral value and the total collateral required.
    /// </summary>
    [IsoId("_TDEzCRInEeyZaPkaPAzTvQ")]
    [DisplayName("Margin")]
    [IsoXmlTag("Mrgn")]
    public AmountAndDirection53? Margin { get; init; }

    /// <summary>
    /// Total amount of money accrued interest computed in the case of interest bearing financial instruments.
    /// </summary>
    [IsoId("_TDEzCxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Accrued Interest")]
    [IsoXmlTag("TtlAcrdIntrst")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAccruedInterest { get; init; }

    /// <summary>
    /// Collateral is required to cover interest that accrues on the exposure. Margin amount would thus be the difference between collateral required and collateral value (that is COVA).
    /// </summary>
    [IsoId("_TDEzDRInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Collateral Required")]
    [IsoXmlTag("TtlCollReqrd")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCollateralRequired { get; init; }

    /// <summary>
    /// Total value of own collateral in the reporting currency.
    /// </summary>
    [IsoId("_TDEzDxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Value Of Own Collateral")]
    [IsoXmlTag("TtlValOfOwnColl")]
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; }

    /// <summary>
    /// Total value of reused/rehypotheticated collateral in the reporting currency.
    /// </summary>
    [IsoId("_TDEzERInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Value Of Reused Collateral")]
    [IsoXmlTag("TtlValOfReusdColl")]
    public ActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; }

    /// <summary>
    /// Value of incoming collateral, to be settled in the reporting currency.
    /// </summary>
    [IsoId("_TDEzExInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Pending Collateral In")]
    [IsoXmlTag("TtlPdgCollIn")]
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralIn { get; init; }

    /// <summary>
    /// Value of outgoing collateral, to be settled in the reporting currency.
    /// </summary>
    [IsoId("_TDEzFRInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Pending Collateral Out")]
    [IsoXmlTag("TtlPdgCollOut")]
    public ActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralOut { get; init; }

    /// <summary>
    /// Total of principals in the reporting currency.
    /// </summary>
    [IsoId("_TDEzFxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Of Principals")]
    [IsoXmlTag("TtlOfPrncpls")]
    public ActiveOrHistoricCurrencyAndAmount? TotalOfPrincipals { get; init; }

    /// <summary>
    /// Termination Transaction Amount
    /// </summary>
    [IsoId("_TDEzGRInEeyZaPkaPAzTvQ")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Total value of undelivered intended transaction cash amount.
    /// </summary>
    [IsoId("_TDEzGxInEeyZaPkaPAzTvQ")]
    [DisplayName("Total Cash Failed")]
    [IsoXmlTag("TtlCshFaild")]
    public ActiveOrHistoricCurrencyAndAmount? TotalCashFailed { get; init; }
}
