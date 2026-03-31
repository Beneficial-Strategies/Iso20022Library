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
[IsoId("_YLVBYdLCEeiN28wlpBQScw")]
[DisplayName("Linkages")]
public record Linkages54
{
    /// <summary>
    /// Specifies when the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_Ycb_hdLCEeiN28wlpBQScw")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition7Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Ycb_jdLCEeiN28wlpBQScw")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Ycb_ldLCEeiN28wlpBQScw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References41Choice_ Reference { get; init; }

    /// <summary>
    /// Quantity of financial instruments of the linked transaction to be paired-off or turned.
    /// </summary>
    [IsoId("_Ycb_ndLCEeiN28wlpBQScw")]
    [DisplayName("Linked Quantity")]
    [IsoXmlTag("LkdQty")]
    public PairedOrTurnedQuantity3Choice_? LinkedQuantity { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_Ycb_pdLCEeiN28wlpBQScw")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification127Choice_? ReferenceOwner { get; init; }
}
