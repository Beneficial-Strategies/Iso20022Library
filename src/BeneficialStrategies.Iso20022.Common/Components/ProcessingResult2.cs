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
[IsoId("_U2HhkU9uEeePXdaAO32Uew")]
[DisplayName("Processing Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingResult2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data pertaining to the approval of the transaction.
    /// </summary>
    [IsoId("_VBbZsU9uEeePXdaAO32Uew")]
    [DisplayName("Approval Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlData")]
    #endif
    [IsoXmlTag("ApprvlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ApprovalData1? ApprovalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ApprovalData1? ApprovalData { get; init; } 
    #else
    public ApprovalData1? ApprovalData { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_VBbZs09uEeePXdaAO32Uew")]
    [DisplayName("Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltData")]
    #endif
    [IsoXmlTag("RsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData1? ResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData1? ResultData { get; init; } 
    #else
    public ResultData1? ResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_fda3cE9uEeePXdaAO32Uew")]
    [DisplayName("Original Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRsltData")]
    #endif
    [IsoXmlTag("OrgnlRsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResultData1? OriginalResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResultData1? OriginalResultData { get; init; } 
    #else
    public ResultData1? OriginalResultData { get; set; } 
    #endif
    
    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_fiPv4Z1IEeeuzZPGP9QqVw")]
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
    [IsoId("_VBbZtU9uEeePXdaAO32Uew")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action9? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action9? Action { get; init; } 
    #else
    public Action9? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_VBbZt09uEeePXdaAO32Uew")]
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
    [IsoId("_VBbZuU9uEeePXdaAO32Uew")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation20? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation20? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation20? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
