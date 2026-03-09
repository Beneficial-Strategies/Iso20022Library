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
/// Result of the processing.
/// </summary>
[IsoId("_ms_0QahNEeuOaMA1YOy5YQ")]
[DisplayName("Result Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResultData7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResultData7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResultData7( string reqResultDetails )
    {
        ResultDetails = reqResultDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Generic result of the processing.
    /// ISO 8583 bit 39
    /// </summary>
    [IsoId("_myQuwahNEeuOaMA1YOy5YQ")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Response8Code? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response8Code? Result { get; init; } 
    #else
    public Response8Code? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_myQuw6hNEeuOaMA1YOy5YQ")]
    [DisplayName("Other Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRslt")]
    #endif
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherResult { get; init; } 
    #else
    public System.String? OtherResult { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed results of the processing, conforming to ISO 8583 Response codes list.  This code list is maintained by the ISO 8583/MA (maintenance agency).
    /// </summary>
    [IsoId("_myQuxahNEeuOaMA1YOy5YQ")]
    [DisplayName("Result Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltDtls")]
    #endif
    [IsoXmlTag("RsltDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISO8583ResponseCode ResultDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ResultDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ResultDetails { get; init; } 
    #else
    public string ResultDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Other result details of the processing.
    /// </summary>
    [IsoId("_myQux6hNEeuOaMA1YOy5YQ")]
    [DisplayName("Other Result Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRsltDtls")]
    #endif
    [IsoXmlTag("OthrRsltDtls")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherResultDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherResultDetails { get; init; } 
    #else
    public System.String? OtherResultDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer permits reuse of temporary secure stored card data.
    /// </summary>
    [IsoId("_1LCyMKhNEeuOaMA1YOy5YQ")]
    [DisplayName("Temporary Secure Card Data Reuse Permitted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TempScrCardDataReusePrtd")]
    #endif
    [IsoXmlTag("TempScrCardDataReusePrtd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TemporarySecureCardDataReusePermitted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TemporarySecureCardDataReusePermitted { get; init; } 
    #else
    public System.String? TemporarySecureCardDataReusePermitted { get; set; } 
    #endif
    
    /// <summary>
    /// Additional result information to be conveyed.
    /// </summary>
    [IsoId("_myQuyahNEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Result Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsltInf")]
    #endif
    [IsoXmlTag("AddtlRsltInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalResultInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalResultInformation { get; init; } 
    #else
    public AdditionalData1? AdditionalResultInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
