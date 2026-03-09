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
/// Additional details to clarify response codes.
/// </summary>
[IsoId("_W-pnUBE7EeafpqhYGpTDnw")]
[DisplayName("Response Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResponseDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResponseDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResponseDetails1( System.String reqResponseCode )
    {
        ResponseCode = reqResponseCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code for account servicer warnings, rejections, pay no/pay responses and technical rejections. 
    /// </summary>
    [IsoId("_kLn-8BE7EeafpqhYGpTDnw")]
    [DisplayName("Response Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnCd")]
    #endif
    [IsoXmlTag("RspnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ResponseCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ResponseCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ResponseCode { get; init; } 
    #else
    public System.String ResponseCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to elaborate upon response codes.
    /// </summary>
    [IsoId("_n4DNYBE7EeafpqhYGpTDnw")]
    [DisplayName("Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlDtls")]
    #endif
    [IsoXmlTag("AddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalDetails { get; init; } 
    #else
    public System.String? AdditionalDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
