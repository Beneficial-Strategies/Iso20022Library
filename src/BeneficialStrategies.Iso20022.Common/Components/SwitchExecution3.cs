// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a switch order.
/// </summary>
[IsoId("_VVkUhdp-Ed-ak6NoX_4Aeg_-1431911896")]
[DisplayName("Switch Execution")]
public record SwitchExecution3
{
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VVkUhtp-Ed-ak6NoX_4Aeg_-1431911877")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_VVkUh9p-Ed-ak6NoX_4Aeg_-1431911853")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text DealReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VVkUiNp-Ed-ak6NoX_4Aeg_-1431911836")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_VVkUidp-Ed-ak6NoX_4Aeg_-1431911041")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_VVkUitp-Ed-ak6NoX_4Aeg_-1431911818")]
    [DisplayName("Total Redemption Amount")]
    [IsoXmlTag("TtlRedAmt")]
    public ActiveCurrencyAndAmount? TotalRedemptionAmount { get; init; }

    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_VVkUi9p-Ed-ak6NoX_4Aeg_-1431911801")]
    [DisplayName("Total Subscription Amount")]
    [IsoXmlTag("TtlSbcptAmt")]
    public ActiveCurrencyAndAmount? TotalSubscriptionAmount { get; init; }

    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_VVkUjNp-Ed-ak6NoX_4Aeg_-1431911783")]
    [DisplayName("Additional Cash In")]
    [IsoXmlTag("AddtlCshIn")]
    public ActiveCurrencyAndAmount? AdditionalCashIn { get; init; }

    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_VVuFgNp-Ed-ak6NoX_4Aeg_-1431911541")]
    [DisplayName("Resulting Cash Out")]
    [IsoXmlTag("RsltgCshOut")]
    public ActiveCurrencyAndAmount? ResultingCashOut { get; init; }

    /// <summary>
    /// Redemption leg of a switch order execution.
    /// </summary>
    [IsoId("_VVuFgdp-Ed-ak6NoX_4Aeg_-1431911410")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegExecution2> RedemptionLegDetails { get; init; } = [];

    // ID for the above is _VVuFgdp-Ed-ak6NoX_4Aeg_-1431911410

    /// <summary>
    /// Subscription leg of a switch order execution.
    /// </summary>
    [IsoId("_VVuFgtp-Ed-ak6NoX_4Aeg_-1431911480")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegExecution2> SubscriptionLegDetails { get; init; } = [];

    // ID for the above is _VVuFgtp-Ed-ak6NoX_4Aeg_-1431911480

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VVuFg9p-Ed-ak6NoX_4Aeg_-1431911368")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction14? CashSettlementDetails { get; init; }

    /// <summary>
    /// Currency exchange related to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VVuFhNp-Ed-ak6NoX_4Aeg_-1431911102")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init; }
}
