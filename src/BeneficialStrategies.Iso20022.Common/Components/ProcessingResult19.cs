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
[IsoId("_lsmvER1NEey8XKHwKquEQw")]
[DisplayName("Processing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingResult19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProcessingResult19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessingResult19( ResultData10 reqResultData )
    {
        ResultData = reqResultData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information about the entity that provides the response.
    /// </summary>
    [IsoId("_MXGhcCFVEey8XKHwKquEQw")]
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
    [IsoId("_lyq60R1NEey8XKHwKquEQw")]
    [DisplayName("Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltData")]
    #endif
    [IsoXmlTag("RsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResultData10 ResultData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResultData10 ResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData10 ResultData { get; init; } 
    #else
    public ResultData10 ResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Error detail information
    /// </summary>
    [IsoId("_R-g14CFVEey8XKHwKquEQw")]
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
    [IsoId("_lyq60x1NEey8XKHwKquEQw")]
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
    [IsoId("_lyq61R1NEey8XKHwKquEQw")]
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
