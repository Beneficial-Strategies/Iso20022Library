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
[IsoId("_Ti1Lodp-Ed-ak6NoX_4Aeg_-799797210")]
[DisplayName("Resolution")]
public partial record Resolution2
{
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_Ti-8kNp-Ed-ak6NoX_4Aeg_-799797208")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; } 
    
    /// <summary>
    /// Free text description of the resolution.
    /// </summary>
    [IsoId("_Ti-8kdp-Ed-ak6NoX_4Aeg_-799797185")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? Description { get; init; } 
    
    /// <summary>
    /// Abbreviated description of the resolution.
    /// </summary>
    [IsoId("_Ti-8ktp-Ed-ak6NoX_4Aeg_-799797150")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Title { get; init; } 
    
    /// <summary>
    /// Indicates whether a resolution is ordinary, extraordinary or special.
    /// </summary>
    [IsoId("_Ti-8k9p-Ed-ak6NoX_4Aeg_-799797133")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ResolutionType1Code Type { get; init; } 
    
    /// <summary>
    /// Indicates whether the resolution is listed for information or for voting.
    /// </summary>
    [IsoId("_Ti-8lNp-Ed-ak6NoX_4Aeg_-799796898")]
    [DisplayName("For Information Only")]
    [IsoXmlTag("ForInfOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForInformationOnly { get; init; } 
    
    /// <summary>
    /// Indicates whether the resolution is active or withdrawn.
    /// </summary>
    [IsoId("_Ti-8ldp-Ed-ak6NoX_4Aeg_-799796873")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ResolutionStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Indicates whether the resolution has been submitted by the security holder.
    /// </summary>
    [IsoId("_Ti-8ltp-Ed-ak6NoX_4Aeg_-799796856")]
    [DisplayName("Submitted By Security Holder")]
    [IsoXmlTag("SubmittdBySctyHldr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SubmittedBySecurityHolder { get; init; } 
    
    /// <summary>
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_Ti-8l9p-Ed-ak6NoX_4Aeg_-799796838")]
    [DisplayName("Vote Instruction Type")]
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = new SimpleValueList<VoteInstruction2Code>(){};
    
    /// <summary>
    /// Indicates how the management of the issuing company wishes the security holders to vote.
    /// </summary>
    [IsoId("_Ti-8mNp-Ed-ak6NoX_4Aeg_-799796813")]
    [DisplayName("Management Recommendation")]
    [IsoXmlTag("MgmtRcmmndtn")]
    public VoteInstruction1Code? ManagementRecommendation { get; init; } 
    
    /// <summary>
    /// Indicates how the notifying party recommends that the security holders vote.
    /// </summary>
    [IsoId("_Ti-8mdp-Ed-ak6NoX_4Aeg_-799796796")]
    [DisplayName("Notifying Party Recommendation")]
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    public VoteInstruction1Code? NotifyingPartyRecommendation { get; init; } 
    
    
    #nullable disable
    
}
