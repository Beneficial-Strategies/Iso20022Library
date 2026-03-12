// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the vote methods to be used.
/// </summary>
[IsoId("_usSbdxrmEeyhRdHRjakS2w")]
[DisplayName("Vote Methods")]
public partial record VoteMethods4
{
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_vBAHExrmEeyhRdHRjakS2w")]
    [DisplayName("Vote Through Network")]
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteThroughNetwork { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Address where the voting ballot can be sent.
    /// </summary>
    [IsoId("_vBAHFRrmEeyhRdHRjakS2w")]
    [DisplayName("Vote By Mail")]
    [IsoXmlTag("VoteByMail")]
    public MailAddress1? VoteByMail { get; init; } 
    
    /// <summary>
    /// Electronic address, e-mail or web site, where a security holder can vote.
    /// </summary>
    [IsoId("_vBAHFxrmEeyhRdHRjakS2w")]
    [DisplayName("Electronic Vote")]
    [IsoXmlTag("ElctrncVote")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<CommunicationAddress12> ElectronicVote { get; init; } = new ValueList<CommunicationAddress12>(){};
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_vBAHGRrmEeyhRdHRjakS2w")]
    [DisplayName("Vote By Telephone")]
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteByTelephone { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
