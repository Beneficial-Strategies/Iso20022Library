// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fund Settlement Parameters20.
/// </summary>
[IsoId("_6Ra6IRwMEe6O0NdiBuX__w")]
[DisplayName("Fund Settlement Parameters20")]
public record FundSettlementParameters20
{
    /// <summary>
    /// Delivering Side Details.
    /// </summary>
    [DisplayName("Delivering Side Details")]
    [IsoXmlTag("DlvrgSdDtls")]
    public required DeliveringPartiesAndAccount20 DeliveringSideDetails { get; init; }

    /// <summary>
    /// Receiving Side Details.
    /// </summary>
    [DisplayName("Receiving Side Details")]
    [IsoXmlTag("RcvgSdDtls")]
    public ReceivingPartiesAndAccount20? ReceivingSideDetails { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat40Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Securities Settlement System Identification.
    /// </summary>
    [DisplayName("Securities Settlement System Identification")]
    [IsoXmlTag("SctiesSttlmSysId")]
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; }

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Settlement Place.
    /// </summary>
    [DisplayName("Settlement Place")]
    [IsoXmlTag("SttlmPlc")]
    public required PartyIdentification139 SettlementPlace { get; init; }

    /// <summary>
    /// Settlement Transaction Condition.
    /// </summary>
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition30Choice_> SettlementTransactionCondition { get; init; } =
        [];

    /// <summary>
    /// Trade Transaction Condition.
    /// </summary>
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition8Choice_> TradeTransactionCondition { get; init; } =
        [];
}
