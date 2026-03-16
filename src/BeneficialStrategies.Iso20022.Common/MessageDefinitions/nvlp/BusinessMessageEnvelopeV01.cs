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

namespace BeneficialStrategies.Iso20022.nvlp;

/// <summary>
/// This record is an implementation of the nvlp.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The BusinessMessageEnvelope is a technical message container used to bundle a business application header with a message definition, typically to support processing or transport. It may contain and define additional data elements that apply to the message instance container.
/// </summary>
[Description(
    @"The BusinessMessageEnvelope is a technical message container used to bundle a business application header with a message definition, typically to support processing or transport. It may contain and define additional data elements that apply to the message instance container."
)]
[IsoId("_C7O-UQJ9Ee2MF-ort1OTzA")]
[DisplayName("Business Message Envelope V")]
public record BusinessMessageEnvelopeV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "nvlp.001.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BizMsgEnvlp";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:nvlp.001.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "BizMsgEnvlp";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// ISO 20022 Business Application Header instance.
    /// Rule: The external schema must be an official ISO 20022 Business Application Header.
    /// </summary>
    [IsoId("_vln_FAJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public LaxPayload? Header { get; init; }

    /// <summary>
    /// ISO 20022 Message Definition instance.
    /// Rule: The external schema must be an official ISO 20022 Message Definition.
    /// </summary>
    [IsoId("_vln_FQJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public required LaxPayload Document { get; init; }

    /// <summary>
    /// Reference related to the delivery of the business message whilst in transit from sending to receiving business application.
    /// </summary>
    [IsoId("_vln_FgJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public Reference22? Reference { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vln_FwJ9Ee2o0-v8T2Svrw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since BusinessMessageEnvelopeV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BusinessMessageEnvelopeV01.
