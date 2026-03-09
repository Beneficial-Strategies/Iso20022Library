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
/// Provides information on the instruction.
/// </summary>
[IsoId("_HGObUVtiEeSwKe7KuKvXhg")]
[DisplayName("Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Instruction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Instruction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Instruction3( System.String reqInstructionIdentification,System.String reqVoteExecutionConfirmation,SafekeepingAccount6 reqAccountDetails )
    {
        InstructionIdentification = reqInstructionIdentification;
        VoteExecutionConfirmation = reqVoteExecutionConfirmation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction.
    /// </summary>
    [IsoId("_HjiCZVtiEeSwKe7KuKvXhg")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructionIdentification { get; init; } 
    #else
    public System.String InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_HjiCZ1tiEeSwKe7KuKvXhg")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RequestedExecutionDate { get; init; } 
    #else
    public System.DateTime? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that a vote execution confirmation is requested.
    /// </summary>
    [IsoId("_HjiCaVtiEeSwKe7KuKvXhg")]
    [DisplayName("Vote Execution Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteExctnConf")]
    #endif
    [IsoXmlTag("VoteExctnConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator VoteExecutionConfirmation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String VoteExecutionConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String VoteExecutionConfirmation { get; init; } 
    #else
    public System.String VoteExecutionConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_HjiCa1tiEeSwKe7KuKvXhg")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccount6 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccount6 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount6 AccountDetails { get; init; } 
    #else
    public SafekeepingAccount6 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person appointed by the security holder as proxy.
    /// </summary>
    [IsoId("_HjiCbVtiEeSwKe7KuKvXhg")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Proxy6? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Proxy6? Proxy { get; init; } 
    #else
    public Proxy6? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies detailed voting instructions.
    /// </summary>
    [IsoId("_HjiCb1tiEeSwKe7KuKvXhg")]
    [DisplayName("Vote Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDtls")]
    #endif
    [IsoXmlTag("VoteDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteDetails3? VoteDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteDetails3? VoteDetails { get; init; } 
    #else
    public VoteDetails3? VoteDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_HjiCcVtiEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Attendee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgAttndee")]
    #endif
    [IsoXmlTag("MtgAttndee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson26? MeetingAttendee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson26? MeetingAttendee { get; init; } 
    #else
    public IndividualPerson26? MeetingAttendee { get; set; } 
    #endif
    
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_HjiCc1tiEeSwKe7KuKvXhg")]
    [DisplayName("Specific Instruction Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpcfcInstrReq")]
    #endif
    [IsoXmlTag("SpcfcInstrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecificInstructionRequest1? SpecificInstructionRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecificInstructionRequest1? SpecificInstructionRequest { get; init; } 
    #else
    public SpecificInstructionRequest1? SpecificInstructionRequest { get; set; } 
    #endif
    
    
    #nullable disable
    
}
