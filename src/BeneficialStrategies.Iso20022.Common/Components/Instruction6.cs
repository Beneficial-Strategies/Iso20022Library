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
/// Information about a meeting vote instruction.
/// </summary>
[IsoId("_wcR2cRrfEeyhRdHRjakS2w")]
[DisplayName("Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Instruction6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Instruction6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Instruction6( System.String reqSingleInstructionIdentification,System.String reqVoteExecutionConfirmation,SafekeepingAccount14 reqAccountDetails )
    {
        SingleInstructionIdentification = reqSingleInstructionIdentification;
        VoteExecutionConfirmation = reqVoteExecutionConfirmation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the individual instruction.
    /// </summary>
    [IsoId("_ww1xNRrfEeyhRdHRjakS2w")]
    [DisplayName("Single Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnglInstrId")]
    #endif
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SingleInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SingleInstructionIdentification { get; init; } 
    #else
    public System.String SingleInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the instruction must be executed.
    /// </summary>
    [IsoId("_ww1xNxrfEeyhRdHRjakS2w")]
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
    [IsoId("_ww1xORrfEeyhRdHRjakS2w")]
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
    [IsoId("_ww1xOxrfEeyhRdHRjakS2w")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccount14 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccount14 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccount14 AccountDetails { get; init; } 
    #else
    public SafekeepingAccount14 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_ww1xPRrfEeyhRdHRjakS2w")]
    [DisplayName("Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prxy")]
    #endif
    [IsoXmlTag("Prxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Proxy12? Proxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Proxy12? Proxy { get; init; } 
    #else
    public Proxy12? Proxy { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed voting instructions.
    /// </summary>
    [IsoId("_ww1xPxrfEeyhRdHRjakS2w")]
    [DisplayName("Vote Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDtls")]
    #endif
    [IsoXmlTag("VoteDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteDetails5? VoteDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteDetails5? VoteDetails { get; init; } 
    #else
    public VoteDetails5? VoteDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security holder who will attend and vote at the meeting in person and/or the person assigned by the security holder to attend the meeting without having any voting rights or taking any action.
    /// </summary>
    [IsoId("_ww1xQRrfEeyhRdHRjakS2w")]
    [DisplayName("Meeting Attendee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgAttndee")]
    #endif
    [IsoXmlTag("MtgAttndee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson41? MeetingAttendee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson41? MeetingAttendee { get; init; } 
    #else
    public IndividualPerson41? MeetingAttendee { get; set; } 
    #endif
    
    /// <summary>
    /// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
    /// </summary>
    [IsoId("_ww1xQxrfEeyhRdHRjakS2w")]
    [DisplayName("Specific Instruction Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpcfcInstrReq")]
    #endif
    [IsoXmlTag("SpcfcInstrReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; init; } 
    #else
    public SpecificInstructionRequest4? SpecificInstructionRequest { get; set; } 
    #endif
    
    
    #nullable disable
    
}
