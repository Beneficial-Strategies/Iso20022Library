// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_dJb1Tzi8Eeydid5dcNPKvg")]
[DisplayName("Linkages")]
public record Linkages65
{
    /// <summary>
    /// Specifies when the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_dJb1VTi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition10Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_dJcb8Ti8Eeydid5dcNPKvg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber6Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_dJcb-Ti8Eeydid5dcNPKvg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References50Choice_ Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_dJccATi8Eeydid5dcNPKvg")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity6Choice_? LinkedQuantity { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_dJccCTi8Eeydid5dcNPKvg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification136Choice_? ReferenceOwner { get; init; }
}
