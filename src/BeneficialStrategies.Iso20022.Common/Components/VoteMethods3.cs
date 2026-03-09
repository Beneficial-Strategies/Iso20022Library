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
/// Information about the vote methods to be used.
/// </summary>
[IsoId("_MPdpxa4jEemG7MmivSuE5g")]
[DisplayName("Vote Methods")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteMethods3
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
    [IsoId("_Mm0Z064jEemG7MmivSuE5g")]
    [DisplayName("Vote Through Network")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteThrghNtwk")]
    #endif
    [IsoXmlTag("VoteThrghNtwk")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> VoteThroughNetwork { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Address where the voting ballot can be sent.
    /// </summary>
    [IsoId("_Mm0Z1a4jEemG7MmivSuE5g")]
    [DisplayName("Vote By Mail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteByMail")]
    #endif
    [IsoXmlTag("VoteByMail")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> VoteByMail { get; init; } = new ValueList<PostalAddress1>(){};
    
    /// <summary>
    /// Electronic address, e-mail or web site, where a security holder can vote.
    /// </summary>
    [IsoId("_Mm0Z164jEemG7MmivSuE5g")]
    [DisplayName("Electronic Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncVote")]
    #endif
    [IsoXmlTag("ElctrncVote")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<CommunicationAddress11> ElectronicVote { get; init; } = new ValueList<CommunicationAddress11>(){};
    
    /// <summary>
    /// Telephone number providing access to an automated voting system.
    /// </summary>
    [IsoId("_Mm0Z2a4jEemG7MmivSuE5g")]
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
