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
[IsoId("_Qr1wV9p-Ed-ak6NoX_4Aeg_-2084291941")]
[DisplayName("Linkages")]
public record Linkages1
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_Qr1wWNp-Ed-ak6NoX_4Aeg_591092707")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Qr1wWdp-Ed-ak6NoX_4Aeg_-1941270849")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Qr_hUNp-Ed-ak6NoX_4Aeg_1540404328")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References1Choice_ Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_Qr_hUdp-Ed-ak6NoX_4Aeg_1492110792")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity1Choice_? LinkedQuantity { get; init; }
}
