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

namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A terminal manager requests to the master terminal manager the delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager.
/// </summary>
[Description(
    @"A terminal manager requests to the master terminal manager the delegation of maintenance functions or maintenance operation on the terminal estate managed by the master terminal manager."
)]
[IsoId("_RRRwEGp2EeSojYXQbRlLzA")]
[DisplayName("Maintenance Delegation Request V")]
public record MaintenanceDelegationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.005.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MntncDlgtnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.005.001.01";

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
    [IsoId("_825hIGp2EeSojYXQbRlLzA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header16 Header { get; init; }

    /// <summary>
    /// Information related to the request of maintenance delegations.
    /// </summary>
    [IsoId("_jVQoAGp4EeSojYXQbRlLzA")]
    [DisplayName("Maintenance Delegation Request")]
    [IsoXmlTag("MntncDlgtnReq")]
    public required MaintenanceDelegationRequest1 MaintenanceDelegationRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_xgIyUGp4EeSojYXQbRlLzA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType12 SecurityTrailer { get; init; }
}

// Since MaintenanceDelegationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MaintenanceDelegationRequestV01.
