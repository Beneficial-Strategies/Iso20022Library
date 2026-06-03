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
[IsoId("ffe33714-eb93-434e-95cf-8bc7c6e54cf6")]
[DisplayName("Fund Settlement Parameters28")]
public record FundSettlementParameters28
{
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("7266d819-6e42-4338-b136-a3141f0c53ad")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Place where the settlement of the transaction will take place.
    /// </summary>
    [IsoId("623c253b-c20c-4e26-8e5c-367d4bc030f5")]
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public required PartyIdentification339 SettlementPlace { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally.
    /// </summary>
    [IsoId("51d7030e-1c10-4bf7-90ab-96384ebd4857")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat42Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    [IsoId("2cd64fe6-2089-4aa7-8b8a-ad4ca9974b05")]
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Condition under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("3e2528d2-bb10-4509-9328-30d91b148d64")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Condition under which the order/trade is to be settled.
    /// </summary>
    [IsoId("93601699-2241-47bc-b919-50d6f4329bd9")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } = [];

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("5f4e6ad9-f194-40a3-b992-a0d64565bef5")]
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public ReceivingPartiesAndAccount24? ReceivingSideDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("6248ed0c-a400-4986-ae51-63977df3f553")]
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public required DeliveringPartiesAndAccount24 DeliveringSideDetails { get; init; }
}
