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
/// Vote instruction applying to resolutions added during the meeting.
/// </summary>
[IsoId("_TLJEUNp-Ed-ak6NoX_4Aeg_1597899369")]
[DisplayName("Vote Instruction For Meeting Resolution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteInstructionForMeetingResolution1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteInstructionForMeetingResolution1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteInstructionForMeetingResolution1( VoteInstructionAtMeeting1Code reqVoteIndication,NameAndAddress9 reqShareholder )
    {
        VoteIndication = reqVoteIndication;
        Shareholder = reqShareholder;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the vote recommendation for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TLJEUdp-Ed-ak6NoX_4Aeg_1597899371")]
    [DisplayName("Vote Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteIndctn")]
    #endif
    [IsoXmlTag("VoteIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VoteInstructionAtMeeting1Code VoteIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VoteInstructionAtMeeting1Code VoteIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstructionAtMeeting1Code VoteIndication { get; init; } 
    #else
    public VoteInstructionAtMeeting1Code VoteIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the name and address of the shareholder to whom the rights to vote are transferred for resolutions added during the meeting.
    /// </summary>
    [IsoId("_TLJEUtp-Ed-ak6NoX_4Aeg_1597899431")]
    [DisplayName("Shareholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Shrhldr")]
    #endif
    [IsoXmlTag("Shrhldr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NameAndAddress9 Shareholder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NameAndAddress9 Shareholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress9 Shareholder { get; init; } 
    #else
    public NameAndAddress9 Shareholder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
