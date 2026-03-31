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
[IsoId("_RzJq8SgaEey2k_sfZmJz4g")]
[DisplayName("Linkages")]
public record Linkages62
{
    /// <summary>
    /// Specifies when the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_SKsBMygaEey2k_sfZmJz4g")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition8Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_SKsBOygaEey2k_sfZmJz4g")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber5Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_SKsBQygaEey2k_sfZmJz4g")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References74Choice_ Reference { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_SKsBSygaEey2k_sfZmJz4g")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification127Choice_? ReferenceOwner { get; init; }
}
