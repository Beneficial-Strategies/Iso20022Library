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
[IsoId("_T5L2Gtp-Ed-ak6NoX_4Aeg_1911915200")]
[DisplayName("Vote Methods")]
public partial record VoteMethods
{
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_T5L2G9p-Ed-ak6NoX_4Aeg_1983026153")]
    [DisplayName("Vote Through Network")]
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? VoteThroughNetwork { get; init; } 
    
    /// <summary>
    /// Specifies the address where voting ballot can be sent.
    /// </summary>
    [IsoId("_T5L2HNp-Ed-ak6NoX_4Aeg_2061526394")]
    [DisplayName("Vote By Mail")]
    [IsoXmlTag("VoteByMail")]
    public PostalAddress1? VoteByMail { get; init; } 
    
    /// <summary>
    /// Electronic address, e-mail or website, where a security holder can vote.
    /// </summary>
    [IsoId("_T5VAANp-Ed-ak6NoX_4Aeg_-1923137831")]
    [DisplayName("Electronic Vote")]
    [IsoXmlTag("ElctrncVote")]
    public CommunicationAddress4? ElectronicVote { get; init; } 
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_T5VAAdp-Ed-ak6NoX_4Aeg_1298606357")]
    [DisplayName("Vote By Telephone")]
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? VoteByTelephone { get; init; } 
    
    
    #nullable disable
    
}
