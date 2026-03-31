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
/// This record is an implementation of the casp.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIAdministrativeRequest message is sent by a sale system to POI System to request for an Administrative service.
/// </summary>
[Description(
    @"The SaleToPOIAdministrativeRequest message is sent by a sale system to POI System to request for an Administrative service."
)]
[IsoId("_kjvmoQ1SEeqjM-rxn3HuXQ")]
[DisplayName("Sale To POI Administrative Request V")]
public record SaleToPOIAdministrativeRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.007.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIAdmstvReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.007.001.02";

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
    [IsoId("_kjvmow1SEeqjM-rxn3HuXQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header41 Header { get; init; }

    /// <summary>
    /// Information related to the administrative request.
    /// </summary>
    [IsoId("_kjvmpQ1SEeqjM-rxn3HuXQ")]
    [DisplayName("Administrative Request")]
    [IsoXmlTag("AdmstvReq")]
    public required AdministrativeRequest3 AdministrativeRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_kjvmpw1SEeqjM-rxn3HuXQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType21? SecurityTrailer { get; init; }
}

// Since SaleToPOIAdministrativeRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SaleToPOIAdministrativeRequestV02.
