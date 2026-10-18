// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader46"/>
[IsoId("_UQlCcdp-Ed-ak6NoX_4Aeg_-1988631022")]
[DisplayName("Group Header")]
public partial record GroupHeader46
{
    /// <inheritdoc cref="IGroupHeader46.MessageIdentification"/>
    [IsoId("_UQuMUNp-Ed-ak6NoX_4Aeg_341097321")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader46.CreationDateTime"/>
    [IsoId("_UQuMUdp-Ed-ak6NoX_4Aeg_-1616610734")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader46.InitiatingParty"/>
    [IsoId("_UQuMUtp-Ed-ak6NoX_4Aeg_506093184")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification43 InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader46.DebtorAgent"/>
    [IsoId("_UQuMU9p-Ed-ak6NoX_4Aeg_265072609")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader46.CreditorAgent"/>
    [IsoId("_UQuMVNp-Ed-ak6NoX_4Aeg_253973832")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }
}
