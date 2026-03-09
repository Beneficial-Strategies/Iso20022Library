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
/// Outcome of the processing of the transaction.
/// </summary>
[IsoId("_BRhi8csYEeuNe7RtB4qFHw")]
[DisplayName("Processing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingResult14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The information of the entity that provides the response.
    /// </summary>
    [IsoId("_8iIwsCFQEey8XKHwKquEQw")]
    [DisplayName("Response Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnSrc")]
    #endif
    [IsoXmlTag("RspnSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApprovalEntity2? ResponseSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApprovalEntity2? ResponseSource { get; init; } 
    #else
    public ApprovalEntity2? ResponseSource { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_BVvUkcsYEeuNe7RtB4qFHw")]
    [DisplayName("Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltData")]
    #endif
    [IsoXmlTag("RsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData10? ResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData10? ResultData { get; init; } 
    #else
    public ResultData10? ResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_SndCACFREey8XKHwKquEQw")]
    [DisplayName("Error Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrDtl")]
    #endif
    [IsoXmlTag("ErrDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ErrorDetails2? ErrorDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorDetails2? ErrorDetail { get; init; } 
    #else
    public ErrorDetails2? ErrorDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_BVvUk8sYEeuNe7RtB4qFHw")]
    [DisplayName("Original Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRsltData")]
    #endif
    [IsoXmlTag("OrgnlRsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData7? OriginalResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData7? OriginalResultData { get; init; } 
    #else
    public ResultData7? OriginalResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_BVvUlcsYEeuNe7RtB4qFHw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation30? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
