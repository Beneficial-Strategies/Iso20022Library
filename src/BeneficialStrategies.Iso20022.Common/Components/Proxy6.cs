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
/// Specifies the elements that identify a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
[IsoId("_aIcvEVtiEeSwKe7KuKvXhg")]
[DisplayName("Proxy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proxy6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proxy6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proxy6( ProxyType2Code reqProxyType )
    {
        ProxyType = reqProxyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_ampuBVtiEeSwKe7KuKvXhg")]
    [DisplayName("Proxy Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyTp")]
    #endif
    [IsoXmlTag("PrxyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProxyType2Code ProxyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProxyType2Code ProxyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProxyType2Code ProxyType { get; init; } 
    #else
    public ProxyType2Code ProxyType { get; set; } 
    #endif
    
    /// <summary>
    /// Person, other than the chairman of the meeting, assigned by the security holder as the proxy.
    /// </summary>
    [IsoId("_ampuB1tiEeSwKe7KuKvXhg")]
    [DisplayName("Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnDtls")]
    #endif
    [IsoXmlTag("PrsnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson26? PersonDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson26? PersonDetails { get; init; } 
    #else
    public IndividualPerson26? PersonDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_ampuCVtiEeSwKe7KuKvXhg")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForAgndRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vote3Choice_? VoteInstructionForAgendaResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vote3Choice_? VoteInstructionForAgendaResolution { get; init; } 
    #else
    public Vote3Choice_? VoteInstructionForAgendaResolution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
