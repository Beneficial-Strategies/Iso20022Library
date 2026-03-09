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
/// Specifies an item in the agenda of the meeting. Some resolutions are submitted to the vote of the security holders, some are presented for information only.
/// </summary>
[IsoId("_Ti1Lodp-Ed-ak6NoX_4Aeg_-799797210")]
[DisplayName("Resolution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Resolution2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Resolution2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Resolution2( System.String reqIssuerLabel,ResolutionType1Code reqType,System.String reqForInformationOnly,ResolutionStatus1Code reqStatus,System.String reqSubmittedBySecurityHolder )
    {
        IssuerLabel = reqIssuerLabel;
        Type = reqType;
        ForInformationOnly = reqForInformationOnly;
        Status = reqStatus;
        SubmittedBySecurityHolder = reqSubmittedBySecurityHolder;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_Ti-8kNp-Ed-ak6NoX_4Aeg_-799797208")]
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
    [IsoId("_Ti-8kdp-Ed-ak6NoX_4Aeg_-799797185")]
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
    [IsoId("_Ti-8ktp-Ed-ak6NoX_4Aeg_-799797150")]
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
    /// Indicates whether a resolution is ordinary, extraordinary or special.
    /// </summary>
    [IsoId("_Ti-8k9p-Ed-ak6NoX_4Aeg_-799797133")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResolutionType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResolutionType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResolutionType1Code Type { get; init; } 
    #else
    public ResolutionType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the resolution is listed for information or for voting.
    /// </summary>
    [IsoId("_Ti-8lNp-Ed-ak6NoX_4Aeg_-799796898")]
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
    /// Indicates whether the resolution is active or withdrawn.
    /// </summary>
    [IsoId("_Ti-8ldp-Ed-ak6NoX_4Aeg_-799796873")]
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
    [IsoId("_Ti-8ltp-Ed-ak6NoX_4Aeg_-799796856")]
    [DisplayName("Submitted By Security Holder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmittdBySctyHldr")]
    #endif
    [IsoXmlTag("SubmittdBySctyHldr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SubmittedBySecurityHolder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SubmittedBySecurityHolder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SubmittedBySecurityHolder { get; init; } 
    #else
    public System.String SubmittedBySecurityHolder { get; set; } 
    #endif
    
    /// <summary>
    /// Vote options allowed at the resolution level. When specified, it supersedes the vote options given for the meeting.
    /// </summary>
    [IsoId("_Ti-8l9p-Ed-ak6NoX_4Aeg_-799796838")]
    [DisplayName("Vote Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrTp")]
    #endif
    [IsoXmlTag("VoteInstrTp")]
    [MinLength(0)]
    [MaxLength(8)]
    public SimpleValueList<VoteInstruction2Code> VoteInstructionType { get; init; } = new SimpleValueList<VoteInstruction2Code>(){};
    
    /// <summary>
    /// Indicates how the management of the issuing company wishes the security holders to vote.
    /// </summary>
    [IsoId("_Ti-8mNp-Ed-ak6NoX_4Aeg_-799796813")]
    [DisplayName("Management Recommendation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MgmtRcmmndtn")]
    #endif
    [IsoXmlTag("MgmtRcmmndtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstruction1Code? ManagementRecommendation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstruction1Code? ManagementRecommendation { get; init; } 
    #else
    public VoteInstruction1Code? ManagementRecommendation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how the notifying party recommends that the security holders vote.
    /// </summary>
    [IsoId("_Ti-8mdp-Ed-ak6NoX_4Aeg_-799796796")]
    [DisplayName("Notifying Party Recommendation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtifngPtyRcmmndtn")]
    #endif
    [IsoXmlTag("NtifngPtyRcmmndtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteInstruction1Code? NotifyingPartyRecommendation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstruction1Code? NotifyingPartyRecommendation { get; init; } 
    #else
    public VoteInstruction1Code? NotifyingPartyRecommendation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
