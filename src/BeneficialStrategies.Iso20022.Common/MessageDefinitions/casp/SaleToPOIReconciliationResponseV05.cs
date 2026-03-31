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
/// This record is an implementation of the casp.004.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIReconciliationResponse message is sent by a POI to provide the result of reconciliation process between sale and POI systems.
/// </summary>
[Description(
    @"The SaleToPOIReconciliationResponse message is sent by a POI to provide the result of reconciliation process between sale and POI systems."
)]
[IsoId("_qanOsXO7Ee2pK6udhxEaHA")]
[DisplayName("Sale To POI Reconciliation Response V")]
public record SaleToPOIReconciliationResponseV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.004.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRcncltnRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.05";

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
    [IsoId("_qanOs3O7Ee2pK6udhxEaHA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header41 Header { get; init; }

    /// <summary>
    /// Information related to the response of a reconciliation request.
    /// </summary>
    [IsoId("_qanOtXO7Ee2pK6udhxEaHA")]
    [DisplayName("Reconciliation Response")]
    [IsoXmlTag("RcncltnRspn")]
    public required ReconciliationResponse8 ReconciliationResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_qanOt3O7Ee2pK6udhxEaHA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType33? SecurityTrailer { get; init; }
}

// Since SaleToPOIReconciliationResponseV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SaleToPOIReconciliationResponseV05.
