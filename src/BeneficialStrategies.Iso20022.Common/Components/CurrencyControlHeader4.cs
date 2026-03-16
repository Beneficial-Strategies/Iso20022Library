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
[IsoId("_73tS0W48EeiU9cctagi5ow")]
[DisplayName("Currency Control Header")]
public record CurrencyControlHeader4
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_8BF4UW48EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_8BF4U248EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Number of individual items contained in the message.
    /// </summary>
    [IsoId("_8BF4VW48EeiU9cctagi5ow")]
    [DisplayName("Number Of Items")]
    [IsoXmlTag("NbOfItms")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfItems { get; init; }

    /// <summary>
    /// Party that initiates the instruction.
    /// </summary>
    [IsoId("_8BF4V248EeiU9cctagi5ow")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification135 InitiatingParty { get; init; }

    /// <summary>
    /// Agent which forwards the message.
    /// </summary>
    [IsoId("_8BF4WW48EeiU9cctagi5ow")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; }
}
