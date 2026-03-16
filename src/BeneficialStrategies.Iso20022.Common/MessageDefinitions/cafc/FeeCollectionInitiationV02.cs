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

namespace BeneficialStrategies.Iso20022.cafc;

/// <summary>
/// This record is an implementation of the cafc.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FeeCollectionInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) to claim or pay a miscellaneous service between financial institutions. Fee collection messages have financial impacts and affect reconciliation totals without affecting a cardholder account.
///
///
/// </summary>
[Description(
    @"The FeeCollectionInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer) to claim or pay a miscellaneous service between financial institutions. Fee collection messages have financial impacts and affect reconciliation totals without affecting a cardholder account.||"
)]
[IsoId("_3auewYaAEeuSbct6WWD-Ng")]
[DisplayName("Fee Collection Initiation V")]
public record FeeCollectionInitiationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cafc.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FeeColltnInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafc.001.001.02";

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
    /// ISO 8583 MTI
    /// </summary>
    [IsoId("_3avF0YaAEeuSbct6WWD-Ng")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header66 Header { get; init; }

    /// <summary>
    /// Information related to the initiation of a fee collection.
    /// </summary>
    [IsoId("_3avF04aAEeuSbct6WWD-Ng")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required FeeCollectionInitiation2 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// It corresponds partially to ISO 8583 field number 53, completed by the field number 64 or 128.
    /// </summary>
    [IsoId("_3avF1YaAEeuSbct6WWD-Ng")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since FeeCollectionInitiationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FeeCollectionInitiationV02.
