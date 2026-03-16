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
[IsoId("_D9PWV_fXEeiNZp_PtLohLw")]
[DisplayName("Linkages")]
public record Linkages56
{
    /// <summary>
    /// Specifies when the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_D9PWW_fXEeiNZp_PtLohLw")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition18Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_D9PWY_fXEeiNZp_PtLohLw")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber16Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_D9PWa_fXEeiNZp_PtLohLw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References66Choice_ Reference { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_D9PWc_fXEeiNZp_PtLohLw")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification136Choice_? ReferenceOwner { get; init; }
}
