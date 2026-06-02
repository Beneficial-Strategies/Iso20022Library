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
[IsoId("7e9fafb7-bf64-4bb8-9195-3daa1569e942")]
[DisplayName("Fund Settlement Parameters26")]
public record FundSettlementParameters26
{
    /// <summary>
    /// Condition under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("7816ec12-d1e0-4b2b-80e3-e4699d0724d8")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Condition under which the order/trade is to be settled.
    /// </summary>
    [IsoId("451c2cbc-0d84-4b2a-a0c1-e7dd87e54e5a")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("8230a0a0-b4cc-41d7-a08c-c804f49d2ff0")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Chain of delivering settlement parties.
    /// </summary>
    [IsoId("74b374e9-2a16-48ad-a501-adae26a00c84")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public SettlementParties131? DeliveringSideDetails { get; init; }
}
