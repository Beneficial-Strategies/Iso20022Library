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
[IsoId("_5IBIoahOEeuOaMA1YOy5YQ")]
[DisplayName("Processing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingResult11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_5NhTsahOEeuOaMA1YOy5YQ")]
    [DisplayName("Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltData")]
    #endif
    [IsoXmlTag("RsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData7? ResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData7? ResultData { get; init; } 
    #else
    public ResultData7? ResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_5NhTs6hOEeuOaMA1YOy5YQ")]
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
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_5NhTtahOEeuOaMA1YOy5YQ")]
    [DisplayName("Action Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnReqrd")]
    #endif
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ActionRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ActionRequired { get; init; } 
    #else
    public System.String? ActionRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Set of actions to be performed.
    /// </summary>
    [IsoId("_5NhTt6hOEeuOaMA1YOy5YQ")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action13? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action13? Action { get; init; } 
    #else
    public Action13? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_5NhTuahOEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlActn")]
    #endif
    [IsoXmlTag("AddtlActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAction1? AdditionalAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAction1? AdditionalAction { get; init; } 
    #else
    public AdditionalAction1? AdditionalAction { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_5NhTu6hOEeuOaMA1YOy5YQ")]
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
