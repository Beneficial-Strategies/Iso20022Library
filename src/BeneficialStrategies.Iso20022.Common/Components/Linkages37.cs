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
[IsoId("_QaEOsTnrEeWfSKvvZlhRKg")]
[DisplayName("Linkages")]
public record Linkages37
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_Q7GfBznrEeWfSKvvZlhRKg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition7Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Q7GfDznrEeWfSKvvZlhRKg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Q7GfFznrEeWfSKvvZlhRKg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References41Choice_ Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_Q7GfHznrEeWfSKvvZlhRKg")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity3Choice_? LinkedQuantity { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_Q7GfJznrEeWfSKvvZlhRKg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification92Choice_? ReferenceOwner { get; init; }
}
