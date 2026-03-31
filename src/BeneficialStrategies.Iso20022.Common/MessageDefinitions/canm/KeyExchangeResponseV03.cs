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
/// This record is an implementation of the canm.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The KeyExchangeResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a KeyExchangeInitiation message.|
///
///
/// </summary>
[Description(
    @"The KeyExchangeResponse message is sent by any party to any party (acquirer, agent or issuer) in response to a KeyExchangeInitiation message.|||"
)]
[IsoId("_X7oCEYv7EeumSPwlS1PkxQ")]
[DisplayName("Key Exchange Response V")]
public record KeyExchangeResponseV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "canm.004.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "KeyXchgRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.004.001.03";

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
    [IsoId("_X7oCE4v7EeumSPwlS1PkxQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header63 Header { get; init; }

    /// <summary>
    /// Contains information pertaining to a key exchange.
    /// </summary>
    [IsoId("_X7oCFYv7EeumSPwlS1PkxQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required KeyExchangeResponse2 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_X7oCF4v7EeumSPwlS1PkxQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since KeyExchangeResponseV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to KeyExchangeResponseV03.
