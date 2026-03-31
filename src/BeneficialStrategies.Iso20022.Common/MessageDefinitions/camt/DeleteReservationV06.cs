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
/// This record is an implementation of the camt.049.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|The DeleteReservation message is used to request the deletion of one particular reservation by the member and managed by the transaction administrator.|Usage|The deletion of a reservation in the system, will not only reset the reserved liquidity to zero, but also delete the reservation itself from the system: only the default reservation for the current business day remains in the system.
/// </summary>
[Description(
    @"Scope|The DeleteReservation message is used to request the deletion of one particular reservation by the member and managed by the transaction administrator.|Usage|The deletion of a reservation in the system, will not only reset the reserved liquidity to zero, but also delete the reservation itself from the system: only the default reservation for the current business day remains in the system."
)]
[IsoId("_ThNXx9b6Eeq_l4BJLVUF2Q")]
[DisplayName("Delete Reservation V")]
public record DeleteReservationV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.049.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DelRsvatn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.049.001.06";

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
    [IsoId("_ThNXzdb6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader1 MessageHeader { get; init; }

    /// <summary>
    /// Identifies the current reservation to delete.
    /// </summary>
    [IsoId("_ThNXz9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Current Reservation")]
    [IsoXmlTag("CurRsvatn")]
    public ReservationIdentification3? CurrentReservation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThNX0db6Eeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since DeleteReservationV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DeleteReservationV06.
