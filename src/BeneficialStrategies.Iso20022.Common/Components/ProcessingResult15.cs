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
/// Outcome of the processing of the authorisation.
/// </summary>
[IsoId("_nrR_ER1JEey8XKHwKquEQw")]
[DisplayName("Processing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingResult15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProcessingResult15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessingResult15( ResultData7 reqResultData )
    {
        ResultData = reqResultData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    [IsoId("_OiQNkSFZEey8XKHwKquEQw")]
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
    [IsoId("_nxhJ8R1JEey8XKHwKquEQw")]
    [DisplayName("Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltData")]
    #endif
    [IsoXmlTag("RsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResultData7 ResultData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResultData7 ResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData7 ResultData { get; init; } 
    #else
    public ResultData7 ResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Error detail information.
    /// </summary>
    [IsoId("_PfBX0SFZEey8XKHwKquEQw")]
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
    /// Outcome of a previous processing, for example, in response to a duplicate request
    /// </summary>
    [IsoId("_nxhJ8x1JEey8XKHwKquEQw")]
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
    [IsoId("_nxhJ9R1JEey8XKHwKquEQw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation29? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation29? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation29? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
