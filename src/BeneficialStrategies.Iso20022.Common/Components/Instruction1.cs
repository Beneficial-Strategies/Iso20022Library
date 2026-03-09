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
[IsoId("_RW6GmNp-Ed-ak6NoX_4Aeg_-1229563854")]
[DisplayName("Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Instruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Instruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Instruction1( System.String reqInstructionIdentification,System.String reqVoteExecutionConfirmation,SafekeepingAccount3 reqAccountDetails )
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
    [IsoId("_RW6Gmdp-Ed-ak6NoX_4Aeg_84667180")]
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
    [IsoId("_RXD3kNp-Ed-ak6NoX_4Aeg_84667181")]
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
    [IsoId("_RXD3kdp-Ed-ak6NoX_4Aeg_84667198")]
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
    [IsoId("_RXD3ktp-Ed-ak6NoX_4Aeg_1099288385")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccount3 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccount3 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount3 AccountDetails { get; init; } 
    #else
    public SafekeepingAccount3 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person appointed by the security holder as proxy.
    /// </summary>
    [IsoId("_RXD3k9p-Ed-ak6NoX_4Aeg_1488769519")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Proxy2? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Proxy2? Proxy { get; init; } 
    #else
    public Proxy2? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies detailed voting instructions.
    /// </summary>
    [IsoId("_RXD3lNp-Ed-ak6NoX_4Aeg_-1182245952")]
    [DisplayName("Vote Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDtls")]
    #endif
    [IsoXmlTag("VoteDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteDetails1? VoteDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteDetails1? VoteDetails { get; init; } 
    #else
    public VoteDetails1? VoteDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or a person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_RXD3ldp-Ed-ak6NoX_4Aeg_1510934648")]
    [DisplayName("Meeting Attendee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgAttndee")]
    #endif
    [IsoXmlTag("MtgAttndee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson13? MeetingAttendee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson13? MeetingAttendee { get; init; } 
    #else
    public IndividualPerson13? MeetingAttendee { get; set; } 
    #endif
    
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_RXD3ltp-Ed-ak6NoX_4Aeg_-362500258")]
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
