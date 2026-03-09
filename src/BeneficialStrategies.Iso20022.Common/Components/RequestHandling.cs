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
/// Explains the status of the related request.
/// </summary>
[IsoId("_RH29-Np-Ed-ak6NoX_4Aeg_-1267403879")]
[DisplayName("Request Handling")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequestHandling
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequestHandling instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequestHandling( System.String reqStatusCode )
    {
        StatusCode = reqStatusCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the request.
    /// </summary>
    [IsoId("_RH29-dp-Ed-ak6NoX_4Aeg_-1267403878")]
    [DisplayName("Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsCd")]
    #endif
    [IsoXmlTag("StsCd")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText StatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String StatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String StatusCode { get; init; } 
    #else
    public System.String StatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the status, in free format text.
    /// </summary>
    [IsoId("_RH29-tp-Ed-ak6NoX_4Aeg_-1267403877")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
