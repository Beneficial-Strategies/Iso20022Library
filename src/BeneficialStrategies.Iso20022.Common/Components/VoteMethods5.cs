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
[IsoId("_gf0lJzT7Ee2tRf29bleifQ")]
[DisplayName("Vote Methods")]
public record VoteMethods5
{
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_g1R3ozT7Ee2tRf29bleifQ")]
    [DisplayName("Vote Through Network")]
    [IsoXmlTag("VoteThrghNtwk")]
    public VoteThroughNetwork1Choice_? VoteThroughNetwork { get; init; }

    /// <summary>
    /// Address where the voting ballot can be sent.
    /// </summary>
    [IsoId("_g1R3pTT7Ee2tRf29bleifQ")]
    [DisplayName("Vote By Mail")]
    [IsoXmlTag("VoteByMail")]
    public MailAddress1? VoteByMail { get; init; }

    /// <summary>
    /// Electronic address, e-mail or web site, where a security holder can vote.
    /// </summary>
    [IsoId("_g1R3pzT7Ee2tRf29bleifQ")]
    [DisplayName("Electronic Vote")]
    [IsoXmlTag("ElctrncVote")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<CommunicationAddress12> ElectronicVote { get; init; } = [];

    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_g1R3qTT7Ee2tRf29bleifQ")]
    [DisplayName("Vote By Telephone")]
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteByTelephone { get; init; } = [];
}
