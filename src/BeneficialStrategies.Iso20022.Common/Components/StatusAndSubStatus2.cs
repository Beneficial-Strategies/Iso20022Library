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
/// Specifies the status and optionally the sub status.
/// </summary>
[IsoId("_Ka_gd5U7EeaYkf5FCqYMeA")]
[DisplayName("Status And Sub Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusAndSubStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusAndSubStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusAndSubStatus2( Status27Choice_ reqStatusCode )
    {
        StatusCode = reqStatusCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_KmBEoZU7EeaYkf5FCqYMeA")]
    [DisplayName("Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsCd")]
    #endif
    [IsoXmlTag("StsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status27Choice_ StatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status27Choice_ StatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status27Choice_ StatusCode { get; init; } 
    #else
    public Status27Choice_ StatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// Sub status expressed as a code.
    /// </summary>
    [IsoId("_KmBEo5U7EeaYkf5FCqYMeA")]
    [DisplayName("Sub Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubStsCd")]
    #endif
    [IsoXmlTag("SubStsCd")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4AlphaNumericText? SubStatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubStatusCode { get; init; } 
    #else
    public System.String? SubStatusCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
