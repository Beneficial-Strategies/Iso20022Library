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

namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.025.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AddendumInitiation message is sent by an acquirer or an agent to an issuer to provide supplemental data in addition to that which is required to complete an authorization initiation or financial initiation.
///
/// The supplemental data is associated with an authorization or financial message.
/// </summary>
[Description(
    @"The AddendumInitiation message is sent by an acquirer or an agent to an issuer to provide supplemental data in addition to that which is required to complete an authorization initiation or financial initiation. ||The supplemental data is associated with an authorization or financial message."
)]
[IsoId("_RHEuodkcEeizh_fAW7LywQ")]
[DisplayName("Addendum Initiation V")]
public record AddendumInitiationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.025.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AdddmInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.025.001.01";

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
    [IsoId("_RHF8wdkcEeizh_fAW7LywQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header48 Header { get; init; }

    /// <summary>
    /// The AddendumInitiation is used to provide supplemental data in addition to that which is required to complete an authorization initiation or financial initiation. The supplemental data is associated with an authorization or financial message.
    /// </summary>
    [IsoId("_61gpsNkeEeizh_fAW7LywQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public AddendumInitiation1? Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_RHF8xdkcEeizh_fAW7LywQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since AddendumInitiationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AddendumInitiationV01.
