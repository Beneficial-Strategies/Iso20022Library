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
[IsoId("854fd2c6-832a-4415-b38a-758257874b2c")]
[DisplayName("Linkages80")]
public record Linkages80
{
    /// <summary>
    /// Specifies the type of link and if the link is forward, backward or can be both.
    /// </summary>
    [IsoId("e16d2b91-28ef-46b0-85b3-e9fba4fecf87")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition7Choice? ProcessingPosition { get; init; }

    /// <summary>
    /// Specifies the reference of the message linked to the current message.
    /// </summary>
    [IsoId("9cb2f34e-a3d7-4b10-8462-e1b52ee3c4e7")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice? MessageNumber { get; init; }

    /// <summary>
    /// Identification of a transaction that is linked to the current transaction being reported.
    /// </summary>
    [IsoId("3a6f7e82-bc49-4f55-9d8e-e2c7d1a4f831")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References47Choice Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments associated with the linked transaction.
    /// </summary>
    [IsoId("c72d4a19-5f61-4b8e-b3c5-f9a6e2d8b0c4")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity7Choice? LinkedQuantity { get; init; }
}
