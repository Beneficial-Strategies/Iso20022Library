// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a meeting instruction vote.
/// </summary>
[IsoId("_hZw3RxuUEeyhRdHRjakS2w")]
[DisplayName("Detailed Instruction Status")]
public partial record DetailedInstructionStatus17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message for which the confirmation is provided.
    /// </summary>
    [IsoId("_hvOJ5xuUEeyhRdHRjakS2w")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the safekeeping account.
    /// </summary>
    [IsoId("_hvOJ6RuUEeyhRdHRjakS2w")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_hvOJ6xuUEeyhRdHRjakS2w")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_hvOJ7RuUEeyhRdHRjakS2w")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_hvOJ7xuUEeyhRdHRjakS2w")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(250)]
    public ValueList<PartyIdentification237Choice_> RightsHolder { get; init; } = new ValueList<PartyIdentification237Choice_>(){};
    
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("_hvOJ8RuUEeyhRdHRjakS2w")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public PartyIdentification232Choice_? Proxy { get; init; } 
    
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("_hvOJ8xuUEeyhRdHRjakS2w")]
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StandingInstruction { get; init; } 
    
    /// <summary>
    /// Modality through which the votes that have been recorded and counted were received by the issuer, including whether this is ahead of the meeting or at the meeting.
    /// </summary>
    [IsoId("_hvOJ9RuUEeyhRdHRjakS2w")]
    [DisplayName("Modality Of Counting")]
    [IsoXmlTag("ModltyOfCntg")]
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; } 
    
    /// <summary>
    /// Date or date and time at which the votes that have been recorded and counted were received.
    /// </summary>
    [IsoId("_hvOJ9xuUEeyhRdHRjakS2w")]
    [DisplayName("Vote Receipt Date Time")]
    [IsoXmlTag("VoteRctDtTm")]
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; } 
    
    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("_hvOJ-RuUEeyhRdHRjakS2w")]
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Vote13> VotePerResolution { get; init; } = new ValueList<Vote13>(){};
    
    
    #nullable disable
    
}
