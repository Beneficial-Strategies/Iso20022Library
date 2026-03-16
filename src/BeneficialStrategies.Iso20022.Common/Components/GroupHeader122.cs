// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group Header122.
/// </summary>
[IsoId("_4zjLYTEyEe6g-ffJsqGiSA")]
[DisplayName("Group Header122")]
public record GroupHeader122
{
    /// <summary>
    /// Authorisation.
    /// </summary>
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public Authorisation1Choice_? Authorisation { get; init; }

    /// <summary>
    /// Copy Indicator.
    /// </summary>
    [DisplayName("Copy Indicator")]
    [IsoXmlTag("CpyInd")]
    public CopyDuplicate1Code? CopyIndicator { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Forwarding Agent.
    /// </summary>
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification8? ForwardingAgent { get; init; }

    /// <summary>
    /// Initiating Party.
    /// </summary>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required PartyIdentification272 InitiatingParty { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Message Recipient.
    /// </summary>
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification272? MessageRecipient { get; init; }
}
