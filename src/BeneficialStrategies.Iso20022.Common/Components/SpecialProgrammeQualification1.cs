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
/// Data to qualify for incentive or other related programmes.
/// </summary>
[IsoId("_NqO3MEU9Eeea-M6VZkEPUw")]
[DisplayName("Special Programme Qualification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SpecialProgrammeQualification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of special programme.
    /// </summary>
    [IsoId("_hm4y4EU9Eeea-M6VZkEPUw")]
    [DisplayName("Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prgrmm")]
    #endif
    [IsoXmlTag("Prgrmm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Programme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Programme { get; init; } 
    #else
    public System.String? Programme { get; set; } 
    #endif
    
    /// <summary>
    /// Name and value associated with a special programme.
    /// </summary>
    [IsoId("_oRYU8EU9Eeea-M6VZkEPUw")]
    [DisplayName("Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dtl")]
    #endif
    [IsoXmlTag("Dtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialProgrammeDetails1? Detail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialProgrammeDetails1? Detail { get; init; } 
    #else
    public SpecialProgrammeDetails1? Detail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
