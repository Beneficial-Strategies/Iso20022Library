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

namespace BeneficialStrategies.Iso20022.cafr;

/// <summary>
/// This record is an implementation of the cafr.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A FraudDispositionResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a FraudDispositionInitiation message.|
///
/// </summary>
[Description(
    @"A FraudDispositionResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a FraudDispositionInitiation message.||"
)]
[IsoId("_u1LEsXdnEeeKH6vrEwvLHA")]
[DisplayName("Fraud Disposition Response V")]
public record FraudDispositionResponseV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafr.004.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FrdDspstnRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafr.004.001.01";

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
    [IsoId("_u1LEs3dnEeeKH6vrEwvLHA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header48 Header { get; init; }

    /// <summary>
    /// Information related to the response of the fraud disposition.
    /// </summary>
    [IsoId("_u1LEtXdnEeeKH6vrEwvLHA")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required FraudDispositionResponse1 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_u1LEt3dnEeeKH6vrEwvLHA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since FraudDispositionResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FraudDispositionResponseV01.
