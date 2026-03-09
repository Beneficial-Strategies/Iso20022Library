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
/// Information describing how the voting process is organised.
/// </summary>
[IsoId("_TknUSNp-Ed-ak6NoX_4Aeg_800280634")]
[DisplayName("Vote Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteParameters2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteParameters2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteParameters2( System.String reqPartialVoteAllowed,System.String reqSplitVoteAllowed,System.String reqBeneficialOwnerDisclosure )
    {
        PartialVoteAllowed = reqPartialVoteAllowed;
        SplitVoteAllowed = reqSplitVoteAllowed;
        BeneficialOwnerDisclosure = reqBeneficialOwnerDisclosure;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_TknUSdp-Ed-ak6NoX_4Aeg_800280636")]
    [DisplayName("Securities Quantity Required To Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyReqrdToVote")]
    #endif
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? SecuritiesQuantityRequiredToVote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SecuritiesQuantityRequiredToVote { get; init; } 
    #else
    public System.UInt64? SecuritiesQuantityRequiredToVote { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is allowed to only vote on a part of the entire holding, leaving part of the position un-voted.
    /// </summary>
    [IsoId("_TknUStp-Ed-ak6NoX_4Aeg_800280695")]
    [DisplayName("Partial Vote Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlVoteAllwd")]
    #endif
    [IsoXmlTag("PrtlVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PartialVoteAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PartialVoteAllowed { get; init; } 
    #else
    public System.String PartialVoteAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is allowed to vote in different directions for the entire holding.
    /// </summary>
    [IsoId("_TkxFQNp-Ed-ak6NoX_4Aeg_800280756")]
    [DisplayName("Split Vote Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltVoteAllwd")]
    #endif
    [IsoXmlTag("SpltVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SplitVoteAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SplitVoteAllowed { get; init; } 
    #else
    public System.String SplitVoteAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    [IsoId("_TkxFQdp-Ed-ak6NoX_4Aeg_800280787")]
    [DisplayName("Vote Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDdln")]
    #endif
    [IsoXmlTag("VoteDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? VoteDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? VoteDeadline { get; init; } 
    #else
    public DateFormat2Choice_? VoteDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary (STP mode).
    /// </summary>
    [IsoId("_TkxFQtp-Ed-ak6NoX_4Aeg_800280848")]
    [DisplayName("Vote STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteSTPDdln")]
    #endif
    [IsoXmlTag("VoteSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? VoteSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? VoteSTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? VoteSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_TkxFQ9p-Ed-ak6NoX_4Aeg_800281096")]
    [DisplayName("Vote Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteMktDdln")]
    #endif
    [IsoXmlTag("VoteMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? VoteMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? VoteMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? VoteMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the different methods that can be used to vote.
    /// </summary>
    [IsoId("_TkxFRNp-Ed-ak6NoX_4Aeg_800281682")]
    [DisplayName("Vote Methods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteMthds")]
    #endif
    [IsoXmlTag("VoteMthds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteMethods? VoteMethods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteMethods? VoteMethods { get; init; } 
    #else
    public VoteMethods? VoteMethods { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_TkxFRdp-Ed-ak6NoX_4Aeg_800281651")]
    [DisplayName("Voting Ballot Electronic Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngBlltElctrncAdr")]
    #endif
    [IsoXmlTag("VtngBlltElctrncAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; } 
    #else
    public CommunicationAddress4? VotingBallotElectronicAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_TkxFRtp-Ed-ak6NoX_4Aeg_800281735")]
    [DisplayName("Voting Ballot Request Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngBlltReqAdr")]
    #endif
    [IsoXmlTag("VtngBlltReqAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 
    #else
    public PostalAddress1? VotingBallotRequestAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_TkxFR9p-Ed-ak6NoX_4Aeg_800281558")]
    [DisplayName("Revocability Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyDdln")]
    #endif
    [IsoXmlTag("RvcbltyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RevocabilityDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RevocabilityDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RevocabilityDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_TkxFSNp-Ed-ak6NoX_4Aeg_800281589")]
    [DisplayName("Revocability STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltySTPDdln")]
    #endif
    [IsoXmlTag("RvcbltySTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RevocabilitySTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RevocabilitySTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RevocabilitySTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TkxFSdp-Ed-ak6NoX_4Aeg_800281611")]
    [DisplayName("Revocability Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyMktDdln")]
    #endif
    [IsoXmlTag("RvcbltyMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RevocabilityMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RevocabilityMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RevocabilityMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether beneficiary details (eg name and address) must be supplied in order to take part to a meeting.
    /// </summary>
    [IsoId("_Tk62QNp-Ed-ak6NoX_4Aeg_800281157")]
    [DisplayName("Beneficial Owner Disclosure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrDsclsr")]
    #endif
    [IsoXmlTag("BnfclOwnrDsclsr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BeneficialOwnerDisclosure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BeneficialOwnerDisclosure { get; init; } 
    #else
    public System.String BeneficialOwnerDisclosure { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the possible types of voting instructions. When used at the resolution level, it supersedes the value specified in the meeting notice.
    /// </summary>
    [IsoId("_Tk62Qdp-Ed-ak6NoX_4Aeg_800281188")]
    [DisplayName("Vote Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrTp")]
    #endif
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = new SimpleValueList<VoteInstruction2Code>(){};
    
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_Tk62Qtp-Ed-ak6NoX_4Aeg_800282075")]
    [DisplayName("Incentive Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncntivPrm")]
    #endif
    [IsoXmlTag("IncntivPrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncentivePremium3? IncentivePremium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncentivePremium3? IncentivePremium { get; init; } 
    #else
    public IncentivePremium3? IncentivePremium { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_Tk62Q9p-Ed-ak6NoX_4Aeg_800281218")]
    [DisplayName("Vote With Premium Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? VoteWithPremiumDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? VoteWithPremiumDeadline { get; init; } 
    #else
    public DateFormat2Choice_? VoteWithPremiumDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium (STP mode).
    /// </summary>
    [IsoId("_Tk62RNp-Ed-ak6NoX_4Aeg_800281249")]
    [DisplayName("Vote With Premium STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmSTPDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? VoteWithPremiumSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? VoteWithPremiumSTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? VoteWithPremiumSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_Tk62Rdp-Ed-ak6NoX_4Aeg_800281527")]
    [DisplayName("Vote With Premium Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmMktDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? VoteWithPremiumMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_Tk62Rtp-Ed-ak6NoX_4Aeg_800281126")]
    [DisplayName("Additional Voting Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlVtngRqrmnts")]
    #endif
    [IsoXmlTag("AddtlVtngRqrmnts")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalVotingRequirements { get; init; } 
    #else
    public System.String? AdditionalVotingRequirements { get; set; } 
    #endif
    
    
    #nullable disable
    
}
