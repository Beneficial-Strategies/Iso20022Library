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
    [IsoId("_5i-78ajPEfCzuLlmLrhIvA")]
    [DisplayName("Securities Quantity Required To Vote")]
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    public FinancialInstrumentQuantity18Choice_? SecuritiesQuantityRequiredToVote { get; init; }

    [IsoId("_5i-786jPEfCzuLlmLrhIvA")]
    [DisplayName("Partial Vote Allowed")]
    [IsoXmlTag("PrtlVoteAllwd")]
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; }

    [IsoId("_5i-79ajPEfCzuLlmLrhIvA")]
    [DisplayName("Split Vote Allowed")]
    [IsoXmlTag("SpltVoteAllwd")]
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; }

    [IsoId("_5i-796jPEfCzuLlmLrhIvA")]
    [DisplayName("Vote Deadline")]
    [IsoXmlTag("VoteDdln")]
    public DateFormat58Choice_? VoteDeadline { get; init; }

    [IsoId("_5i-7-ajPEfCzuLlmLrhIvA")]
    [DisplayName("Vote Market Deadline")]
    [IsoXmlTag("VoteMktDdln")]
    public DateFormat58Choice_? VoteMarketDeadline { get; init; }

    [IsoId("_5i-7-6jPEfCzuLlmLrhIvA")]
    [DisplayName("Vote Methods")]
    [IsoXmlTag("VoteMthds")]
    public VoteMethods5? VoteMethods { get; init; }

    [IsoId("_5i-7_ajPEfCzuLlmLrhIvA")]
    [DisplayName("Voting Ballot Electronic Address")]
    [IsoXmlTag("VtngBlltElctrncAdr")]
    public CommunicationAddress11? VotingBallotElectronicAddress { get; init; }

    [IsoId("_5i-7_6jPEfCzuLlmLrhIvA")]
    [DisplayName("Voting Ballot Request Address")]
    [IsoXmlTag("VtngBlltReqAdr")]
    public PostalAddress1? VotingBallotRequestAddress { get; init; }

    [IsoId("_5i-8AajPEfCzuLlmLrhIvA")]
    [DisplayName("Revocability Deadline")]
    [IsoXmlTag("RvcbltyDdln")]
    public DateFormat58Choice_? RevocabilityDeadline { get; init; }

    [IsoId("_5i-8A6jPEfCzuLlmLrhIvA")]
    [DisplayName("Revocability Market Deadline")]
    [IsoXmlTag("RvcbltyMktDdln")]
    public DateFormat58Choice_? RevocabilityMarketDeadline { get; init; }

    [IsoId("_5i-8BajPEfCzuLlmLrhIvA")]
    [DisplayName("Beneficial Owner Disclosure")]
    [IsoXmlTag("BnfclOwnrDsclsr")]
    public IsoYesNoIndicator? BeneficialOwnerDisclosure { get; init; }

    [IsoId("_5i-8B6jPEfCzuLlmLrhIvA")]
    [DisplayName("Early Incentive Premium")]
    [IsoXmlTag("EarlyIncntivPrm")]
    public IncentivePremium6? EarlyIncentivePremium { get; init; }

    [IsoId("_5i-8CajPEfCzuLlmLrhIvA")]
    [DisplayName("Incentive Premium")]
    [IsoXmlTag("IncntivPrm")]
    public IncentivePremium6? IncentivePremium { get; init; }

    [IsoId("_5i-8C6jPEfCzuLlmLrhIvA")]
    [DisplayName("Early Vote With Premium Deadline")]
    [IsoXmlTag("EarlyVoteWthPrmDdln")]
    public DateFormat58Choice_? EarlyVoteWithPremiumDeadline { get; init; }

    [IsoId("_5i-8DajPEfCzuLlmLrhIvA")]
    [DisplayName("Vote With Premium Deadline")]
    [IsoXmlTag("VoteWthPrmDdln")]
    public DateFormat58Choice_? VoteWithPremiumDeadline { get; init; }

    [IsoId("_5i-8D6jPEfCzuLlmLrhIvA")]
    [DisplayName("Vote With Premium Market Deadline")]
    [IsoXmlTag("VoteWthPrmMktDdln")]
    public DateFormat58Choice_? VoteWithPremiumMarketDeadline { get; init; }

    [IsoId("_5i-8EajPEfCzuLlmLrhIvA")]
    [DisplayName("Additional Voting Requirements")]
    [IsoXmlTag("AddtlVtngRqrmnts")]
    public IsoMax350Text? AdditionalVotingRequirements { get; init; }

    [IsoId("_GfhX8KjdEfCzuLlmLrhIvA")]
    [DisplayName("Additional Disclosure Requirements")]
    [IsoXmlTag("AddtlDsclsrRqrmnts")]
    public IsoMax350Text? AdditionalDisclosureRequirements { get; init; }

    [IsoId("_5i-8E6jPEfCzuLlmLrhIvA")]
    [DisplayName("Previous Instruction Invalidity Indicator")]
    [IsoXmlTag("PrvsInstrInvldtyInd")]
    public IsoYesNoIndicator? PreviousInstructionInvalidityIndicator { get; init; }
}
