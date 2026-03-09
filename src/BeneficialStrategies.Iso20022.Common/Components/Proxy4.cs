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
[IsoId("_T4cPN9p-Ed-ak6NoX_4Aeg_2145397537")]
[DisplayName("Proxy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proxy4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proxy4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proxy4( ProxyType2Code reqProxyType )
    {
        ProxyType = reqProxyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_T4cPONp-Ed-ak6NoX_4Aeg_2145397569")]
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
    /// Person, other than the Chairman of the meeting, assigned by the security holder as proxy.
    /// </summary>
    [IsoId("_T4cPOdp-Ed-ak6NoX_4Aeg_2145398147")]
    [DisplayName("Person Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrsnDtls")]
    #endif
    [IsoXmlTag("PrsnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson17? PersonDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson17? PersonDetails { get; init; } 
    #else
    public IndividualPerson17? PersonDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the vote instruction for the resolutions which are announced via the meeting agenda in advance of the meeting.
    /// </summary>
    [IsoId("_T4cPOtp-Ed-ak6NoX_4Aeg_2145398085")]
    [DisplayName("Vote Instruction For Agenda Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrForAgndRsltn")]
    #endif
    [IsoXmlTag("VoteInstrForAgndRsltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vote2Choice_? VoteInstructionForAgendaResolution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vote2Choice_? VoteInstructionForAgendaResolution { get; init; } 
    #else
    public Vote2Choice_? VoteInstructionForAgendaResolution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
