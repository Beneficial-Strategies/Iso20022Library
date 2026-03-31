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

namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction.
/// </summary>
[Description(
    @"The ReceiptAcknowledgement message is sent by the transaction administrator to a member of the system and vice versa. It is sent to acknowledge the receipt of one or multiple messages sent previously. The Acknowledgement message is 1) an application receipt acknowledgement and 2) conveys information about the processing of the original message(s). In case of 2) the ReceiptAcknowledgement can be used as a Generic error message, which provides information about the status (e.g. rejection, acceptance) of an instruction."
)]
[IsoId("_4MJ7oZb3Eee4htziCyV8eA")]
[DisplayName("Receipt Acknowledgement V")]
public record ReceiptAcknowledgementV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RctAck";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.007.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies the identification the message.
    /// </summary>
    [IsoId("_4MJ7o5b3Eee4htziCyV8eA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageHeader10 MessageIdentification { get; init; }

    /// <summary>
    /// Provides report details on the request.
    /// </summary>
    [IsoId("_4MJ7pZb3Eee4htziCyV8eA")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public required ReceiptAcknowledgementReport2 Report { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_4MJ7p5b3Eee4htziCyV8eA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ReceiptAcknowledgementV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReceiptAcknowledgementV01.
