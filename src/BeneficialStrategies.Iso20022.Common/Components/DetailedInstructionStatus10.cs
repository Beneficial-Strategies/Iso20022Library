// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
[IsoId("_qwFXEVtfEeSwKe7KuKvXhg")]
[DisplayName("Detailed Instruction Status")]
public partial record DetailedInstructionStatus10
{
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction with an instruction message.
    /// </summary>
    [IsoId("_rN_bF1tfEeSwKe7KuKvXhg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    [IsoId("_rN_bGVtfEeSwKe7KuKvXhg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_rN_bG1tfEeSwKe7KuKvXhg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification40Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [IsoId("_rN_bHVtfEeSwKe7KuKvXhg")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_rN_bH1tfEeSwKe7KuKvXhg")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<PartyIdentification40Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification40Choice_>(){};
    
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_rN_bIVtfEeSwKe7KuKvXhg")]
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator StandingInstruction { get; init; } 
    
    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_rN_bI1tfEeSwKe7KuKvXhg")]
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Vote6> VotePerResolution { get; init; } = new ValueList<Vote6>(){};
    
    
    #nullable disable
    
}
