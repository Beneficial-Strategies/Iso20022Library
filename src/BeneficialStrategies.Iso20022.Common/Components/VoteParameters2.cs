// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing how the voting process is organised.
/// </summary>
[IsoId("_TknUSNp-Ed-ak6NoX_4Aeg_800280634")]
[DisplayName("Vote Parameters")]
public partial record VoteParameters2
{
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_TknUSdp-Ed-ak6NoX_4Aeg_800280636")]
    [DisplayName("Securities Quantity Required To Vote")]
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? SecuritiesQuantityRequiredToVote { get; init; } 
    
    /// <summary>
    /// Specifies whether it is allowed to only vote on a part of the entire holding, leaving part of the position un-voted.
    /// </summary>
    [IsoId("_TknUStp-Ed-ak6NoX_4Aeg_800280695")]
    [DisplayName("Partial Vote Allowed")]
    [IsoXmlTag("PrtlVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 
    
    /// <summary>
    /// Specifies whether it is allowed to vote in different directions for the entire holding.
    /// </summary>
    [IsoId("_TkxFQNp-Ed-ak6NoX_4Aeg_800280756")]
    [DisplayName("Split Vote Allowed")]
    [IsoXmlTag("SpltVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    [IsoId("_TkxFQdp-Ed-ak6NoX_4Aeg_800280787")]
    [DisplayName("Vote Deadline")]
    [IsoXmlTag("VoteDdln")]
    public DateFormat2Choice_? VoteDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary (STP mode).
    /// </summary>
    [IsoId("_TkxFQtp-Ed-ak6NoX_4Aeg_800280848")]
    [DisplayName("Vote STP Deadline")]
    [IsoXmlTag("VoteSTPDdln")]
    public DateFormat2Choice_? VoteSTPDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_TkxFQ9p-Ed-ak6NoX_4Aeg_800281096")]
    [DisplayName("Vote Market Deadline")]
    [IsoXmlTag("VoteMktDdln")]
    public DateFormat2Choice_? VoteMarketDeadline { get; init; } 
    
    /// <summary>
    /// Indicates the different methods that can be used to vote.
    /// </summary>
    [IsoId("_TkxFRNp-Ed-ak6NoX_4Aeg_800281682")]
    [DisplayName("Vote Methods")]
    [IsoXmlTag("VoteMthds")]
    public VoteMethods? VoteMethods { get; init; } 
    
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_TkxFRdp-Ed-ak6NoX_4Aeg_800281651")]
    [DisplayName("Voting Ballot Electronic Address")]
    [IsoXmlTag("VtngBlltElctrncAdr")]
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; } 
    
    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_TkxFRtp-Ed-ak6NoX_4Aeg_800281735")]
    [DisplayName("Voting Ballot Request Address")]
    [IsoXmlTag("VtngBlltReqAdr")]
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_TkxFR9p-Ed-ak6NoX_4Aeg_800281558")]
    [DisplayName("Revocability Deadline")]
    [IsoXmlTag("RvcbltyDdln")]
    public DateFormat2Choice_? RevocabilityDeadline { get; init; } 
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_TkxFSNp-Ed-ak6NoX_4Aeg_800281589")]
    [DisplayName("Revocability STP Deadline")]
    [IsoXmlTag("RvcbltySTPDdln")]
    public DateFormat2Choice_? RevocabilitySTPDeadline { get; init; } 
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TkxFSdp-Ed-ak6NoX_4Aeg_800281611")]
    [DisplayName("Revocability Market Deadline")]
    [IsoXmlTag("RvcbltyMktDdln")]
    public DateFormat2Choice_? RevocabilityMarketDeadline { get; init; } 
    
    /// <summary>
    /// Indicates whether beneficiary details (eg name and address) must be supplied in order to take part to a meeting.
    /// </summary>
    [IsoId("_Tk62QNp-Ed-ak6NoX_4Aeg_800281157")]
    [DisplayName("Beneficial Owner Disclosure")]
    [IsoXmlTag("BnfclOwnrDsclsr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; } 
    
    /// <summary>
    /// Identifies the possible types of voting instructions. When used at the resolution level, it supersedes the value specified in the meeting notice.
    /// </summary>
    [IsoId("_Tk62Qdp-Ed-ak6NoX_4Aeg_800281188")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = new SimpleValueList<VoteInstruction2Code>(){};
    
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_Tk62Qtp-Ed-ak6NoX_4Aeg_800282075")]
    [DisplayName("Incentive Premium")]
    [IsoXmlTag("IncntivPrm")]
    public IncentivePremium3? IncentivePremium { get; init; } 
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_Tk62Q9p-Ed-ak6NoX_4Aeg_800281218")]
    [DisplayName("Vote With Premium Deadline")]
    [IsoXmlTag("VoteWthPrmDdln")]
    public DateFormat2Choice_? VoteWithPremiumDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium (STP mode).
    /// </summary>
    [IsoId("_Tk62RNp-Ed-ak6NoX_4Aeg_800281249")]
    [DisplayName("Vote With Premium STP Deadline")]
    [IsoXmlTag("VoteWthPrmSTPDdln")]
    public DateFormat2Choice_? VoteWithPremiumSTPDeadline { get; init; } 
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_Tk62Rdp-Ed-ak6NoX_4Aeg_800281527")]
    [DisplayName("Vote With Premium Market Deadline")]
    [IsoXmlTag("VoteWthPrmMktDdln")]
    public DateFormat2Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_Tk62Rtp-Ed-ak6NoX_4Aeg_800281126")]
    [DisplayName("Additional Voting Requirements")]
    [IsoXmlTag("AddtlVtngRqrmnts")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 
    
    
    #nullable disable
    
}
