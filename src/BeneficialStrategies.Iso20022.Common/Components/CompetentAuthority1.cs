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
/// Identification of the competent authority which supervises the reporting counterparty.
/// </summary>
[IsoId("_jODlAIAuEeirUu_C8Wn_0Q")]
[DisplayName("Competent Authority")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompetentAuthority1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CompetentAuthority1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CompetentAuthority1( System.String reqIdentification,System.String reqOnboardingStatus )
    {
        Identification = reqIdentification;
        OnboardingStatus = reqOnboardingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification field for the competent authority.
    /// </summary>
    [IsoId("_r8tXMIAuEeirUu_C8Wn_0Q")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the onboarding status of the competent authority.
    /// </summary>
    [IsoId("_tq-24IAuEeirUu_C8Wn_0Q")]
    [DisplayName("Onboarding Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnbrdgSts")]
    #endif
    [IsoXmlTag("OnbrdgSts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator OnboardingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OnboardingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OnboardingStatus { get; init; } 
    #else
    public System.String OnboardingStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
