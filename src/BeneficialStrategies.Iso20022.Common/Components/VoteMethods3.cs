// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the vote methods to be used.
/// </summary>
[IsoId("_MPdpxa4jEemG7MmivSuE5g")]
[DisplayName("Vote Methods")]
public record VoteMethods3
{
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_Mm0Z064jEemG7MmivSuE5g")]
    [DisplayName("Vote Through Network")]
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteThroughNetwork { get; init; } = [];

    /// <summary>
    /// Address where the voting ballot can be sent.
    /// </summary>
    [IsoId("_Mm0Z1a4jEemG7MmivSuE5g")]
    [DisplayName("Vote By Mail")]
    [IsoXmlTag("VoteByMail")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> VoteByMail { get; init; } = [];

    /// <summary>
    /// Electronic address, e-mail or web site, where a security holder can vote.
    /// </summary>
    [IsoId("_Mm0Z164jEemG7MmivSuE5g")]
    [DisplayName("Electronic Vote")]
    [IsoXmlTag("ElctrncVote")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<CommunicationAddress11> ElectronicVote { get; init; } = [];

    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_Mm0Z2a4jEemG7MmivSuE5g")]
    [DisplayName("Vote By Telephone")]
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteByTelephone { get; init; } = [];
}
