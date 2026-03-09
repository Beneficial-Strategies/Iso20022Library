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
/// Content of the Diagnosis Request message.
/// </summary>
[IsoId("_76gkoN6JEeiwsev40qZGEQ")]
[DisplayName("Diagnosis Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DiagnosisRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if Host Diagnosis are required.
    /// </summary>
    [IsoId("_BUIUsN6KEeiwsev40qZGEQ")]
    [DisplayName("Host Diagnosis Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstDgnssFlg")]
    #endif
    [IsoXmlTag("HstDgnssFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? HostDiagnosisFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HostDiagnosisFlag { get; init; } 
    #else
    public System.String? HostDiagnosisFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the Acquirers.
    /// </summary>
    [IsoId("_ETK4sN6KEeiwsev40qZGEQ")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerIdentification { get; init; } 
    #else
    public System.String? AcquirerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
