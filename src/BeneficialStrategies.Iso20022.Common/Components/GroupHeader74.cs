// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader74"/>
[IsoId("_on_U0bTgEeef0oKPLRNatg")]
[DisplayName("Group Header")]
public partial record GroupHeader74
{
    /// <inheritdoc cref="IGroupHeader74.MessageIdentification"/>
    [IsoId("_ov3ecbTgEeef0oKPLRNatg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader74.CreationDateTime"/>
    [IsoId("_ov3ec7TgEeef0oKPLRNatg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader74.InitiatingParty"/>
    [IsoId("_ov3edbTgEeef0oKPLRNatg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification125? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader74.ForwardingAgent"/>
    [IsoId("_ov3ed7TgEeef0oKPLRNatg")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader74.DebtorAgent"/>
    [IsoId("_ov3eebTgEeef0oKPLRNatg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader74.CreditorAgent"/>
    [IsoId("_ov3ee7TgEeef0oKPLRNatg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }
}
