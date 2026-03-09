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
/// Defines the criteria used to report on business information.
/// </summary>
[IsoId("_1mEoCZlZEeeE1Ya-LgRsuQ")]
[DisplayName("General Business Information Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralBusinessInformationReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the qualifier is requested.
    /// </summary>
    [IsoId("_1t_N4ZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Qualifier Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfrInd")]
    #endif
    [IsoXmlTag("QlfrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? QualifierIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QualifierIndicator { get; init; } 
    #else
    public System.String? QualifierIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the subject is requested.
    /// </summary>
    [IsoId("_1t_N45lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbjtInd")]
    #endif
    [IsoXmlTag("SbjtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SubjectIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubjectIndicator { get; init; } 
    #else
    public System.String? SubjectIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the subject details are requested.
    /// </summary>
    [IsoId("_1t_N5ZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject Details Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbjtDtlsInd")]
    #endif
    [IsoXmlTag("SbjtDtlsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SubjectDetailsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubjectDetailsIndicator { get; init; } 
    #else
    public System.String? SubjectDetailsIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
