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
[IsoId("d9bf2e76-9b76-409c-ac95-c27625954b73")]
[DisplayName("Fund Settlement Parameters22")]
public record FundSettlementParameters22
{
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("70c0ab80-a06e-42fd-81b5-81e75e690336")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Place where the settlement of the transaction will take place.
    /// </summary>
    [IsoId("fc1e5dcc-a454-4494-b3ee-097fed73d08b")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public required PartyIdentification339 SettlementPlace { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally.
    /// </summary>
    [IsoId("4d56de6c-b715-462b-aaf1-77fd2d22d7ee")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("a3b8ddcc-75d2-4590-a771-ef4c52a1e881")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("4558438f-fc15-4969-a683-1c61ad1bc9bd")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Condition under which the order/trade is to be settled.
    /// </summary>
    [IsoId("ce851deb-a5b9-4932-aad7-52089ad535fb")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("ef85cb66-9a93-4f8e-8fbb-21100ce3b3f2")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public required ReceivingPartiesAndAccount24 ReceivingSideDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("ed3b6135-ec35-477b-a768-ded39864d969")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public DeliveringPartiesAndAccount24? DeliveringSideDetails { get; init; }
}
