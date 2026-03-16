// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote Parameters9.
/// </summary>
[IsoId("_qF2oUZK5Ee-l-O3vIHRmRw")]
[DisplayName("Vote Parameters9")]
public partial record VoteParameters9
{
    #nullable enable

    /// <summary>
    /// Additional Voting Requirements.
    /// </summary>
    [DisplayName("Additional Voting Requirements")]
    [IsoXmlTag("AddtlVtngRqrmnts")]
    public IsoMax350Text? AdditionalVotingRequirements { get; init; } 

    /// <summary>
    /// Beneficial Owner Disclosure.
    /// </summary>
    [DisplayName("Beneficial Owner Disclosure")]
    [IsoXmlTag("BnfclOwnrDsclsr")]
    public IsoYesNoIndicator? BeneficialOwnerDisclosure { get; init; } 

    /// <summary>
    /// Early Incentive Premium.
    /// </summary>
    [DisplayName("Early Incentive Premium")]
    [IsoXmlTag("EarlyIncntivPrm")]
    public IncentivePremium6? EarlyIncentivePremium { get; init; } 

    /// <summary>
    /// Early Vote With Premium Deadline.
    /// </summary>
    [DisplayName("Early Vote With Premium Deadline")]
    [IsoXmlTag("EarlyVoteWthPrmDdln")]
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; } 

    /// <summary>
    /// Incentive Premium.
    /// </summary>
    [DisplayName("Incentive Premium")]
    [IsoXmlTag("IncntivPrm")]
    public IncentivePremium6? IncentivePremium { get; init; } 

    /// <summary>
    /// Partial Vote Allowed.
    /// </summary>
    [DisplayName("Partial Vote Allowed")]
    [IsoXmlTag("PrtlVoteAllwd")]
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; } 

    /// <summary>
    /// Previous Instruction Invalidity Indicator.
    /// </summary>
    [DisplayName("Previous Instruction Invalidity Indicator")]
    [IsoXmlTag("PrvsInstrInvldtyInd")]
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; } 

    /// <summary>
    /// Revocability Deadline.
    /// </summary>
    [DisplayName("Revocability Deadline")]
    [IsoXmlTag("RvcbltyDdln")]
    public DateFormat58Choice_? RevocabilityDeadline { get; init; } 

    /// <summary>
    /// Revocability Market Deadline.
    /// </summary>
    [DisplayName("Revocability Market Deadline")]
    [IsoXmlTag("RvcbltyMktDdln")]
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; } 

    /// <summary>
    /// Securities Quantity Required To Vote.
    /// </summary>
    [DisplayName("Securities Quantity Required To Vote")]
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; } 

    /// <summary>
    /// Split Vote Allowed.
    /// </summary>
    [DisplayName("Split Vote Allowed")]
    [IsoXmlTag("SpltVoteAllwd")]
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; } 

    /// <summary>
    /// Vote Deadline.
    /// </summary>
    [DisplayName("Vote Deadline")]
    [IsoXmlTag("VoteDdln")]
    public DateFormat58Choice_? VoteDeadline { get; init; } 

    /// <summary>
    /// Vote Market Deadline.
    /// </summary>
    [DisplayName("Vote Market Deadline")]
    [IsoXmlTag("VoteMktDdln")]
    public DateFormat58Choice_? VoteMarketDeadline { get; init; } 

    /// <summary>
    /// Vote Methods.
    /// </summary>
    [DisplayName("Vote Methods")]
    [IsoXmlTag("VoteMthds")]
    public VoteMethods5? VoteMethods { get; init; } 

    /// <summary>
    /// Vote With Premium Deadline.
    /// </summary>
    [DisplayName("Vote With Premium Deadline")]
    [IsoXmlTag("VoteWthPrmDdln")]
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; } 

    /// <summary>
    /// Vote With Premium Market Deadline.
    /// </summary>
    [DisplayName("Vote With Premium Market Deadline")]
    [IsoXmlTag("VoteWthPrmMktDdln")]
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; } 

    /// <summary>
    /// Voting Ballot Electronic Address.
    /// </summary>
    [DisplayName("Voting Ballot Electronic Address")]
    [IsoXmlTag("VtngBlltElctrncAdr")]
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; } 

    /// <summary>
    /// Voting Ballot Request Address.
    /// </summary>
    [DisplayName("Voting Ballot Request Address")]
    [IsoXmlTag("VtngBlltReqAdr")]
    public PostalAddress1? VotingBallotRequestAddress { get; init; } 

    
    #nullable disable
    
}
