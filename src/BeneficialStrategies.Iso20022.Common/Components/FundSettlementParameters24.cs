// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
[IsoId("0dc22d15-9813-4686-a02d-cbeab0b7131e")]
[DisplayName("Fund Settlement Parameters24")]
public record FundSettlementParameters24
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally.
    /// </summary>
    [IsoId("3d4c8cc0-d5f4-49b6-b428-113344078733")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice? SafekeepingPlace { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("7fb13304-275b-4649-8f30-c050e5a10549")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Condition under which the order/trade is to be settled.
    /// </summary>
    [IsoId("d29176da-d775-48e3-a220-4e883826c589")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("f450209e-2fd6-495b-b88f-7f135221df3e")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("44e30539-bba1-42e7-8595-31df59817c3b")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public SettlementParties131? ReceivingSideDetails { get; init; }

    /// <summary>
    /// Chain of delivering settlement parties.
    /// </summary>
    [IsoId("17b986dc-e014-434b-9c1e-88bf27766989")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public SettlementParties131? DeliveringSideDetails { get; init; }
}
