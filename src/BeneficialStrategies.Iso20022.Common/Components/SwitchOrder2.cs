// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer from one investment fund/fund class to another investment fund or investment fund class by the investor. A switch is composed of one or several subscription legs, and one or several redemption legs.
/// </summary>
[IsoId("_VVuFi9p-Ed-ak6NoX_4Aeg_-1360536112")]
[DisplayName("Switch Order")]
public record SwitchOrder2
{
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VVuFjNp-Ed-ak6NoX_4Aeg_-1824533801")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VVuFjdp-Ed-ak6NoX_4Aeg_-1360536094")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_VV3PcNp-Ed-ak6NoX_4Aeg_-1360535488")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_VV3Pcdp-Ed-ak6NoX_4Aeg_-1360536077")]
    [DisplayName("Total Redemption Amount")]
    [IsoXmlTag("TtlRedAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; }

    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_VV3Pctp-Ed-ak6NoX_4Aeg_-1360536060")]
    [DisplayName("Total Subscription Amount")]
    [IsoXmlTag("TtlSbcptAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; }

    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_VV3Pc9p-Ed-ak6NoX_4Aeg_-1425073053")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ExpiryDateTime { get; init; }

    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_VV3PdNp-Ed-ak6NoX_4Aeg_-1360536042")]
    [DisplayName("Additional Cash In")]
    [IsoXmlTag("AddtlCshIn")]
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; }

    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_VV3Pddp-Ed-ak6NoX_4Aeg_-1360535905")]
    [DisplayName("Resulting Cash Out")]
    [IsoXmlTag("RsltgCshOut")]
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; }

    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VV3Pdtp-Ed-ak6NoX_4Aeg_-1360535550")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1? CancellationRight { get; init; }

    /// <summary>
    /// Part of an investment fund switch order that is a redemption.
    /// </summary>
    [IsoId("_VV3Pd9p-Ed-ak6NoX_4Aeg_-1360535454")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegOrder2> RedemptionLegDetails { get; init; } = [];

    // ID for the above is _VV3Pd9p-Ed-ak6NoX_4Aeg_-1360535454

    /// <summary>
    /// Part of an investment fund switch order that is a subscription.
    /// </summary>
    [IsoId("_VWBAcNp-Ed-ak6NoX_4Aeg_-1360535181")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegOrder2> SubscriptionLegDetails { get; init; } = [];

    // ID for the above is _VWBAcNp-Ed-ak6NoX_4Aeg_-1360535181

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VWBAcdp-Ed-ak6NoX_4Aeg_-1360535146")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction20? CashSettlementDetails { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VWBActp-Ed-ak6NoX_4Aeg_1639276235")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; }
}
