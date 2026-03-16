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
/// This record is an implementation of the semt.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent, sends the AccountingStatementofHoldingsCancellation message to the account owner, for example, a fund manager or an account owner&apos;s designated agent, to notify the cancellation of a previously sent AccountingStatementOfHoldings message.
/// Usage
/// The AccountingStatementOfHoldingsCancellation message is used to cancel a previously sent AccountingStatementOfHoldings message. This message must contain the reference of the message to be cancelled.
/// This message may also contain all the details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|An account servicer, for example, a transfer agent, sends the AccountingStatementofHoldingsCancellation message to the account owner, for example, a fund manager or an account owner's designated agent, to notify the cancellation of a previously sent AccountingStatementOfHoldings message.|Usage|The AccountingStatementOfHoldingsCancellation message is used to cancel a previously sent AccountingStatementOfHoldings message. This message must contain the reference of the message to be cancelled.|This message may also contain all the details of the message to be cancelled, but this is not recommended."
)]
[IsoId("_McJgvtFSEd-BzquC8wXy7w_-1129601452")]
[DisplayName("Accounting Statement Of Holdings Cancellation V")]
public record AccountingStatementOfHoldingsCancellationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.005.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctgStmtOfHldgsCxlV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.005.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_McSqoNFSEd-BzquC8wXy7w_-312284977")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_McSqodFSEd-BzquC8wXy7w_-1129601449")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_McSqotFSEd-BzquC8wXy7w_-1129601408")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_McSqo9FSEd-BzquC8wXy7w_-1129601090")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// The Accounting Statement of Holdings message to cancel.
    /// </summary>
    [IsoId("_McSqpNFSEd-BzquC8wXy7w_-1129601373")]
    [DisplayName("Statement To Be Cancelled")]
    [IsoXmlTag("StmtToBeCanc")]
    public AccountingStatementOfHoldings2? StatementToBeCancelled { get; init; }
}

// Since AccountingStatementOfHoldingsCancellationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountingStatementOfHoldingsCancellationV02.
