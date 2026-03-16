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
[IsoId("_tv6MUWpUEeSgo9vJrfSF_Q")]
[DisplayName("Clearing")]
public record Clearing4
{
    /// <summary>
    /// Indicates to the clearing member whether the trade is eligible for settlement netting or not.
    /// </summary>
    [IsoId("_uM64c2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Settlement Netting Eligible Code")]
    [IsoXmlTag("SttlmNetgElgblCd")]
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; }

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows clearing member firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, clearing member firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_uM64dWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Indicates if the position is guaranteed or non-guaranteed by the central counterparty, that is whether the CCP has done the novation and then guarantees the trade, or not.
    /// </summary>
    [IsoId("_uM64d2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Guaranteed Trade")]
    [IsoXmlTag("GrntedTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? GuaranteedTrade { get; init; }

    /// <summary>
    /// In case of trades that are not guaranteed by the central counterparty (this is when the central counterparty has not done the novation), provides details such as the trade counterparty member identification or the trade counterparty clearing member identification.
    /// </summary>
    [IsoId("_uM64eWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Non Guaranteed Trade")]
    [IsoXmlTag("NonGrntedTrad")]
    public NonGuaranteedTrade3? NonGuaranteedTrade { get; init; }
}
