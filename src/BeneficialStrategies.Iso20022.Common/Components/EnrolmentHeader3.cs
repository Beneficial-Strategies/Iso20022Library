// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Enrolment Header3.
/// </summary>
[IsoId("_yGuHATEyEe6g-ffJsqGiSA")]
[DisplayName("Enrolment Header3")]
public partial record EnrolmentHeader3
{
    #nullable enable

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; } 

    /// <summary>
    /// Initiating Party.
    /// </summary>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required RTPPartyIdentification2 InitiatingParty { get; init; } 

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; } 

    /// <summary>
    /// Message Originator.
    /// </summary>
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public RTPPartyIdentification2? MessageOriginator { get; init; } 

    /// <summary>
    /// Message Recipient.
    /// </summary>
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public RTPPartyIdentification2? MessageRecipient { get; init; } 

    
    #nullable disable
    
}
