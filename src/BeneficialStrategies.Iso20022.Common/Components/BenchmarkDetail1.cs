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
/// Specifies further details of the benchmark.
/// </summary>
[IsoId("_ZCkIIPKNEeaz_YGUGLjP6A")]
[DisplayName("Benchmark Detail")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BenchmarkDetail1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BenchmarkDetail1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BenchmarkDetail1( System.String reqFullName )
    {
        FullName = reqFullName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Full name of the benchmark.
    /// </summary>
    [IsoId("_D5BoIBnVEee-a6ThOKLTug")]
    [DisplayName("Full Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullNm")]
    #endif
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text FullName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FullName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FullName { get; init; } 
    #else
    public System.String FullName { get; set; } 
    #endif
    
    /// <summary>
    /// Index name of the benchmark.
    /// </summary>
    [IsoId("_QgI5oBnVEee-a6ThOKLTug")]
    [DisplayName("Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Indx")]
    #endif
    [IsoXmlTag("Indx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BenchmarkCurveName2Code? Index { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenchmarkCurveName2Code? Index { get; init; } 
    #else
    public BenchmarkCurveName2Code? Index { get; set; } 
    #endif
    
    /// <summary>
    /// Any other additional information about the benchmark.
    /// </summary>
    [IsoId("_-cTTsDrkEeedCZZ8dIPp6g")]
    [DisplayName("Comment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmnt")]
    #endif
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? Comment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Comment { get; init; } 
    #else
    public System.String? Comment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
