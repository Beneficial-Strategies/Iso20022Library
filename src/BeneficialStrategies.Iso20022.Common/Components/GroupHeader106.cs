// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader106"/>
[IsoId("_NKkV8QLGEe2X55dNQNVKfg")]
[DisplayName("Group Header")]
public partial record GroupHeader106
{
    /// <inheritdoc cref="IGroupHeader106.MessageIdentification"/>
    [IsoId("_NYGbowLGEe2X55dNQNVKfg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader106.CreationDateTime"/>
    [IsoId("_NYGbpQLGEe2X55dNQNVKfg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader106.InitiatingParty"/>
    [IsoId("_NYGbpwLGEe2X55dNQNVKfg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification135 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader106.ForwardingAgent"/>
    [IsoId("_OVJSsQLGEe2X55dNQNVKfg")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader106.DebtorAgent"/>
    [IsoId("_NYGbqQLGEe2X55dNQNVKfg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader106.CreditorAgent"/>
    [IsoId("_NYGbqwLGEe2X55dNQNVKfg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }
}
