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
/// Result of the verification processing.
/// </summary>
[IsoId("_1rDZocsYEeuNe7RtB4qFHw")]
[DisplayName("Result Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResultData11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResultData11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResultData11( string reqResultDetails )
    {
        ResultDetails = reqResultDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Generic result of the processing.
    /// </summary>
    [IsoId("_1v-88csYEeuNe7RtB4qFHw")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Response10Code? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response10Code? Result { get; init; } 
    #else
    public Response10Code? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of result of the processing.
    /// </summary>
    [IsoId("_1v-888sYEeuNe7RtB4qFHw")]
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
    [IsoId("_5tJ9JMsYEeuNe7RtB4qFHw")]
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
    [IsoId("_1v-898sYEeuNe7RtB4qFHw")]
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
    /// Additional result information to be conveyed.
    /// </summary>
    [IsoId("_1v-8-csYEeuNe7RtB4qFHw")]
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
