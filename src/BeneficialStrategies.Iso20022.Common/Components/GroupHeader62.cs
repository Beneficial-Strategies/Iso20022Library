// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_aYOyMaCmEeKBuYKLDCCgNQ")]
[DisplayName("Group Header")]
public record GroupHeader62
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_aiW-laCmEeKBuYKLDCCgNQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_aiW-nKCmEeKBuYKLDCCgNQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_aiW-o6CmEeKBuYKLDCCgNQ")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_aiW-qqCmEeKBuYKLDCCgNQ")]
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    public CopyDuplicate1Code? CopyIndicator { get; init; }

    /// <summary>
    /// Party that initiates the payment.||Usage: This can either be the debtor or the party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    [IsoId("_aiW-saCmEeKBuYKLDCCgNQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; }

    /// <summary>
    /// Party authorised by the account owner to receive information about movements on the account.
    /// </summary>
    [IsoId("_aiW-uKCmEeKBuYKLDCCgNQ")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification43? MessageRecipient { get; init; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    [IsoId("_aiW-v6CmEeKBuYKLDCCgNQ")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }
}
