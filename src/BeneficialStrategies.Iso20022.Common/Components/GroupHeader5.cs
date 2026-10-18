// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader5"/>
[IsoId("_PuTKDNp-Ed-ak6NoX_4Aeg_-727666484")]
[DisplayName("Group Header")]
public partial record GroupHeader5
{
    /// <inheritdoc cref="IGroupHeader5.MessageIdentification"/>
    [IsoId("_PuTKDdp-Ed-ak6NoX_4Aeg_-727666466")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader5.CreationDateTime"/>
    [IsoId("_PuTKDtp-Ed-ak6NoX_4Aeg_-727666424")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader5.InitiatingParty"/>
    [IsoId("_Puc7ANp-Ed-ak6NoX_4Aeg_-727665536")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader5.ForwardingAgent"/>
    [IsoId("_Puc7Adp-Ed-ak6NoX_4Aeg_-727665579")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader5.DebtorAgent"/>
    [IsoId("_Puc7Atp-Ed-ak6NoX_4Aeg_-727665890")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader5.CreditorAgent"/>
    [IsoId("_Puc7A9p-Ed-ak6NoX_4Aeg_-727665848")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader5.InstructingAgent"/>
    [IsoId("_Puc7BNp-Ed-ak6NoX_4Aeg_-727665985")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader5.InstructedAgent"/>
    [IsoId("_Puc7Bdp-Ed-ak6NoX_4Aeg_-727666020")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
