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
/// This record is an implementation of the setr.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.
/// Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message.
/// </summary>
[Description(
    @"Scope|Sent by an executing party to an instructing party directly or through Central Matching Utility (CMU) to cancel the referenced SecuritiesTradeConfirmation message that was previously sent.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|It may also be used to cancel the trade confirmation previously sent from an executing party or an instructing party to a custodian or an affirming party directly or through CMU.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be either the Executing Party or Instructing Party.|Respondent: Instructing party, a custodian or an affirming party optionally responds with SecuritiesTradeConfirmationResponse (accept or reject) message."
)]
[IsoId("_RJ4jMOQXEeCGktPI9k4Dlw_1174499492")]
[DisplayName("Securities Trade Confirmation Cancellation V")]
public record SecuritiesTradeConfirmationCancellationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.029.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfCxl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.029.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationCancellation message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_RJ4jMeQXEeCGktPI9k4Dlw_-1509857852")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TransactiontIdentification4 Identification { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_RJ4jMuQXEeCGktPI9k4Dlw_135409583")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public Linkages15? References { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
    /// </summary>
    [IsoId("_RJ4jM-QXEeCGktPI9k4Dlw_588788110")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties18? OtherBusinessParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RJ4jNOQXEeCGktPI9k4Dlw_-206107615")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesTradeConfirmationCancellationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationCancellationV01.
