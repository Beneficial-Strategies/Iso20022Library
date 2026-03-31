// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information describing how the voting process is organised.
/// </summary>
[IsoId("_lRnYIa09EemDtrWpq90Ckg")]
[DisplayName("Vote Parameters")]
public record VoteParameters5
{
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_loYSU609EemDtrWpq90Ckg")]
    [DisplayName("Securities Quantity Required To Vote")]
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; }

    /// <summary>
    /// Indicates whether a vote can be on a part of the entire holding, that is, part of the position is un-voted.
    /// </summary>
    [IsoId("_loYSVa09EemDtrWpq90Ckg")]
    [DisplayName("Partial Vote Allowed")]
    [IsoXmlTag("PrtlVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; }

    /// <summary>
    /// Indicates whether the vote can be split, that is, there could be different votes for different parts of the holding.
    /// </summary>
    [IsoId("_loYSV609EemDtrWpq90Ckg")]
    [DisplayName("Split Vote Allowed")]
    [IsoXmlTag("SpltVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    [IsoId("_loYSWa09EemDtrWpq90Ckg")]
    [DisplayName("Vote Deadline")]
    [IsoXmlTag("VoteDdln")]
    public DateFormat58Choice_? VoteDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_loYSXa09EemDtrWpq90Ckg")]
    [DisplayName("Vote Market Deadline")]
    [IsoXmlTag("VoteMktDdln")]
    public DateFormat58Choice_? VoteMarketDeadline { get; init; }

    /// <summary>
    /// Specifies the different methods that can be used to vote.
    /// </summary>
    [IsoId("_loYSX609EemDtrWpq90Ckg")]
    [DisplayName("Vote Methods")]
    [IsoXmlTag("VoteMthds")]
    public VoteMethods3? VoteMethods { get; init; }

    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_loYSYa09EemDtrWpq90Ckg")]
    [DisplayName("Voting Ballot Electronic Address")]
    [IsoXmlTag("VtngBlltElctrncAdr")]
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; }

    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_loYSY609EemDtrWpq90Ckg")]
    [DisplayName("Voting Ballot Request Address")]
    [IsoXmlTag("VtngBlltReqAdr")]
    public PostalAddress1? VotingBallotRequestAddress { get; init; }

    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_loYSZa09EemDtrWpq90Ckg")]
    [DisplayName("Revocability Deadline")]
    [IsoXmlTag("RvcbltyDdln")]
    public DateFormat58Choice_? RevocabilityDeadline { get; init; }

    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_loYSaa09EemDtrWpq90Ckg")]
    [DisplayName("Revocability Market Deadline")]
    [IsoXmlTag("RvcbltyMktDdln")]
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; }

    /// <summary>
    /// Indicates whether beneficiary details, for example, name and address, must be supplied in order to take part in a meeting.
    /// </summary>
    [IsoId("_loYSa609EemDtrWpq90Ckg")]
    [DisplayName("Beneficial Owner Disclosure")]
    [IsoXmlTag("BnfclOwnrDsclsr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; }

    /// <summary>
    /// Cash premium paid to the security holder when voting earlier (before the early vote with a premium deadline).
    /// </summary>
    [IsoId("_loYSb609EemDtrWpq90Ckg")]
    [DisplayName("Early Incentive Premium")]
    [IsoXmlTag("EarlyIncntivPrm")]
    public IncentivePremium4? EarlyIncentivePremium { get; init; }

    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_loYSca09EemDtrWpq90Ckg")]
    [DisplayName("Incentive Premium")]
    [IsoXmlTag("IncntivPrm")]
    public IncentivePremium4? IncentivePremium { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the early incentive premium.
    /// </summary>
    [IsoId("_loYSc609EemDtrWpq90Ckg")]
    [DisplayName("Early Vote With Premium Deadline")]
    [IsoXmlTag("EarlyVoteWthPrmDdln")]
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_loYSda09EemDtrWpq90Ckg")]
    [DisplayName("Vote With Premium Deadline")]
    [IsoXmlTag("VoteWthPrmDdln")]
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_loYSea09EemDtrWpq90Ckg")]
    [DisplayName("Vote With Premium Market Deadline")]
    [IsoXmlTag("VoteWthPrmMktDdln")]
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; }

    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_loYSe609EemDtrWpq90Ckg")]
    [DisplayName("Additional Voting Requirements")]
    [IsoXmlTag("AddtlVtngRqrmnts")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalVotingRequirements { get; init; }

    /// <summary>
    /// Indicates whether the previously sent instructions becomes invalid after a market deadline extension.
    /// </summary>
    [IsoId("_loYSfa09EemDtrWpq90Ckg")]
    [DisplayName("Previous Instruction Invalidity Indicator")]
    [IsoXmlTag("PrvsInstrInvldtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; }
}
