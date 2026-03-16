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
[IsoId("_5xlm-ZNLEeWGlc8L7oPDIg")]
[DisplayName("Linkages")]
public record Linkages43
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_5xlm_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition10Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_5xlnBZNLEeWGlc8L7oPDIg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber6Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_5xlnDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References50Choice_ Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_5xlnFZNLEeWGlc8L7oPDIg")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity4Choice_? LinkedQuantity { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_5xlnHZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification103Choice_? ReferenceOwner { get; init; }
}
