// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[IsoId("_YOEiQbrcEeqxc9M5o04tAA")]
[DisplayName("Local Market Annex")]
public record LocalMarketAnnex4
{
    /// <summary>
    /// Country of the local fund order desk.
    /// </summary>
    [IsoId("_YhHaE7rcEeqxc9M5o04tAA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public SimpleValueList<string> Country { get; init; } = [];

    // ID for the above is _YhHaE7rcEeqxc9M5o04tAA

    /// <summary>
    /// Local entity appointed by the fund, to which orders should be submitted.
    /// </summary>
    [IsoId("_YhHaFbrcEeqxc9M5o04tAA")]
    [DisplayName("Local Order Desk")]
    [IsoXmlTag("LclOrdrDsk")]
    public required OrderDesk1 LocalOrderDesk { get; init; }

    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_YhHaF7rcEeqxc9M5o04tAA")]
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; init; }

    /// <summary>
    /// Processing characteristics linked to a redemption to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_YhHaGbrcEeqxc9M5o04tAA")]
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public ProcessingCharacteristics5? RedemptionProcessingCharacteristics { get; init; }

    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_YhHaG7rcEeqxc9M5o04tAA")]
    [DisplayName("Switch Processing Characteristics")]
    [IsoXmlTag("SwtchPrcgChrtcs")]
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; }

    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    [IsoId("_YhHaHbrcEeqxc9M5o04tAA")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public CashAccount202? CashSettlementDetails { get; init; }

    /// <summary>
    /// Additional information about the fund order desk.
    /// </summary>
    [IsoId("_YhHaH7rcEeqxc9M5o04tAA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
