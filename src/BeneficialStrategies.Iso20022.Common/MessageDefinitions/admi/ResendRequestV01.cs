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
/// This record is an implementation of the admi.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A system member or any parties authorised by them send a ResendRequest message to the Central System (such as the T2S platform). The purpose of this request is, that the requesting party wants to receive the “original” message once again. This might be caused through technical problems on the receiving side (message could not be received or processed or is missing in the message sequencing) or for archiving purposes.
/// </summary>
[Description(
    @"A system member or any parties authorised by them send a ResendRequest message to the Central System (such as the T2S platform). The purpose of this request is, that the requesting party wants to receive the “original” message once again. This might be caused through technical problems on the receiving side (message could not be received or processed or is missing in the message sequencing) or for archiving purposes."
)]
[IsoId("_5xUioZb3Eee4htziCyV8eA")]
[DisplayName("Resend Request V")]
public record ResendRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.006.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsndReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.006.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements to identify the resend message.
    /// </summary>
    [IsoId("_5xUio5b3Eee4htziCyV8eA")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader7 MessageHeader { get; init; }

    /// <summary>
    /// Defines the criteria to unambiguously identify the information to be resent.
    /// </summary>
    [IsoId("_5xUipZb3Eee4htziCyV8eA")]
    [DisplayName("Resend Search Criteria")]
    [IsoXmlTag("RsndSchCrit")]
    public required ResendSearchCriteria2 ResendSearchCriteria { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5xUip5b3Eee4htziCyV8eA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ResendRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ResendRequestV01.
