// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of the different methods that can be used to vote.
/// </summary>
[IsoId("_TjbBe9p-Ed-ak6NoX_4Aeg_1281456967")]
[DisplayName("Vote Methods")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteMethods2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Network address through which a voting party can cast its vote via a structured message.
    /// </summary>
    [IsoId("_TjbBfNp-Ed-ak6NoX_4Aeg_-1274164582")]
    [DisplayName("Vote Through Network")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteThrghNtwk")]
    #endif
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteThroughNetwork { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Specifies the address where voting ballot can be sent.
    /// </summary>
    [IsoId("_TjbBfdp-Ed-ak6NoX_4Aeg_1330434188")]
    [DisplayName("Vote By Mail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteByMail")]
    #endif
    [IsoXmlTag("VoteByMail")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> VoteByMail { get; init; } = new ValueList<PostalAddress1>(){};
    
    /// <summary>
    /// Electronic address, e-mail or website, where a security holder can vote.
    /// </summary>
    [IsoId("_TjbBftp-Ed-ak6NoX_4Aeg_-679522670")]
    [DisplayName("Electronic Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncVote")]
    #endif
    [IsoXmlTag("ElctrncVote")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<CommunicationAddress4> ElectronicVote { get; init; } = new ValueList<CommunicationAddress4>(){};
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_TjbBf9p-Ed-ak6NoX_4Aeg_-1224398306")]
    [DisplayName("Vote By Telephone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteByTel")]
    #endif
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteByTelephone { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
