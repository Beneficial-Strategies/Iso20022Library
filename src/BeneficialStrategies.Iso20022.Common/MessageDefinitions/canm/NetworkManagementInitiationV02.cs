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
/// This record is an implementation of the canm.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The NetworkManagementlInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) connected to a network. It covers the range of activities that control the operating conditions of the network.|
///
///
/// </summary>
[Description(
    @"The NetworkManagementlInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) connected to a network. It covers the range of activities that control the operating conditions of the network.|||"
)]
[IsoId("_8PlKRVULEeetiruPyDPo0Q")]
[DisplayName("Network Management Initiation V")]
public record NetworkManagementInitiationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "canm.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtwkMgmtInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:canm.001.001.02";

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
    [IsoId("_8PlKSFULEeetiruPyDPo0Q")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header43 Header { get; init; }

    /// <summary>
    /// Information related to the reversal of an authorisation or financial transaction.
    /// </summary>
    [IsoId("_8PlKSVULEeetiruPyDPo0Q")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required NetworkManagementInitiation1 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_8PlKR1ULEeetiruPyDPo0Q")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since NetworkManagementInitiationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetworkManagementInitiationV02.
