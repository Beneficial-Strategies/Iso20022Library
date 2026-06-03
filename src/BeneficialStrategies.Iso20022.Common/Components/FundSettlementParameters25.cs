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
[IsoId("c2488515-0642-427f-8f51-30b794660552")]
[DisplayName("Fund Settlement Parameters25")]
public record FundSettlementParameters25
{
    /// <summary>
    /// Condition under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("f6a2b7c5-a200-487d-b071-33a1408e9ec4")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Condition under which the order/trade is to be settled.
    /// </summary>
    [IsoId("74347434-3752-4ed1-917f-910d9776975d")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("8af0cd60-4d5c-4af7-930a-bed065e68157")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("a51223e9-3b50-4c4c-93bf-66cdc9fa50cd")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public SettlementParties131? ReceivingSideDetails { get; init; }
}
