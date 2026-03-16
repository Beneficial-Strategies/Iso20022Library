// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics shared by all individual items included in the currency control message.
/// </summary>
[IsoId("_7l1ydjm6EeWDb47rJ6ki4Q")]
[DisplayName("Currency Control Header")]
public record CurrencyControlHeader3
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_7l1ydzm6EeWDb47rJ6ki4Q")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_7l1yejm6EeWDb47rJ6ki4Q")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Number of individual items contained in the message.
    /// </summary>
    [IsoId("_7l1yezm6EeWDb47rJ6ki4Q")]
    [DisplayName("Number Of Items")]
    [IsoXmlTag("NbOfItms")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfItems { get; init; }

    /// <summary>
    /// Party that initiates the instruction.
    /// </summary>
    [IsoId("_7l1yeDm6EeWDb47rJ6ki4Q")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required Party28Choice_ InitiatingParty { get; init; }

    /// <summary>
    /// Agent which forwards the message.
    /// </summary>
    [IsoId("_7l1yeTm6EeWDb47rJ6ki4Q")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }
}
