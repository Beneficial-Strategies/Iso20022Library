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
/// Specifies the details of the status.
/// </summary>
[IsoId("_VPaCAPH9Eeaz_YGUGLjP6A")]
[DisplayName("Status Detail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusDetail1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusDetail1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusDetail1( SupervisingAuthorityIdentification1 reqCompetentAuthority,System.String reqStatusReason )
    {
        CompetentAuthority = reqCompetentAuthority;
        StatusReason = reqStatusReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country of the institution relevant for the decision.
    /// </summary>
    [IsoId("_MvO2kD7yEee5faD4glTPKA")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the institution which is relevant for the decision.
    /// </summary>
    [IsoId("_J71NQfIDEeaz_YGUGLjP6A")]
    [DisplayName("Competent Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmptntAuthrty")]
    #endif
    [IsoXmlTag("CmptntAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SupervisingAuthorityIdentification1 CompetentAuthority { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SupervisingAuthorityIdentification1 CompetentAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupervisingAuthorityIdentification1 CompetentAuthority { get; init; } 
    #else
    public SupervisingAuthorityIdentification1 CompetentAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Code indicating the status following the decision.
    /// </summary>
    [IsoId("_g_8Q0fH9Eeaz_YGUGLjP6A")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Status { get; init; } 
    #else
    public System.String? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Code indicating the reason of the decision.
    /// </summary>
    [IsoId("_YID0sfH-Eeaz_YGUGLjP6A")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10Text StatusReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatusReason { get; init; } 
    #else
    public System.String StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Period of time when the decision is effective.
    /// </summary>
    [IsoId("_tG_sgTb5Eeer2ugaDqMdXg")]
    [DisplayName("Activity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyPrd")]
    #endif
    [IsoXmlTag("ActvtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? ActivityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? ActivityPeriod { get; init; } 
    #else
    public Period4Choice_? ActivityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Any other additional information about the decision.
    /// </summary>
    [IsoId("_uUdG8En5EeexwKvkdw4OGA")]
    [DisplayName("Comment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmnt")]
    #endif
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? Comment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Comment { get; init; } 
    #else
    public System.String? Comment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
