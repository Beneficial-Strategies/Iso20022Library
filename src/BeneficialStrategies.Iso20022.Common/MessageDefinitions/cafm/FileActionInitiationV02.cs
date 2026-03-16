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

namespace BeneficialStrategies.Iso20022.cafm;

/// <summary>
/// This record is an implementation of the cafm.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FileActionInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer).
///
/// This message is used to inquire, add, change, delete or replace a file or a record.
/// </summary>
[Description(
    @"The FileActionInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer).||This message is used to inquire, add, change, delete or replace a file or a record."
)]
[IsoId("_LQXFYIKwEeu4svNQ5N-l6w")]
[DisplayName("File Action Initiation V")]
public record FileActionInitiationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafm.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FileActnInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafm.001.001.02";

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
    [IsoId("_LQXFYoKwEeu4svNQ5N-l6w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header68 Header { get; init; }

    /// <summary>
    /// Information related to the initiation of a file action.
    /// </summary>
    [IsoId("_LQXFZIKwEeu4svNQ5N-l6w")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required FileActionInitiation2 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_LQXFZoKwEeu4svNQ5N-l6w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since FileActionInitiationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FileActionInitiationV02.
