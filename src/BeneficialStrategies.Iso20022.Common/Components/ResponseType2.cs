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
/// Response of a requested service.
/// </summary>
[IsoId("_MGZDwXuGEeSZrqGdHyoIrw")]
[DisplayName("Response Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResponseType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResponseType2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResponseType2( Response3Code reqResult )
    {
        Result = reqResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of the request message or advice message.
    /// </summary>
    [IsoId("_w3tPcHuGEeSZrqGdHyoIrw")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Response3Code Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Response3Code Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response3Code Result { get; init; } 
    #else
    public Response3Code Result { get; set; } 
    #endif
    
    /// <summary>
    /// Detail of the result.
    /// </summary>
    [IsoId("_vcAUMHuLEeSZrqGdHyoIrw")]
    [DisplayName("Result Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltDtls")]
    #endif
    [IsoXmlTag("RsltDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultDetail1Code? ResultDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultDetail1Code? ResultDetails { get; init; } 
    #else
    public ResultDetail1Code? ResultDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_QIlfIHuMEeSZrqGdHyoIrw")]
    [DisplayName("Additional Result Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRsltInf")]
    #endif
    [IsoXmlTag("AddtlRsltInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalResultInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalResultInformation { get; init; } 
    #else
    public System.String? AdditionalResultInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
