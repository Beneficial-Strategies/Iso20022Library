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
/// Identification of a proxy appointed to represent a party authorised to vote at a shareholders meeting and proxy vote.
/// </summary>
[IsoId("_YTYy5a4cEemG7MmivSuE5g")]
[DisplayName("Proxy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proxy7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proxy7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proxy7( ProxyType2Code reqProxyType )
    {
        ProxyType = reqProxyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of proxy.
    /// </summary>
    [IsoId("_YoEpZa4cEemG7MmivSuE5g")]
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
    [IsoId("_YoEpZ64cEemG7MmivSuE5g")]
    [DisplayName("Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnDtls")]
    #endif
    [IsoXmlTag("PrsnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson39? PersonDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson39? PersonDetails { get; init; } 
    #else
    public IndividualPerson39? PersonDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Vote instructions for the resolutions that are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_YoEpaa4cEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForAgndRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vote4Choice_? VoteInstructionForAgendaResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vote4Choice_? VoteInstructionForAgendaResolution { get; init; } 
    #else
    public Vote4Choice_? VoteInstructionForAgendaResolution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
