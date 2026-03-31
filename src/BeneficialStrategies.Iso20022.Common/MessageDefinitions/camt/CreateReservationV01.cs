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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.103.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateReservation message is used to create one particular reservation by the member and managed by the transaction administrator.
/// Usage
/// Based on the criteria defined in the CreateReservation message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request.
/// </summary>
[Description(
    @"Scope|The CreateReservation message is used to create one particular reservation by the member and managed by the transaction administrator.|Usage|Based on the criteria defined in the CreateReservation message, the transaction administrator will execute or reject the requested creation and respond with a Receipt message as a reply to the request."
)]
[IsoId("_P8tokckHEem3UrxZgQhVAw")]
[DisplayName("Create Reservation V")]
public record CreateReservationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.103.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretRsvatn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.103.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_P8tol8kHEem3UrxZgQhVAw")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_P8tomckHEem3UrxZgQhVAw")]
    [DisplayName("Reservation Identification")]
    [IsoXmlTag("RsvatnId")]
    public required ReservationIdentification2 ReservationIdentification { get; init; }

    /// <summary>
    /// New reservation values.
    /// </summary>
    [IsoId("_P8tom8kHEem3UrxZgQhVAw")]
    [DisplayName("Value Set")]
    [IsoXmlTag("ValSet")]
    public required Reservation4 ValueSet { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_P8tonckHEem3UrxZgQhVAw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CreateReservationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateReservationV01.
