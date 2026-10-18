// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader36"/>
[IsoId("_P1AO9Np-Ed-ak6NoX_4Aeg_650011444")]
[DisplayName("Group Header")]
public partial record GroupHeader36
{
    /// <inheritdoc cref="IGroupHeader36.MessageIdentification"/>
    [IsoId("_P1AO9dp-Ed-ak6NoX_4Aeg_650011446")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader36.CreationDateTime"/>
    [IsoId("_P1AO9tp-Ed-ak6NoX_4Aeg_650011505")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader36.InitiatingParty"/>
    [IsoId("_P1AO99p-Ed-ak6NoX_4Aeg_650011599")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader36.ForwardingAgent"/>
    [IsoId("_P1AO-Np-Ed-ak6NoX_4Aeg_650011900")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification4? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader36.DebtorAgent"/>
    [IsoId("_P1J_8Np-Ed-ak6NoX_4Aeg_650012114")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader36.CreditorAgent"/>
    [IsoId("_P1J_8dp-Ed-ak6NoX_4Aeg_650011961")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }
}
