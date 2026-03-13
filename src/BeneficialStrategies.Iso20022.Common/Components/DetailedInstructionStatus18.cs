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
[IsoId("__hC9MTUCEe2tRf29bleifQ")]
[DisplayName("Detailed Instruction Status")]
public partial record DetailedInstructionStatus18
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message for which the confirmation is provided.
    /// </summary>
    [IsoId("__6rlNzUCEe2tRf29bleifQ")]
    [DisplayName("Single Instruction Identification")]
    [IsoXmlTag("SnglInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the safekeeping account.
    /// </summary>
    [IsoId("__6rlOTUCEe2tRf29bleifQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("__6rlOzUCEe2tRf29bleifQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    [IsoId("__6rlPTUCEe2tRf29bleifQ")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("__6rlPzUCEe2tRf29bleifQ")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(250)]
    public ValueList<PartyIdentification246Choice_> RightsHolder { get; init; } = [];
    
    /// <summary>
    /// Identification of the person appointed by the security holder as the proxy.
    /// </summary>
    [IsoId("__6rlQTUCEe2tRf29bleifQ")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public PartyIdentification232Choice_? Proxy { get; init; } 
    
    /// <summary>
    /// Indicates whether standing instructions have been applied or not.
    /// </summary>
    [IsoId("__6rlQzUCEe2tRf29bleifQ")]
    [DisplayName("Standing Instruction")]
    [IsoXmlTag("StgInstr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StandingInstruction { get; init; } 
    
    /// <summary>
    /// Modality through which the votes that have been recorded and counted were received by the issuer, including whether this is ahead of the meeting or at the meeting.
    /// </summary>
    [IsoId("__6rlRTUCEe2tRf29bleifQ")]
    [DisplayName("Modality Of Counting")]
    [IsoXmlTag("ModltyOfCntg")]
    public required ModalityOfCounting1Choice_ ModalityOfCounting { get; init; } 
    
    /// <summary>
    /// Date or date and time at which the votes that have been recorded and counted were received.
    /// </summary>
    [IsoId("__6rlRzUCEe2tRf29bleifQ")]
    [DisplayName("Vote Receipt Date Time")]
    [IsoXmlTag("VoteRctDtTm")]
    public DateAndDateTime1Choice_? VoteReceiptDateTime { get; init; } 
    
    /// <summary>
    /// Details of the vote.
    /// </summary>
    [IsoId("__6rlSTUCEe2tRf29bleifQ")]
    [DisplayName("Vote Per Resolution")]
    [IsoXmlTag("VotePerRsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Vote17> VotePerResolution { get; init; } = [];
    
    
    #nullable disable
    
}
