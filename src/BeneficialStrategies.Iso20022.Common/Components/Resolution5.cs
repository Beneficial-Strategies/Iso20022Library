// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Resolutions at the agenda of a meeting and type of resolution.
/// </summary>
[IsoId("_xJ1FUfM8EeqRfth943bvEA")]
[DisplayName("Resolution")]
public record Resolution5
{
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_xdeaE_M8EeqRfth943bvEA")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Language, title and textual description of an agenda resolution.
    /// </summary>
    [IsoId("_xdeaFfM8EeqRfth943bvEA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<ItemDescription1> Description { get; init; } = [];

    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    [IsoId("_cxQq4PNWEeqRfth943bvEA")]
    [DisplayName("Listing Group Resolution Label")]
    [IsoXmlTag("ListgGrpRsltnLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; }

    /// <summary>
    /// Type of resolution.
    /// </summary>
    [IsoId("_xdeaGfM8EeqRfth943bvEA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ResolutionType2Code? Type { get; init; }

    /// <summary>
    /// Indicates whether the resolution is listed for information or for voting.
    /// </summary>
    [IsoId("_xdeaG_M8EeqRfth943bvEA")]
    [DisplayName("For Information Only")]
    [IsoXmlTag("ForInfOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForInformationOnly { get; init; }

    /// <summary>
    /// Impact of vote results on an agenda resolution.
    /// </summary>
    [IsoId("_xdeaHfM8EeqRfth943bvEA")]
    [DisplayName("Vote Type")]
    [IsoXmlTag("VoteTp")]
    public VoteType1Code? VoteType { get; init; }

    /// <summary>
    /// Specifies whether the resolution is active or withdrawn.
    /// </summary>
    [IsoId("_xdeaH_M8EeqRfth943bvEA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ResolutionStatus1Code Status { get; init; }

    /// <summary>
    /// Indicates whether the resolution has been submitted by the security holder.
    /// </summary>
    [IsoId("_xdeaIfM8EeqRfth943bvEA")]
    [DisplayName("Submitted By Security Holder")]
    [IsoXmlTag("SubmittdBySctyHldr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubmittedBySecurityHolder { get; init; }

    /// <summary>
    /// Indicates whether a client who has not voted in favour of the resolutions which is finally approved, has the right to withdraw from a related corporate action event.
    /// </summary>
    [IsoId("_Y85K8PNiEeqRfth943bvEA")]
    [DisplayName("Right To Withdraw Indicator")]
    [IsoXmlTag("RghtToWdrwInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RightToWithdrawIndicator { get; init; }

    /// <summary>
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_xdeaI_M8EeqRfth943bvEA")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    public ValueList<VoteInstructionType1> VoteInstructionType { get; init; } = [];

    /// <summary>
    /// Specifies how the management of the issuing company wishes the security holders to vote.
    /// </summary>
    [IsoId("_xdeaJfM8EeqRfth943bvEA")]
    [DisplayName("Management Recommendation")]
    [IsoXmlTag("MgmtRcmmndtn")]
    public VoteInstruction5Code? ManagementRecommendation { get; init; }

    /// <summary>
    /// Specifies how the notifying party recommends that the security holders vote.
    /// </summary>
    [IsoId("_xdeaJ_M8EeqRfth943bvEA")]
    [DisplayName("Notifying Party Recommendation")]
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    public VoteInstruction5Code? NotifyingPartyRecommendation { get; init; }

    /// <summary>
    /// Number of votes assigned per resolution to one security.
    /// </summary>
    [IsoId("_xdeaKfM8EeqRfth943bvEA")]
    [DisplayName("Entitlement")]
    [IsoXmlTag("Entitlmnt")]
    public Entitlement1Choice_? Entitlement { get; init; }

    /// <summary>
    /// Voting rights threshold required in percentage or in quantity to have the resolution approved.
    /// </summary>
    [IsoId("_xdeaK_M8EeqRfth943bvEA")]
    [DisplayName("Voting Rights Threshold For Approval")]
    [IsoXmlTag("VtngRghtsThrshldForApprvl")]
    public NumberOrPercentage1Choice_? VotingRightsThresholdForApproval { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where specific additional information on meeting resolutions may be found.
    /// </summary>
    [IsoId("_xdnkAfM8EeqRfth943bvEA")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; }
}
