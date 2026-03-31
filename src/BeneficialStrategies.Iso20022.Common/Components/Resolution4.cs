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
[IsoId("_v_saca34EemG7MmivSuE5g")]
[DisplayName("Resolution")]
public record Resolution4
{
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_wWwPk634EemG7MmivSuE5g")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Free text description of the resolution.
    /// </summary>
    [IsoId("_wWwPla34EemG7MmivSuE5g")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? Description { get; init; }

    /// <summary>
    /// Abbreviated description of the resolution.
    /// </summary>
    [IsoId("_wWwPl634EemG7MmivSuE5g")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Title { get; init; }

    /// <summary>
    /// Type of resolution.
    /// </summary>
    [IsoId("_wWwPma34EemG7MmivSuE5g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ResolutionType2Code? Type { get; init; }

    /// <summary>
    /// Indicates whether the resolution is listed for information or for voting.
    /// </summary>
    [IsoId("_wWwPm634EemG7MmivSuE5g")]
    [DisplayName("For Information Only")]
    [IsoXmlTag("ForInfOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForInformationOnly { get; init; }

    /// <summary>
    /// Impact of vote results on an agenda resolution.
    /// </summary>
    [IsoId("_kFUoQK36EemG7MmivSuE5g")]
    [DisplayName("Vote Type")]
    [IsoXmlTag("VoteTp")]
    public VoteType1Code? VoteType { get; init; }

    /// <summary>
    /// Specifies whether the resolution is active or withdrawn.
    /// </summary>
    [IsoId("_wWwPna34EemG7MmivSuE5g")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ResolutionStatus1Code Status { get; init; }

    /// <summary>
    /// Indicates whether the resolution has been submitted by the security holder.
    /// </summary>
    [IsoId("_wWwPn634EemG7MmivSuE5g")]
    [DisplayName("Submitted By Security Holder")]
    [IsoXmlTag("SubmittdBySctyHldr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubmittedBySecurityHolder { get; init; }

    /// <summary>
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_J3mZUK4JEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    public ValueList<VoteInstructionType1> VoteInstructionType { get; init; } = [];

    /// <summary>
    /// Specifies how the management of the issuing company wishes the security holders to vote.
    /// </summary>
    [IsoId("_wWwPo634EemG7MmivSuE5g")]
    [DisplayName("Management Recommendation")]
    [IsoXmlTag("MgmtRcmmndtn")]
    public VoteInstruction5Code? ManagementRecommendation { get; init; }

    /// <summary>
    /// Specifies how the notifying party recommends that the security holders vote.
    /// </summary>
    [IsoId("_wWwPpa34EemG7MmivSuE5g")]
    [DisplayName("Notifying Party Recommendation")]
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    public VoteInstruction5Code? NotifyingPartyRecommendation { get; init; }

    /// <summary>
    /// Number of votes assigned per resolution to one security.
    /// </summary>
    [IsoId("_wWwPp634EemG7MmivSuE5g")]
    [DisplayName("Entitlement")]
    [IsoXmlTag("Entitlmnt")]
    public Entitlement1Choice_? Entitlement { get; init; }

    /// <summary>
    /// Voting rights threshold required in percentage or in quantity to have the resolution approved.
    /// </summary>
    [IsoId("_TR8mUK4pEemG7MmivSuE5g")]
    [DisplayName("Voting Rights Threshold For Approval")]
    [IsoXmlTag("VtngRghtsThrshldForApprvl")]
    public NumberOrPercentage1Choice_? VotingRightsThresholdForApproval { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where specific additional information on meeting resolutions may be found.
    /// </summary>
    [IsoId("_39sLwK34EemG7MmivSuE5g")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? URLAddress { get; init; }
}
