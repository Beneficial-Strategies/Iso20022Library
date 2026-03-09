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
/// Provides detailed information about an announcement.
/// </summary>
[IsoId("_RjH9odp-Ed-ak6NoX_4Aeg_245466411")]
[DisplayName("Corporate Action Notification Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationAdvice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotificationAdvice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotificationAdvice1( CorporateAction2 reqCorporateActionDetails )
    {
        CorporateActionDetails = reqCorporateActionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides detailed information about the corporate action event.
    /// </summary>
    [IsoId("_RjH9otp-Ed-ak6NoX_4Aeg_343360548")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateAction2 CorporateActionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateAction2 CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction2 CorporateActionDetails { get; init; } 
    #else
    public CorporateAction2 CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about an option of a CA event.
    /// </summary>
    [IsoId("_RjH9o9p-Ed-ak6NoX_4Aeg_635191264")]
    [DisplayName("Corporate Action Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnOptnDtls")]
    #endif
    [IsoXmlTag("CorpActnOptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption1? CorporateActionOptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1? CorporateActionOptionDetails { get; init; } 
    #else
    public CorporateActionOption1? CorporateActionOptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
