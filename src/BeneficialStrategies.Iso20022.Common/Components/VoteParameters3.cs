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
[IsoId("_TjkycNp-Ed-ak6NoX_4Aeg_-423421287")]
[DisplayName("Vote Parameters")]
public record VoteParameters3
{
    /// <summary>
    /// Number of holdings required for a vote.
    /// </summary>
    [IsoId("_Tjkycdp-Ed-ak6NoX_4Aeg_-1389784353")]
    [DisplayName("Securities Quantity Required To Vote")]
    [IsoXmlTag("SctiesQtyReqrdToVote")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? SecuritiesQuantityRequiredToVote { get; init; }

    /// <summary>
    /// Specifies whether it is allowed to only vote on a part of the entire holding, leaving part of the position un-voted.
    /// </summary>
    [IsoId("_Tjkyctp-Ed-ak6NoX_4Aeg_-1514722196")]
    [DisplayName("Partial Vote Allowed")]
    [IsoXmlTag("PrtlVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PartialVoteAllowed { get; init; }

    /// <summary>
    /// Specifies whether it is allowed to vote in different directions for the entire holding.
    /// </summary>
    [IsoId("_Tjkyc9p-Ed-ak6NoX_4Aeg_884127308")]
    [DisplayName("Split Vote Allowed")]
    [IsoXmlTag("SpltVoteAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SplitVoteAllowed { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary.
    /// </summary>
    [IsoId("_TjkydNp-Ed-ak6NoX_4Aeg_2098979730")]
    [DisplayName("Vote Deadline")]
    [IsoXmlTag("VoteDdln")]
    public DateFormat2Choice_? VoteDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary (STP mode).
    /// </summary>
    [IsoId("_Tjkyddp-Ed-ak6NoX_4Aeg_104835024")]
    [DisplayName("Vote STP Deadline")]
    [IsoXmlTag("VoteSTPDdln")]
    public DateFormat2Choice_? VoteSTPDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer.
    /// </summary>
    [IsoId("_Tjkydtp-Ed-ak6NoX_4Aeg_-1723879606")]
    [DisplayName("Vote Market Deadline")]
    [IsoXmlTag("VoteMktDdln")]
    public DateFormat2Choice_? VoteMarketDeadline { get; init; }

    /// <summary>
    /// Indicates the different methods that can be used to vote.
    /// </summary>
    [IsoId("_Tjkyd9p-Ed-ak6NoX_4Aeg_1003187298")]
    [DisplayName("Vote Methods")]
    [IsoXmlTag("VoteMthds")]
    public VoteMethods2? VoteMethods { get; init; }

    /// <summary>
    /// Electronic location, e-mail or URL address, where the voting ballot can be requested.
    /// </summary>
    [IsoId("_TjkyeNp-Ed-ak6NoX_4Aeg_445071518")]
    [DisplayName("Voting Ballot Electronic Address")]
    [IsoXmlTag("VtngBlltElctrncAdr")]
    public CommunicationAddress4? VotingBallotElectronicAddress { get; init; }

    /// <summary>
    /// Specifies the postal address where the voting ballot can be requested.
    /// </summary>
    [IsoId("_TjujcNp-Ed-ak6NoX_4Aeg_407467062")]
    [DisplayName("Voting Ballot Request Address")]
    [IsoXmlTag("VtngBlltReqAdr")]
    public PostalAddress1? VotingBallotRequestAddress { get; init; }

    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_Tjujcdp-Ed-ak6NoX_4Aeg_574486957")]
    [DisplayName("Revocability Deadline")]
    [IsoXmlTag("RvcbltyDdln")]
    public DateFormat2Choice_? RevocabilityDeadline { get; init; }

    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_Tjujctp-Ed-ak6NoX_4Aeg_-104409894")]
    [DisplayName("Revocability STP Deadline")]
    [IsoXmlTag("RvcbltySTPDdln")]
    public DateFormat2Choice_? RevocabilitySTPDeadline { get; init; }

    /// <summary>
    /// Date till which the instructing party can revoke, change or withdraw its voting instruction. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Tjujc9p-Ed-ak6NoX_4Aeg_542516193")]
    [DisplayName("Revocability Market Deadline")]
    [IsoXmlTag("RvcbltyMktDdln")]
    public DateFormat2Choice_? RevocabilityMarketDeadline { get; init; }

    /// <summary>
    /// Indicates whether beneficiary details (eg name and address) must be supplied in order to take part to a meeting.
    /// </summary>
    [IsoId("_TjujdNp-Ed-ak6NoX_4Aeg_333865223")]
    [DisplayName("Beneficial Owner Disclosure")]
    [IsoXmlTag("BnfclOwnrDsclsr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator BeneficialOwnerDisclosure { get; init; }

    /// <summary>
    /// Identifies the possible types of voting instructions. When used at the resolution level, it supersedes the value specified in the meeting notice.
    /// </summary>
    [IsoId("_Tjujddp-Ed-ak6NoX_4Aeg_545143664")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = [];

    /// <summary>
    /// Cash premium paid to the security holder when voting.
    /// </summary>
    [IsoId("_Tjujdtp-Ed-ak6NoX_4Aeg_1260060452")]
    [DisplayName("Incentive Premium")]
    [IsoXmlTag("IncntivPrm")]
    public IncentivePremium3? IncentivePremium { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium.
    /// </summary>
    [IsoId("_Tjujd9p-Ed-ak6NoX_4Aeg_944267151")]
    [DisplayName("Vote With Premium Deadline")]
    [IsoXmlTag("VoteWthPrmDdln")]
    public DateFormat2Choice_? VoteWithPremiumDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the intermediary to take advantage of the premium (STP mode).
    /// </summary>
    [IsoId("_TjujeNp-Ed-ak6NoX_4Aeg_1284515354")]
    [DisplayName("Vote With Premium STP Deadline")]
    [IsoXmlTag("VoteWthPrmSTPDdln")]
    public DateFormat2Choice_? VoteWithPremiumSTPDeadline { get; init; }

    /// <summary>
    /// Date and time by which the vote instructions should be submitted to the issuer to take advantage of the premium.
    /// </summary>
    [IsoId("_Tjujedp-Ed-ak6NoX_4Aeg_-304924554")]
    [DisplayName("Vote With Premium Market Deadline")]
    [IsoXmlTag("VoteWthPrmMktDdln")]
    public DateFormat2Choice_? VoteWithPremiumMarketDeadline { get; init; }

    /// <summary>
    /// Additional information on specific requirements for allowing a person to vote.
    /// </summary>
    [IsoId("_Tj3tYNp-Ed-ak6NoX_4Aeg_-736540281")]
    [DisplayName("Additional Voting Requirements")]
    [IsoXmlTag("AddtlVtngRqrmnts")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalVotingRequirements { get; init; }
}
