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
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
[IsoId("_qwFXEVtfEeSwKe7KuKvXhg")]
[DisplayName("Detailed Instruction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedInstructionStatus10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedInstructionStatus10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedInstructionStatus10( System.String reqInstructionIdentification,System.String reqStandingInstruction )
    {
        InstructionIdentification = reqInstructionIdentification;
        StandingInstruction = reqStandingInstruction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction with an instruction message.
    /// </summary>
    [IsoId("_rN_bF1tfEeSwKe7KuKvXhg")]
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
    /// Identifies the safekeeping account.
    /// </summary>
    [IsoId("_rN_bGVtfEeSwKe7KuKvXhg")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_rN_bG1tfEeSwKe7KuKvXhg")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification40Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [IsoId("_rN_bHVtfEeSwKe7KuKvXhg")]
    [DisplayName("Sub Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctId")]
    #endif
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubAccountIdentification { get; init; } 
    #else
    public System.String? SubAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_rN_bH1tfEeSwKe7KuKvXhg")]
    [DisplayName("Rights Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtsHldr")]
    #endif
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification40Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification40Choice_>(){};
    
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_rN_bIVtfEeSwKe7KuKvXhg")]
    [DisplayName("Standing Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StgInstr")]
    #endif
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator StandingInstruction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StandingInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StandingInstruction { get; init; } 
    #else
    public System.String StandingInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_rN_bI1tfEeSwKe7KuKvXhg")]
    [DisplayName("Vote Per Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VotePerRsltn")]
    #endif
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Vote6> VotePerResolution { get; init; } = new ValueList<Vote6>(){};
    
    
    #nullable disable
    
}
