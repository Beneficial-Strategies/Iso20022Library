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
/// This record is an implementation of the cain.021.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The RetrievalInitiation message is sent by an issuer or agent to an acquirer to retrieve the original transaction details.
/// </summary>
[Description(
    @"The RetrievalInitiation message is sent by an issuer or agent to an acquirer to retrieve the original transaction details."
)]
[IsoId("_IcTD1FaCEeeFltjJxERUxw")]
[DisplayName("Retrieval Initiation V")]
public record RetrievalInitiationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.021.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrvlInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.021.001.01";

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
    [IsoId("_IcTD11aCEeeFltjJxERUxw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header55 Header { get; init; }

    /// <summary>
    /// Information related to the initiation of a retrieval of information.
    /// </summary>
    [IsoId("_IcTD1laCEeeFltjJxERUxw")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required RetrievalInitiation1 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_IcTD1VaCEeeFltjJxERUxw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since RetrievalInitiationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RetrievalInitiationV01.
