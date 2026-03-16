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
[IsoId("_NKkV8QLGEe2X55dNQNVKfg")]
[DisplayName("Group Header")]
public record GroupHeader106
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_NYGbowLGEe2X55dNQNVKfg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the status report was created by the instructing party.
    /// </summary>
    [IsoId("_NYGbpQLGEe2X55dNQNVKfg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party initiating the creditor payment activation request. This can either be the creditor himself or the party that initiates the request on behalf of the creditor.
    /// </summary>
    [IsoId("_NYGbpwLGEe2X55dNQNVKfg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification135 InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    [IsoId("_OVJSsQLGEe2X55dNQNVKfg")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_NYGbqQLGEe2X55dNQNVKfg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_NYGbqwLGEe2X55dNQNVKfg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }
}
