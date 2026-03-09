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
[IsoId("_X3w_o4xlEeKdxfnzD2sqyA")]
[DisplayName("Status And Sub Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusAndSubStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusAndSubStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusAndSubStatus1( Status13Choice_ reqStatusCode )
    {
        StatusCode = reqStatusCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status expressed as a code.
    /// </summary>
    [IsoId("_nBafUIxlEeKdxfnzD2sqyA")]
    [DisplayName("Status Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsCd")]
    #endif
    [IsoXmlTag("StsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Status13Choice_ StatusCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Status13Choice_ StatusCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status13Choice_ StatusCode { get; init; } 
    #else
    public Status13Choice_ StatusCode { get; set; } 
    #endif
    
    /// <summary>
    /// Sub status expressed as a code.
    /// </summary>
    [IsoId("_0h_vcIxlEeKdxfnzD2sqyA")]
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
