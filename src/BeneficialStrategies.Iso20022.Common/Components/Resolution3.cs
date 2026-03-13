// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an item in the agenda of the meeting. Some resolutions are submitted to the vote of the security holders, some are presented for information only.
/// </summary>
[IsoId("_zsXb8VtnEeSwKe7KuKvXhg")]
[DisplayName("Resolution")]
public partial record Resolution3
{
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_0JrqE1tnEeSwKe7KuKvXhg")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; } 
    
    /// <summary>
    /// Free text description of the resolution.
    /// </summary>
    [IsoId("_0JrqFVtnEeSwKe7KuKvXhg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? Description { get; init; } 
    
    /// <summary>
    /// Abbreviated description of the resolution.
    /// </summary>
    [IsoId("_0JrqF1tnEeSwKe7KuKvXhg")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Title { get; init; } 
    
    /// <summary>
    /// Specifies the type of resolution.
    /// </summary>
    [IsoId("_0JrqGVtnEeSwKe7KuKvXhg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ResolutionType2Code? Type { get; init; } 
    
    /// <summary>
    /// Indicates whether the resolution is listed for information or for voting.
    /// </summary>
    [IsoId("_0JrqG1tnEeSwKe7KuKvXhg")]
    [DisplayName("For Information Only")]
    [IsoXmlTag("ForInfOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForInformationOnly { get; init; } 
    
    /// <summary>
    /// Indicates whether the resolution is active or withdrawn.
    /// </summary>
    [IsoId("_0JrqHVtnEeSwKe7KuKvXhg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ResolutionStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Indicates whether the resolution has been submitted by the security holder.
    /// </summary>
    [IsoId("_0JrqH1tnEeSwKe7KuKvXhg")]
    [DisplayName("Submitted By Security Holder")]
    [IsoXmlTag("SubmittdBySctyHldr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SubmittedBySecurityHolder { get; init; } 
    
    /// <summary>
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_0JrqIVtnEeSwKe7KuKvXhg")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = [];
    
    /// <summary>
    /// Specifies how the management of the issuing company wishes the security holders to vote.
    /// </summary>
    [IsoId("_0JrqI1tnEeSwKe7KuKvXhg")]
    [DisplayName("Management Recommendation")]
    [IsoXmlTag("MgmtRcmmndtn")]
    public VoteInstruction1Code? ManagementRecommendation { get; init; } 
    
    /// <summary>
    /// Indicates how the notifying party recommends that the security holders vote.
    /// </summary>
    [IsoId("_0JrqJVtnEeSwKe7KuKvXhg")]
    [DisplayName("Notifying Party Recommendation")]
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    public VoteInstruction1Code? NotifyingPartyRecommendation { get; init; } 
    
    /// <summary>
    /// Number of votes assigned per resolution to one security.
    /// </summary>
    [IsoId("_midF8VuUEeSmO6RkXg92Lg")]
    [DisplayName("Entitlement")]
    [IsoXmlTag("Entitlmnt")]
    public Entitlement1Choice_? Entitlement { get; init; } 
    
    
    #nullable disable
    
}
