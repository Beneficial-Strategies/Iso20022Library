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
[IsoId("_RC8Bsdp-Ed-ak6NoX_4Aeg_927602263")]
[DisplayName("Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Instruction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Instruction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Instruction2( System.String reqInstructionIdentification,System.String reqVoteExecutionConfirmation,SafekeepingAccount4 reqAccountDetails )
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
    [IsoId("_RC8Bstp-Ed-ak6NoX_4Aeg_927602294")]
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
    [IsoId("_RC8Bs9p-Ed-ak6NoX_4Aeg_927602324")]
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
    /// Indicates that a Vote execution confirmation is requested.
    /// </summary>
    [IsoId("_RC8BtNp-Ed-ak6NoX_4Aeg_927602634")]
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
    [IsoId("_RC8Btdp-Ed-ak6NoX_4Aeg_-496669798")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccount4 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccount4 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount4 AccountDetails { get; init; } 
    #else
    public SafekeepingAccount4 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person appointed by the security holder as proxy.
    /// </summary>
    [IsoId("_RC8Bttp-Ed-ak6NoX_4Aeg_927603271")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Proxy4? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Proxy4? Proxy { get; init; } 
    #else
    public Proxy4? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies detailed voting instructions.
    /// </summary>
    [IsoId("_RC8Bt9p-Ed-ak6NoX_4Aeg_-1103814182")]
    [DisplayName("Vote Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDtls")]
    #endif
    [IsoXmlTag("VoteDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteDetails2? VoteDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteDetails2? VoteDetails { get; init; } 
    #else
    public VoteDetails2? VoteDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or a person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_RC8BuNp-Ed-ak6NoX_4Aeg_927603219")]
    [DisplayName("Meeting Attendee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgAttndee")]
    #endif
    [IsoXmlTag("MtgAttndee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson17? MeetingAttendee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson17? MeetingAttendee { get; init; } 
    #else
    public IndividualPerson17? MeetingAttendee { get; set; } 
    #endif
    
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_RC8Budp-Ed-ak6NoX_4Aeg_927603189")]
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
