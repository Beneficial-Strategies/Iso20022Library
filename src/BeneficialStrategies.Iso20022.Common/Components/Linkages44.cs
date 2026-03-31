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
[IsoId("_6GWWVZNLEeWGlc8L7oPDIg")]
[DisplayName("Linkages")]
public record Linkages44
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_6GWWV5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition18Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_6GWWX5NLEeWGlc8L7oPDIg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber16Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_6GWWZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References54Choice_ Reference { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_6GWWb5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification103Choice_? ReferenceOwner { get; init; }
}
