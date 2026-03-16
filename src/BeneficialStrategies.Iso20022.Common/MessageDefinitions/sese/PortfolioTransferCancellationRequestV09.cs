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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.014.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PortfolioTransferCancellationRequest message is sent by, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent PortfolioTransferInstruction message.
/// Usage
/// The PortfolioTransferCancellationRequest message is used to request the cancellation of a portfolio transfer instruction.
/// There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of a portfolio transfer instruction, the transfer reference of the portfolio transfer, as specified in the original PortfolioTransferInstruction message, is specified in the transfer reference element.
/// The message identification of the original PortfolioTransferInstruction message may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a PortfolioTransferCancellationRequest is made using an TransferCancellationStatusReport message.
/// </summary>
[Description(
    @"Scope|The PortfolioTransferCancellationRequest message is sent by, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent PortfolioTransferInstruction message.|Usage|The PortfolioTransferCancellationRequest message is used to request the cancellation of a portfolio transfer instruction.|There is no amendment, but a cancellation and re-instruct policy.|To request the cancellation of a portfolio transfer instruction, the transfer reference of the portfolio transfer, as specified in the original PortfolioTransferInstruction message, is specified in the transfer reference element.|The message identification of the original PortfolioTransferInstruction message may also be quoted in PreviousReference but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a PortfolioTransferCancellationRequest is made using an TransferCancellationStatusReport message."
)]
[IsoId("_OSc-8XhFEeij0vbhRaNJcw")]
[DisplayName("Portfolio Transfer Cancellation Request V")]
public record PortfolioTransferCancellationRequestV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.014.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.014.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_OSc-83hFEeij0vbhRaNJcw")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_OSc-9XhFEeij0vbhRaNJcw")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_OSc-93hFEeij0vbhRaNJcw")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_OSc--XhFEeij0vbhRaNJcw")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_OSc--3hFEeij0vbhRaNJcw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Reference of the portfolio transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_OSc-_XhFEeij0vbhRaNJcw")]
    [DisplayName("Transfer References")]
    [IsoXmlTag("TrfRefs")]
    public required TransferReference14 TransferReferences { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_OSc-_3hFEeij0vbhRaNJcw")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
}

// Since PortfolioTransferCancellationRequestV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferCancellationRequestV09.
