// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Resolution8.
/// </summary>
[IsoId("_SzvMsZK5Ee-l-O3vIHRmRw")]
[DisplayName("Resolution8")]
public record Resolution8
{
    /// <summary>
    /// Issuer Label.
    /// </summary>
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    public required Max35Text IssuerLabel { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public ValueList<ItemDescription2> Description { get; init; } = [];

    /// <summary>
    /// Listing Group Resolution Label.
    /// </summary>
    [DisplayName("Listing Group Resolution Label")]
    [IsoXmlTag("ListgGrpRsltnLabl")]
    public Max35Text? ListingGroupResolutionLabel { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ResolutionType2Code? Type { get; init; }

    /// <summary>
    /// For Information Only.
    /// </summary>
    [DisplayName("For Information Only")]
    [IsoXmlTag("ForInfOnly")]
    public required YesNoIndicator ForInformationOnly { get; init; }

    /// <summary>
    /// Vote Type.
    /// </summary>
    [DisplayName("Vote Type")]
    [IsoXmlTag("VoteTp")]
    public VoteType1Code? VoteType { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ResolutionStatus1Code Status { get; init; }

    /// <summary>
    /// Submitted By Security Holder.
    /// </summary>
    [DisplayName("Submitted By Security Holder")]
    [IsoXmlTag("SubmittdBySctyHldr")]
    public YesNoIndicator? SubmittedBySecurityHolder { get; init; }

    /// <summary>
    /// Right To Withdraw Indicator.
    /// </summary>
    [DisplayName("Right To Withdraw Indicator")]
    [IsoXmlTag("RghtToWdrwInd")]
    public YesNoIndicator? RightToWithdrawIndicator { get; init; }

    /// <summary>
    /// Vote Instruction Type.
    /// </summary>
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    public ValueList<VoteInstructionType1> VoteInstructionType { get; init; } = [];

    /// <summary>
    /// Management Recommendation.
    /// </summary>
    [DisplayName("Management Recommendation")]
    [IsoXmlTag("MgmtRcmmndtn")]
    public VoteInstruction5Code? ManagementRecommendation { get; init; }

    /// <summary>
    /// Notifying Party Recommendation.
    /// </summary>
    [DisplayName("Notifying Party Recommendation")]
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    public VoteInstruction5Code? NotifyingPartyRecommendation { get; init; }

    /// <summary>
    /// Entitlement.
    /// </summary>
    [DisplayName("Entitlement")]
    [IsoXmlTag("Entitlmnt")]
    public Entitlement1Choice_? Entitlement { get; init; }

    /// <summary>
    /// Voting Rights Threshold For Approval.
    /// </summary>
    [DisplayName("Voting Rights Threshold For Approval")]
    [IsoXmlTag("VtngRghtsThrshldForApprvl")]
    public ValueList<VotingRightsThreshold2> VotingRightsThresholdForApproval { get; init; } = [];

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public Max2048Text? URLAddress { get; init; }
}
