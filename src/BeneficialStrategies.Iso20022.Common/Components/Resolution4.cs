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
[IsoId("_v_saca34EemG7MmivSuE5g")]
[DisplayName("Resolution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Resolution4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Resolution4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Resolution4( System.String reqIssuerLabel,System.String reqForInformationOnly,ResolutionStatus1Code reqStatus )
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
    [IsoId("_wWwPk634EemG7MmivSuE5g")]
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
    /// Free text description of the resolution.
    /// </summary>
    [IsoId("_wWwPla34EemG7MmivSuE5g")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    /// <summary>
    /// Abbreviated description of the resolution.
    /// </summary>
    [IsoId("_wWwPl634EemG7MmivSuE5g")]
    [DisplayName("Title")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Titl")]
    #endif
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Title { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Title { get; init; } 
    #else
    public System.String? Title { get; set; } 
    #endif
    
    /// <summary>
    /// Type of resolution.
    /// </summary>
    [IsoId("_wWwPma34EemG7MmivSuE5g")]
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
    [IsoId("_wWwPm634EemG7MmivSuE5g")]
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
    [IsoId("_kFUoQK36EemG7MmivSuE5g")]
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
    [IsoId("_wWwPna34EemG7MmivSuE5g")]
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
    [IsoId("_wWwPn634EemG7MmivSuE5g")]
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
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_J3mZUK4JEemG7MmivSuE5g")]
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
    [IsoId("_wWwPo634EemG7MmivSuE5g")]
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
    [IsoId("_wWwPpa34EemG7MmivSuE5g")]
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
    [IsoId("_wWwPp634EemG7MmivSuE5g")]
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
    [IsoId("_TR8mUK4pEemG7MmivSuE5g")]
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
    [IsoId("_39sLwK34EemG7MmivSuE5g")]
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
