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
[IsoId("_K5fMUfM7EeqRfth943bvEA")]
[DisplayName("Vote Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteParameters6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteParameters6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteParameters6( System.String reqPartialVoteAllowed,System.String reqSplitVoteAllowed )
    {
        PartialVoteAllowed = reqPartialVoteAllowed;
        SplitVoteAllowed = reqSplitVoteAllowed;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_LOa6g_M7EeqRfth943bvEA")]
    [DisplayName("Securities Quantity Required To Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtyReqrdToVote")]
    #endif
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a vote can be on a part of the entire holding, that is, part of the position is un-voted.
    /// </summary>
    [IsoId("_LOa6hfM7EeqRfth943bvEA")]
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
    /// Indicates whether the vote can be split, that is, there could be different votes for different parts of the holding.
    /// </summary>
    [IsoId("_LOa6h_M7EeqRfth943bvEA")]
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
    [IsoId("_LOa6ifM7EeqRfth943bvEA")]
    [DisplayName("Vote Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteDdln")]
    #endif
    [IsoXmlTag("VoteDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? VoteDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? VoteDeadline { get; init; } 
    #else
    public DateFormat58Choice_? VoteDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_LOa6i_M7EeqRfth943bvEA")]
    [DisplayName("Vote Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteMktDdln")]
    #endif
    [IsoXmlTag("VoteMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? VoteMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? VoteMarketDeadline { get; init; } 
    #else
    public DateFormat58Choice_? VoteMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the different methods that can be used to vote.
    /// </summary>
    [IsoId("_LOa6jfM7EeqRfth943bvEA")]
    [DisplayName("Vote Methods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteMthds")]
    #endif
    [IsoXmlTag("VoteMthds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteMethods3? VoteMethods { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteMethods3? VoteMethods { get; init; } 
    #else
    public VoteMethods3? VoteMethods { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_LOa6j_M7EeqRfth943bvEA")]
    [DisplayName("Voting Ballot Electronic Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngBlltElctrncAdr")]
    #endif
    [IsoXmlTag("VtngBlltElctrncAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; } 
    #else
    public CommunicationAddress11? VotingBallotElectronicAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_LOa6kfM7EeqRfth943bvEA")]
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
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_LOa6k_M7EeqRfth943bvEA")]
    [DisplayName("Revocability Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyDdln")]
    #endif
    [IsoXmlTag("RvcbltyDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? RevocabilityDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? RevocabilityDeadline { get; init; } 
    #else
    public DateFormat58Choice_? RevocabilityDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_LOa6lfM7EeqRfth943bvEA")]
    [DisplayName("Revocability Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvcbltyMktDdln")]
    #endif
    [IsoXmlTag("RvcbltyMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; } 
    #else
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether beneficiary details, for example, name and address, must be supplied in order to take part in a meeting.
    /// </summary>
    [IsoId("_LOa6l_M7EeqRfth943bvEA")]
    [DisplayName("Beneficial Owner Disclosure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrDsclsr")]
    #endif
    [IsoXmlTag("BnfclOwnrDsclsr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BeneficialOwnerDisclosure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BeneficialOwnerDisclosure { get; init; } 
    #else
    public System.String? BeneficialOwnerDisclosure { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium paid to the security holder when voting earlier (before the early vote with a premium deadline).
    /// </summary>
    [IsoId("_LOa6mfM7EeqRfth943bvEA")]
    [DisplayName("Early Incentive Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyIncntivPrm")]
    #endif
    [IsoXmlTag("EarlyIncntivPrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncentivePremium5? EarlyIncentivePremium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncentivePremium5? EarlyIncentivePremium { get; init; } 
    #else
    public IncentivePremium5? EarlyIncentivePremium { get; set; } 
    #endif
    
    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_LOa6m_M7EeqRfth943bvEA")]
    [DisplayName("Incentive Premium")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncntivPrm")]
    #endif
    [IsoXmlTag("IncntivPrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IncentivePremium5? IncentivePremium { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IncentivePremium5? IncentivePremium { get; init; } 
    #else
    public IncentivePremium5? IncentivePremium { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the early incentive premium.
    /// </summary>
    [IsoId("_LOa6nfM7EeqRfth943bvEA")]
    [DisplayName("Early Vote With Premium Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyVoteWthPrmDdln")]
    #endif
    [IsoXmlTag("EarlyVoteWthPrmDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; } 
    #else
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_LOa6n_M7EeqRfth943bvEA")]
    [DisplayName("Vote With Premium Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; } 
    #else
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_LOa6ofM7EeqRfth943bvEA")]
    [DisplayName("Vote With Premium Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteWthPrmMktDdln")]
    #endif
    [IsoXmlTag("VoteWthPrmMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; } 
    #else
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_LOa6o_M7EeqRfth943bvEA")]
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
    
    /// <summary>
    /// Indicates whether the previously sent instructions becomes invalid after a market deadline extension.
    /// </summary>
    [IsoId("_LOa6pfM7EeqRfth943bvEA")]
    [DisplayName("Previous Instruction Invalidity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsInstrInvldtyInd")]
    #endif
    [IsoXmlTag("PrvsInstrInvldtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreviousInstructionInvalidityIndicator { get; init; } 
    #else
    public System.String? PreviousInstructionInvalidityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
