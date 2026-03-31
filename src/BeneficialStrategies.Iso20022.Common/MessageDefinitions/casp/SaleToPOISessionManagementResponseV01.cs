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

namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This record is an implementation of the casp.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// This message is a response for several kind of Administrative services related to Session Management that the Sale System (Merchant I.S.) can send to the POI system (Card Acceptor system)
/// </summary>
[Description(
    @"This message is a response for several kind of Administrative services related to Session Management that the Sale System (Merchant I.S.) can send to the POI system (Card Acceptor system)"
)]
[IsoId("_LLp_4YYBEemxIqbaFEE8-w")]
[DisplayName("Sale To POI Session Management Response V")]
public record SaleToPOISessionManagementResponseV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.006.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISsnMgmtRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.006.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_LLp_44YBEemxIqbaFEE8-w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header37 Header { get; init; }

    /// <summary>
    /// Information related to the response of a session management request.
    /// </summary>
    [IsoId("_LLp_5YYBEemxIqbaFEE8-w")]
    [DisplayName("Session Management Response")]
    [IsoXmlTag("SsnMgmtRspn")]
    public required SessionManagementResponse2 SessionManagementResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_LLp_54YBEemxIqbaFEE8-w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType18? SecurityTrailer { get; init; }
}

// Since SaleToPOISessionManagementResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SaleToPOISessionManagementResponseV01.
