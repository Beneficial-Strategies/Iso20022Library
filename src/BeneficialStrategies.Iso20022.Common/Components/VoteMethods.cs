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
[IsoId("_T5L2Gtp-Ed-ak6NoX_4Aeg_1911915200")]
[DisplayName("Vote Methods")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteMethods
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
    [IsoId("_T5L2G9p-Ed-ak6NoX_4Aeg_1983026153")]
    [DisplayName("Vote Through Network")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteThrghNtwk")]
    #endif
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? VoteThroughNetwork { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VoteThroughNetwork { get; init; } 
    #else
    public System.String? VoteThroughNetwork { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the address where voting ballot can be sent.
    /// </summary>
    [IsoId("_T5L2HNp-Ed-ak6NoX_4Aeg_2061526394")]
    [DisplayName("Vote By Mail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteByMail")]
    #endif
    [IsoXmlTag("VoteByMail")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? VoteByMail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? VoteByMail { get; init; } 
    #else
    public PostalAddress1? VoteByMail { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic address, e-mail or website, where a security holder can vote.
    /// </summary>
    [IsoId("_T5VAANp-Ed-ak6NoX_4Aeg_-1923137831")]
    [DisplayName("Electronic Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncVote")]
    #endif
    [IsoXmlTag("ElctrncVote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress4? ElectronicVote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress4? ElectronicVote { get; init; } 
    #else
    public CommunicationAddress4? ElectronicVote { get; set; } 
    #endif
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_T5VAAdp-Ed-ak6NoX_4Aeg_1298606357")]
    [DisplayName("Vote By Telephone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteByTel")]
    #endif
    [IsoXmlTag("VoteByTel")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VoteByTelephone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VoteByTelephone { get; init; } 
    #else
    public System.String? VoteByTelephone { get; set; } 
    #endif
    
    
    #nullable disable
    
}
