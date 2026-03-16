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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner or the account owner&apos;s designated agent. The account servicer may be a local agent (sub-custodian) acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message is used to cancel a previously sent CustodyStatementOfHoldings message.
/// Usage
/// The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner to cancel a previously sent CustodyStatementOfHoldings message.
/// This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent (sub-custodian) acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.|This message is used to cancel a previously sent CustodyStatementOfHoldings message.|Usage|The CustodyStatementOfHoldingsCancellation message is sent by an account servicer to the account owner to cancel a previously sent CustodyStatementOfHoldings message.|This message must contain the reference of the message to be cancelled. This message may also contain details of the message to be cancelled, but this is not recommended."
)]
[IsoId("_MXYVe9FSEd-BzquC8wXy7w_1108713826")]
[DisplayName("Custody Statement Of Holdings Cancellation")]
public record CustodyStatementOfHoldingsCancellation : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.004.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.004.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.004.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MXYVfNFSEd-BzquC8wXy7w_1620345511")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference2 PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MXYVfdFSEd-BzquC8wXy7w_1938037635")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_MXYVftFSEd-BzquC8wXy7w_1983699054")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// The Custody Statement of Holdings message to cancel.
    /// </summary>
    [IsoId("_MXhfYNFSEd-BzquC8wXy7w_-1021887814")]
    [DisplayName("Statement To Be Cancelled")]
    [IsoXmlTag("StmtToBeCanc")]
    public CustodyStatementOfHoldings1? StatementToBeCancelled { get; init; }
}

// Since CustodyStatementOfHoldingsCancellationDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustodyStatementOfHoldingsCancellation.
