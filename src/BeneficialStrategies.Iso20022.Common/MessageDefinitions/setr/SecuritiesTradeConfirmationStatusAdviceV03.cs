// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.044.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent from Central Matching Utility (CMU) to an executing party or an instructing party to advise the status of the SecuritiesTradeConfirmation message previously sent by the party. The status may be a processing, pending processing, affirmed or disaffirmed, cancel or replacement by an instructing party, a custodian or an affirming party, internal matching, and/or matching status.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors. The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: In central matching the Initiator is the Central Matching Utility.
/// Respondent: no response is needed by the recipient of the message.
/// </summary>
[Description(
    @"Scope|This message is sent from Central Matching Utility (CMU) to an executing party or an instructing party to advise the status of the SecuritiesTradeConfirmation message previously sent by the party. The status may be a processing, pending processing, affirmed or disaffirmed, cancel or replacement by an instructing party, a custodian or an affirming party, internal matching, and/or matching status.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors. The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The ISO 20022 Business Application Header must be used|Usage|Initiator: In central matching the Initiator is the Central Matching Utility.|Respondent: no response is needed by the recipient of the message."
)]
[IsoId("_upGFgANmEe2P7e2qGFFOGg")]
[DisplayName("Securities Trade Confirmation Status Advice V")]
public record SecuritiesTradeConfirmationStatusAdviceV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.044.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.044.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationStatusAdvice message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_upGFigNmEe2P7e2qGFFOGg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TransactiontIdentification4 Identification { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_upGFjANmEe2P7e2qGFFOGg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required Linkages72 References { get; init; }

    /// <summary>
    /// Provides details on the affitrmation status of a trade.
    /// </summary>
    [IsoId("_upGFjgNmEe2P7e2qGFFOGg")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus11Choice_? AffirmationStatus { get; init; }

    /// <summary>
    /// Provides the processing status of a trade.
    /// </summary>
    [IsoId("_upGFkANmEe2P7e2qGFFOGg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus98Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides details on the matching status of a trade.
    /// </summary>
    [IsoId("_upGFkgNmEe2P7e2qGFFOGg")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus35Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the replacement processing status of a trade.
    /// </summary>
    [IsoId("_upGFlANmEe2P7e2qGFFOGg")]
    [DisplayName("Replacement Processing Status")]
    [IsoXmlTag("RplcmntPrcgSts")]
    public ReplacementProcessingStatus10Choice_? ReplacementProcessingStatus { get; init; }

    /// <summary>
    /// Provides details on the cancellation status of a trade.
    /// </summary>
    [IsoId("_upGFlgNmEe2P7e2qGFFOGg")]
    [DisplayName("Cancellation Processing Status")]
    [IsoXmlTag("CxlPrcgSts")]
    public CancellationProcessingStatus10Choice_? CancellationProcessingStatus { get; init; }

    /// <summary>
    /// Details of the trading party.
    /// </summary>
    [IsoId("_upGFmANmEe2P7e2qGFFOGg")]
    [DisplayName("Party Trading Details")]
    [IsoXmlTag("PtyTradgDtls")]
    public Order23? PartyTradingDetails { get; init; }

    /// <summary>
    /// Details of the trading counterparty.
    /// </summary>
    [IsoId("_upGFmgNmEe2P7e2qGFFOGg")]
    [DisplayName("Counterparty Trading Details")]
    [IsoXmlTag("CtrPtyTradgDtls")]
    public Order23? CounterpartyTradingDetails { get; init; }

    /// <summary>
    /// Parties used for acting parties that applies either to the whole message or to individual sides.
    /// </summary>
    [IsoId("_upGFnANmEe2P7e2qGFFOGg")]
    [DisplayName("Confirmation Parties")]
    [IsoXmlTag("ConfPties")]
    public ConfirmationParties9? ConfirmationParties { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_upGFngNmEe2P7e2qGFFOGg")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties121? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_upGFoANmEe2P7e2qGFFOGg")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties121? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_upGFogNmEe2P7e2qGFFOGg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesTradeConfirmationStatusAdviceV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationStatusAdviceV03.
