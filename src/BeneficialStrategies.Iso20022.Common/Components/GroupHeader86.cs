// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader86"/>
[IsoId("_RILm0W49EeiU9cctagi5ow")]
[DisplayName("Group Header")]
public partial record GroupHeader86
{
    /// <inheritdoc cref="IGroupHeader86.MessageIdentification"/>
    [IsoId("_RSKpQW49EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader86.CreationDateTime"/>
    [IsoId("_RSKpQ249EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader86.InitiatingParty"/>
    [IsoId("_RSKpRW49EeiU9cctagi5ow")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification135? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader86.ForwardingAgent"/>
    [IsoId("_RSKpR249EeiU9cctagi5ow")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader86.DebtorAgent"/>
    [IsoId("_RSKpSW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader86.CreditorAgent"/>
    [IsoId("_RSKpS249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }
}
