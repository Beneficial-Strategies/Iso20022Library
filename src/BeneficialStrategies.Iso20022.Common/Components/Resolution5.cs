// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Resolutions at the agenda of a meeting and type of resolution.
/// </summary>
[IsoId("_xJ1FUfM8EeqRfth943bvEA")]
[DisplayName("Resolution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Resolution5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Resolution5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Resolution5( System.String reqIssuerLabel,System.String reqForInformationOnly,ResolutionStatus1Code reqStatus )
    {
        IssuerLabel = reqIssuerLabel;
        ForInformationOnly = reqForInformationOnly;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_xdeaE_M8EeqRfth943bvEA")]
    [DisplayName("Issuer Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrLabl")]
    #endif
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IssuerLabel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerLabel { get; init; } 
    #else
    public System.String IssuerLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Language, title and textual description of an agenda resolution. 
    /// </summary>
    [IsoId("_xdeaFfM8EeqRfth943bvEA")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ItemDescription1? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ItemDescription1? Description { get; init; } 
    #else
    public ItemDescription1? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies under the same label a group of agenda resolutions for which a vote in favour can be assigned to only one resolution of that group.
    /// </summary>
    [IsoId("_cxQq4PNWEeqRfth943bvEA")]
    [DisplayName("Listing Group Resolution Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListgGrpRsltnLabl")]
    #endif
    [IsoXmlTag("ListgGrpRsltnLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ListingGroupResolutionLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ListingGroupResolutionLabel { get; init; } 
    #else
    public System.String? ListingGroupResolutionLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Type of resolution.
    /// </summary>
    [IsoId("_xdeaGfM8EeqRfth943bvEA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResolutionType2Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionType2Code? Type { get; init; } 
    #else
    public ResolutionType2Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the resolution is listed for information or for voting.
    /// </summary>
    [IsoId("_xdeaG_M8EeqRfth943bvEA")]
    [DisplayName("For Information Only")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ForInfOnly")]
    #endif
    [IsoXmlTag("ForInfOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ForInformationOnly { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ForInformationOnly { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ForInformationOnly { get; init; } 
    #else
    public System.String ForInformationOnly { get; set; } 
    #endif
    
    /// <summary>
    /// Impact of vote results on an agenda resolution.
    /// </summary>
    [IsoId("_xdeaHfM8EeqRfth943bvEA")]
    [DisplayName("Vote Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteTp")]
    #endif
    [IsoXmlTag("VoteTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteType1Code? VoteType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteType1Code? VoteType { get; init; } 
    #else
    public VoteType1Code? VoteType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the resolution is active or withdrawn.
    /// </summary>
    [IsoId("_xdeaH_M8EeqRfth943bvEA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResolutionStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResolutionStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionStatus1Code Status { get; init; } 
    #else
    public ResolutionStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the resolution has been submitted by the security holder.
    /// </summary>
    [IsoId("_xdeaIfM8EeqRfth943bvEA")]
    [DisplayName("Submitted By Security Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmittdBySctyHldr")]
    #endif
    [IsoXmlTag("SubmittdBySctyHldr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SubmittedBySecurityHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubmittedBySecurityHolder { get; init; } 
    #else
    public System.String? SubmittedBySecurityHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a client who has not voted in favour of the resolutions which is finally approved, has the right to withdraw from a related corporate action event.
    /// </summary>
    [IsoId("_Y85K8PNiEeqRfth943bvEA")]
    [DisplayName("Right To Withdraw Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RghtToWdrwInd")]
    #endif
    [IsoXmlTag("RghtToWdrwInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RightToWithdrawIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RightToWithdrawIndicator { get; init; } 
    #else
    public System.String? RightToWithdrawIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_xdeaI_M8EeqRfth943bvEA")]
    [DisplayName("Vote Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrTp")]
    #endif
    [IsoXmlTag("VoteInstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstructionType1? VoteInstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstructionType1? VoteInstructionType { get; init; } 
    #else
    public VoteInstructionType1? VoteInstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the management of the issuing company wishes the security holders to vote.
    /// </summary>
    [IsoId("_xdeaJfM8EeqRfth943bvEA")]
    [DisplayName("Management Recommendation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MgmtRcmmndtn")]
    #endif
    [IsoXmlTag("MgmtRcmmndtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstruction5Code? ManagementRecommendation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstruction5Code? ManagementRecommendation { get; init; } 
    #else
    public VoteInstruction5Code? ManagementRecommendation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the notifying party recommends that the security holders vote.
    /// </summary>
    [IsoId("_xdeaJ_M8EeqRfth943bvEA")]
    [DisplayName("Notifying Party Recommendation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtifngPtyRcmmndtn")]
    #endif
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstruction5Code? NotifyingPartyRecommendation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstruction5Code? NotifyingPartyRecommendation { get; init; } 
    #else
    public VoteInstruction5Code? NotifyingPartyRecommendation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes assigned per resolution to one security.
    /// </summary>
    [IsoId("_xdeaKfM8EeqRfth943bvEA")]
    [DisplayName("Entitlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Entitlmnt")]
    #endif
    [IsoXmlTag("Entitlmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Entitlement1Choice_? Entitlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Entitlement1Choice_? Entitlement { get; init; } 
    #else
    public Entitlement1Choice_? Entitlement { get; set; } 
    #endif
    
    /// <summary>
    /// Voting rights threshold required in percentage or in quantity to have the resolution approved.
    /// </summary>
    [IsoId("_xdeaK_M8EeqRfth943bvEA")]
    [DisplayName("Voting Rights Threshold For Approval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngRghtsThrshldForApprvl")]
    #endif
    [IsoXmlTag("VtngRghtsThrshldForApprvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOrPercentage1Choice_? VotingRightsThresholdForApproval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOrPercentage1Choice_? VotingRightsThresholdForApproval { get; init; } 
    #else
    public NumberOrPercentage1Choice_? VotingRightsThresholdForApproval { get; set; } 
    #endif
    
    /// <summary>
    /// Address to use over the www (HTTP) service where specific additional information on meeting resolutions may be found.
    /// </summary>
    [IsoId("_xdnkAfM8EeqRfth943bvEA")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URLAddress { get; init; } 
    #else
    public System.String? URLAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
