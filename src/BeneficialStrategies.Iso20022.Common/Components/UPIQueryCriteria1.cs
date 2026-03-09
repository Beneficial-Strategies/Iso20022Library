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
/// Identification through a unique product identifier.
/// </summary>
[IsoId("_4iN1MJNkEeytjZlcgApf6A")]
[DisplayName("UPI Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UPIQueryCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_Ab3SAJNlEeytjZlcgApf6A")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identifier { get; init; } 
    #else
    public System.String? Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_D53p8JNlEeytjZlcgApf6A")]
    [DisplayName("Not Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotRptd")]
    #endif
    [IsoXmlTag("NotRptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotReported1Code? NotReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotReported1Code? NotReported { get; init; } 
    #else
    public NotReported1Code? NotReported { get; set; } 
    #endif
    
    
    #nullable disable
    
}
