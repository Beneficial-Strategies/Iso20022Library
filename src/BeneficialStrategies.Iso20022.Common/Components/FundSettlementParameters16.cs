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
[IsoId("_rssUUZGVEem-9Y6mq5ZH3Q")]
[DisplayName("Fund Settlement Parameters")]
public record FundSettlementParameters16
{
    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_sAezAZGVEem-9Y6mq5ZH3Q")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    [IsoId("_sAezBZGVEem-9Y6mq5ZH3Q")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("_sAezB5GVEem-9Y6mq5ZH3Q")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("_sAezCZGVEem-9Y6mq5ZH3Q")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public SettlementParties94? ReceivingSideDetails { get; init; }
}
