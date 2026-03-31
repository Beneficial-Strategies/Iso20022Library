// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification and parties playing a role in a request to pay service management message.
/// </summary>
[IsoId("_UUIee-H7Eeqbls7Gk4-ckA")]
[DisplayName("Activation Header")]
public record ActivationHeader2
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_UVRG4eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_UVRG4-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party that sends the message.
    /// </summary>
    [IsoId("_UVRG5eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public RTPPartyIdentification1? MessageOriginator { get; init; }

    /// <summary>
    /// Party that receives the message.
    /// </summary>
    [IsoId("_UVRG5-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public RTPPartyIdentification1? MessageRecipient { get; init; }

    /// <summary>
    /// Party that initiates the message. This can either be the debtor himself or the party that initiates the request on behalf of the debtor.
    /// </summary>
    [IsoId("_UVRG6eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required RTPPartyIdentification1 InitiatingParty { get; init; }
}
