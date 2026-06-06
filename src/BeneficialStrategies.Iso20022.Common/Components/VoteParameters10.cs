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
[IsoId("_5cItEajPEfCzuLlmLrhIvA")]
[DisplayName("Vote Parameters10")]
public record VoteParameters10
{
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_5i-78ajPEfCzuLlmLrhIvA")]
    [DisplayName("Securities Quantity Required To Vote")]
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; }

    /// <summary>
    /// Indicates whether a vote can be on a part of the entire holding, that is, part of the position is un-voted.
    /// </summary>
    [IsoId("_5i-786jPEfCzuLlmLrhIvA")]
    [DisplayName("Partial Vote Allowed")]
    [IsoXmlTag("PrtlVoteAllwd")]
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; }

    /// <summary>
    /// Indicates whether the vote can be split, that is, there could be different votes for different parts of the holding.
    /// </summary>
    [IsoId("_5i-79ajPEfCzuLlmLrhIvA")]
    [DisplayName("Split Vote Allowed")]
    [IsoXmlTag("SpltVoteAllwd")]
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    [IsoId("_5i-796jPEfCzuLlmLrhIvA")]
    [DisplayName("Vote Deadline")]
    [IsoXmlTag("VoteDdln")]
    public DateFormat58Choice_? VoteDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_5i-7-ajPEfCzuLlmLrhIvA")]
    [DisplayName("Vote Market Deadline")]
    [IsoXmlTag("VoteMktDdln")]
    public DateFormat58Choice_? VoteMarketDeadline { get; init; }

    /// <summary>
    /// Specifies the different methods that can be used to vote.
    /// </summary>
    [IsoId("_5i-7-6jPEfCzuLlmLrhIvA")]
    [DisplayName("Vote Methods")]
    [IsoXmlTag("VoteMthds")]
    public VoteMethods5? VoteMethods { get; init; }

    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_5i-7_ajPEfCzuLlmLrhIvA")]
    [DisplayName("Voting Ballot Electronic Address")]
    [IsoXmlTag("VtngBlltElctrncAdr")]
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; }

    /// <summary>
    /// Postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_5i-7_6jPEfCzuLlmLrhIvA")]
    [DisplayName("Voting Ballot Request Address")]
    [IsoXmlTag("VtngBlltReqAdr")]
    public PostalAddress1? VotingBallotRequestAddress { get; init; }

    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_5i-8AajPEfCzuLlmLrhIvA")]
    [DisplayName("Revocability Deadline")]
    [IsoXmlTag("RvcbltyDdln")]
    public DateFormat58Choice_? RevocabilityDeadline { get; init; }

    /// <summary>
    /// Date until which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_5i-8A6jPEfCzuLlmLrhIvA")]
    [DisplayName("Revocability Market Deadline")]
    [IsoXmlTag("RvcbltyMktDdln")]
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; }

    /// <summary>
    /// Indicates whether beneficiary details, for example, name and address, must be supplied in order to take part in a meeting.
    /// </summary>
    [IsoId("_5i-8BajPEfCzuLlmLrhIvA")]
    [DisplayName("Beneficial Owner Disclosure")]
    [IsoXmlTag("BnfclOwnrDsclsr")]
    public IsoYesNoIndicator? BeneficialOwnerDisclosure { get; init; }

    /// <summary>
    /// Cash premium paid to the security holder when voting earlier (before the early vote with a premium deadline).
    /// </summary>
    [IsoId("_5i-8B6jPEfCzuLlmLrhIvA")]
    [DisplayName("Early Incentive Premium")]
    [IsoXmlTag("EarlyIncntivPrm")]
    public IncentivePremium6? EarlyIncentivePremium { get; init; }

    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_5i-8CajPEfCzuLlmLrhIvA")]
    [DisplayName("Incentive Premium")]
    [IsoXmlTag("IncntivPrm")]
    public IncentivePremium6? IncentivePremium { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the early incentive premium.
    /// </summary>
    [IsoId("_5i-8C6jPEfCzuLlmLrhIvA")]
    [DisplayName("Early Vote With Premium Deadline")]
    [IsoXmlTag("EarlyVoteWthPrmDdln")]
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_5i-8DajPEfCzuLlmLrhIvA")]
    [DisplayName("Vote With Premium Deadline")]
    [IsoXmlTag("VoteWthPrmDdln")]
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_5i-8D6jPEfCzuLlmLrhIvA")]
    [DisplayName("Vote With Premium Market Deadline")]
    [IsoXmlTag("VoteWthPrmMktDdln")]
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; }

    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_5i-8EajPEfCzuLlmLrhIvA")]
    [DisplayName("Additional Voting Requirements")]
    [IsoXmlTag("AddtlVtngRqrmnts")]
    public IsoMax350Text? AdditionalVotingRequirements { get; init; }

    /// <summary>
    /// Information required by the issuer to be disclosed as part of a submitted instruction, that is neither the information related to the beneficiary holder, or the voting participant, or the proxy appointed by the issuer, or the attendee(s) participating to the meeting (without voting).
    /// </summary>
    [IsoId("_GfhX8KjdEfCzuLlmLrhIvA")]
    [DisplayName("Additional Disclosure Requirements")]
    [IsoXmlTag("AddtlDsclsrRqrmnts")]
    public IsoMax350Text? AdditionalDisclosureRequirements { get; init; }

    /// <summary>
    /// Indicates whether the previously sent instructions becomes invalid after a market deadline extension.
    /// </summary>
    [IsoId("_5i-8E6jPEfCzuLlmLrhIvA")]
    [DisplayName("Previous Instruction Invalidity Indicator")]
    [IsoXmlTag("PrvsInstrInvldtyInd")]
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; }
}
