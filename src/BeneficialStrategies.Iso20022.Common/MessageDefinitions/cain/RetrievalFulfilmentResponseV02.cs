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

namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.015.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RetrievalFulfilmentResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a RetrievalFulfilmentInitiation message.
/// </summary>
[Description(
    @"The RetrievalFulfilmentResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a RetrievalFulfilmentInitiation message."
)]
[IsoId("_-5mJoYHWEeu7P-fjMhpKOg")]
[DisplayName("Retrieval Fulfilment Response V")]
public record RetrievalFulfilmentResponseV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.015.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlFlfmtRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.015.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_-5mJo4HWEeu7P-fjMhpKOg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header66 Header { get; init; }

    /// <summary>
    /// Information related to the response to the request of a retrieval fulfilment.
    /// </summary>
    [IsoId("_-5mJpYHWEeu7P-fjMhpKOg")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required RetrievalFulfilmentResponse2 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_-5mJp4HWEeu7P-fjMhpKOg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since RetrievalFulfilmentResponseV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RetrievalFulfilmentResponseV02.
