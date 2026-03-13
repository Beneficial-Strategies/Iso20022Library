// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of the different methods that can be used to vote.
/// </summary>
[IsoId("_TjbBe9p-Ed-ak6NoX_4Aeg_1281456967")]
[DisplayName("Vote Methods")]
public partial record VoteMethods2
{
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_TjbBfNp-Ed-ak6NoX_4Aeg_-1274164582")]
    [DisplayName("Vote Through Network")]
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteThroughNetwork { get; init; } = [];
    
    /// <summary>
    /// Specifies the address where voting ballot can be sent.
    /// </summary>
    [IsoId("_TjbBfdp-Ed-ak6NoX_4Aeg_1330434188")]
    [DisplayName("Vote By Mail")]
    [IsoXmlTag("VoteByMail")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> VoteByMail { get; init; } = [];
    
    /// <summary>
    /// Electronic address, e-mail or website, where a security holder can vote.
    /// </summary>
    [IsoId("_TjbBftp-Ed-ak6NoX_4Aeg_-679522670")]
    [DisplayName("Electronic Vote")]
    [IsoXmlTag("ElctrncVote")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<CommunicationAddress4> ElectronicVote { get; init; } = [];
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_TjbBf9p-Ed-ak6NoX_4Aeg_-1224398306")]
    [DisplayName("Vote By Telephone")]
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteByTelephone { get; init; } = [];
    
    
    #nullable disable
    
}
