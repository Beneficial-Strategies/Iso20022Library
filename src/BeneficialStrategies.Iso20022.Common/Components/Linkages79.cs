// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to linkages between transactions.
/// </summary>
[IsoId("e4b43370-aa8a-4163-a51a-8816d9b059ff")]
[DisplayName("Linkages79")]
public record Linkages79
{
    /// <summary>
    /// Specifies the type of link and if the link is forward, backward or can be both.
    /// </summary>
    [IsoId("58fb36dc-9b11-42ff-a3b3-9e55a56caab1")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition7Choice? ProcessingPosition { get; init; }

    /// <summary>
    /// Specifies the reference of the message linked to the current message.
    /// </summary>
    [IsoId("5a78fe00-e27c-44ed-a1c7-4c54e70c1dff")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice? MessageNumber { get; init; }

    /// <summary>
    /// Identification of a transaction that is linked to the current transaction being reported.
    /// </summary>
    [IsoId("b5cca6ec-fc25-4f16-bcec-a6cf8edd4dcf")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References41Choice Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments associated with the linked transaction.
    /// </summary>
    [IsoId("ee8e9e30-c949-4264-ad8e-a1fce5ff3a29")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity7Choice? LinkedQuantity { get; init; }

    /// <summary>
    /// Party that maintains the link in its books or system.
    /// </summary>
    [IsoId("a4db2028-e97d-47c0-b12b-c75e6d42df90")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification127Choice? ReferenceOwner { get; init; }
}
