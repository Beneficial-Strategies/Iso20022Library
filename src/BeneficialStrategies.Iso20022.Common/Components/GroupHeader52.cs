// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader52"/>
[IsoId("_s7DwoVkyEeGeoaLUQk__nA_-1533000831")]
[DisplayName("Group Header")]
public partial record GroupHeader52
{
    /// <inheritdoc cref="IGroupHeader52.MessageIdentification"/>
    [IsoId("_s7DwolkyEeGeoaLUQk__nA_471150646")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader52.CreationDateTime"/>
    [IsoId("_s7Dwo1kyEeGeoaLUQk__nA_998146589")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader52.InitiatingParty"/>
    [IsoId("_s7M6kFkyEeGeoaLUQk__nA_-1974630847")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader52.ForwardingAgent"/>
    [IsoId("_s7M6kVkyEeGeoaLUQk__nA_2052407163")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader52.DebtorAgent"/>
    [IsoId("_s7M6klkyEeGeoaLUQk__nA_2014421120")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader52.CreditorAgent"/>
    [IsoId("_s7M6k1kyEeGeoaLUQk__nA_84480221")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }
}
