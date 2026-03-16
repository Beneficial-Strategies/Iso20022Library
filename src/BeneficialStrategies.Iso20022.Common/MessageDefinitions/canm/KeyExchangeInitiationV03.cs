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

namespace BeneficialStrategies.Iso20022.canm;

/// <summary>
/// This record is an implementation of the canm.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The KeyExchangeInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to initiate a cryptographic key activity (request of a key change, request of the verification of a key, etc.).|
///
///
/// </summary>
[Description(
    @"The KeyExchangeInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). This message is used to initiate a cryptographic key activity (request of a key change, request of the verification of a key, etc.).|||"
)]
[IsoId("_oOlvsYv6EeumSPwlS1PkxQ")]
[DisplayName("Key Exchange Initiation V")]
public record KeyExchangeInitiationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "canm.003.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "KeyXchgInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.003.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_oOlvs4v6EeumSPwlS1PkxQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header63 Header { get; init; }

    /// <summary>
    /// Information related to a key exchange activity.
    /// </summary>
    [IsoId("_oOlvtYv6EeumSPwlS1PkxQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required KeyExchangeInitiation2 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_oOlvt4v6EeumSPwlS1PkxQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since KeyExchangeInitiationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to KeyExchangeInitiationV03.
