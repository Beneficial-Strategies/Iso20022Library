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
[IsoId("_38duYfk7Ed-0eapN4XNkgg")]
[DisplayName("Linkages")]
public record Linkages10
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_38m4Ufk7Ed-0eapN4XNkgg")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition2Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_38m4U_k7Ed-0eapN4XNkgg")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_38m4Vfk7Ed-0eapN4XNkgg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References13Choice_ Reference { get; init; }

    /// <summary>
    /// Party that generates the reference.
    /// </summary>
    [IsoId("_-_N_cPk7Ed-0eapN4XNkgg")]
    [DisplayName("Reference Owner")]
    [IsoXmlTag("RefOwnr")]
    public PartyIdentification36Choice_? ReferenceOwner { get; init; }
}
