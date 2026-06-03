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
[IsoId("86a9e86a-a3e1-4da3-82fa-7aa33e0a99d1")]
[DisplayName("Fund Settlement Parameters27")]
public record FundSettlementParameters27
{
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally.
    /// </summary>
    [IsoId("275d01d9-412c-496e-8eba-d1cc59bc265f")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("3aa97e4c-790f-47ec-9c32-e8a58abe6610")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Condition under which the order/trade is to be settled.
    /// </summary>
    [IsoId("1f5eb681-e3af-4cc1-8fb4-26b397a2cfed")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("c7988579-142c-4bde-ad68-42408553a1e0")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    [IsoId("084f53b4-180b-4948-950b-785a69040f53")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public SettlementParties131? ReceivingSideDetails { get; init; }
}
