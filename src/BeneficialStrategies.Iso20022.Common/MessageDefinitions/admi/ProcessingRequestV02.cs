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
/// This record is an implementation of the admi.017.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Processing Request message is sent by a participant to a central system to request the initiation of a system process supported by a central system.
/// </summary>
[Description(
    @"The Processing Request message is sent by a participant to a central system to request the initiation of a system process supported by a central system."
)]
[IsoId("_1MsY4QR4Ee29PP19jELcvQ")]
[DisplayName("Processing Request V")]
public record ProcessingRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.017.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrcgReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.017.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unique and unambiguous identifier for the message, as assigned by the sender.
    /// </summary>
    [IsoId("_1Ms_8QR4Ee29PP19jELcvQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Indicates the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_1Ms_8wR4Ee29PP19jELcvQ")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }

    /// <summary>
    /// Contains the details of the processing request.
    /// </summary>
    [IsoId("_1Ms_9QR4Ee29PP19jELcvQ")]
    [DisplayName("Request")]
    [IsoXmlTag("Req")]
    public required RequestDetails30 Request { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_36KEsQR4Ee29PP19jELcvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ProcessingRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ProcessingRequestV02.
