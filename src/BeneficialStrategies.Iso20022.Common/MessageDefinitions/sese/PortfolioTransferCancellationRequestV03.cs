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
/// This record is an implementation of the sese.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, a (new) plan manager (Transferee), sends the PortfolioTransferCancellationRequest message to the executing party, eg, a (old) plan manager (Transferor), to request the cancellation of a previously sent PortfolioTransferInstruction.
/// Usage
/// The PortfolioTransferCancellationRequest message is used to request the cancellation of an entire PortfolioTransferInstruction message, ie, all the product transfers that it contained. The cancellation request can be specified either by:
/// - quoting the transfer references of all the product transfers listed in the PortfolioTransferInstruction message, or,
/// - quoting the details of all the product transfers (this includes TransferReference) listed in PortfolioTransferInstruction message.
/// The message identification of the PortfolioTransferInstruction may also be quoted in PreviousReference. It is also possible to request the cancellation of PortfolioTransferInstruction by just quoting its message identification in PreviousReference.
/// </summary>
[Description(
    @"Scope|An instructing party, eg, a (new) plan manager (Transferee), sends the PortfolioTransferCancellationRequest message to the executing party, eg, a (old) plan manager (Transferor), to request the cancellation of a previously sent PortfolioTransferInstruction.|Usage|The PortfolioTransferCancellationRequest message is used to request the cancellation of an entire PortfolioTransferInstruction message, ie, all the product transfers that it contained. The cancellation request can be specified either by:|- quoting the transfer references of all the product transfers listed in the PortfolioTransferInstruction message, or,|- quoting the details of all the product transfers (this includes TransferReference) listed in PortfolioTransferInstruction message.|The message identification of the PortfolioTransferInstruction may also be quoted in PreviousReference. It is also possible to request the cancellation of PortfolioTransferInstruction by just quoting its message identification in PreviousReference."
)]
[IsoId("_N35jgfpcEeCPwaG9zjUPNQ")]
[DisplayName("Portfolio Transfer Cancellation Request V")]
public record PortfolioTransferCancellationRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.014.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.014.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_N35jjfpcEeCPwaG9zjUPNQ")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_N35jkfpcEeCPwaG9zjUPNQ")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_N35jlfpcEeCPwaG9zjUPNQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_N35jmfpcEeCPwaG9zjUPNQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// Information related to the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_N35jnfpcEeCPwaG9zjUPNQ")]
    [DisplayName("Cancellation By Transfer Instruction Details")]
    [IsoXmlTag("CxlByTrfInstrDtls")]
    public PEPISATransfer11? CancellationByTransferInstructionDetails { get; init; }

    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_N35jofpcEeCPwaG9zjUPNQ")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public TransferReference3? CancellationByReference { get; init; }
}

// Since PortfolioTransferCancellationRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferCancellationRequestV03.
