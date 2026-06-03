// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the clearing details.
/// </summary>
[IsoId("_OBWD8ao4EfCG2_q2WT-90w")]
[DisplayName("Clearing8")]
public record Clearing8
{
    /// <summary>
    /// Indicates to the clearing member whether the trade is eligible for settlement netting or not.
    /// </summary>
    [IsoId("_OCi916o4EfCG2_q2WT-90w")]
    [DisplayName("Settlement Netting Eligible Code")]
    [IsoXmlTag("SttlmNetgElgblCd")]
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; }

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// </summary>
    [IsoId("_OCi93ao4EfCG2_q2WT-90w")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification253Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Indicates if the position is guaranteed or non-guaranteed by the central counterparty.
    /// </summary>
    [IsoId("_OCi946o4EfCG2_q2WT-90w")]
    [DisplayName("Guaranteed Trade")]
    [IsoXmlTag("GrntedTrad")]
    public IsoYesNoIndicator? GuaranteedTrade { get; init; }

    /// <summary>
    /// Whether the trades are guaranteed or not by the central counterparty, provide details such as the trade counterparty member identification or the trade counterparty clearing member identification.
    /// </summary>
    [IsoId("_OCi96ao4EfCG2_q2WT-90w")]
    [DisplayName("Trade Counterparty Identification")]
    [IsoXmlTag("TradCtrPtyId")]
    public NonGuaranteedTrade4? TradeCounterpartyIdentification { get; init; }
}
