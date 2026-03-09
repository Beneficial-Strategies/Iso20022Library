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
/// Identifies the benchmark against which the financial instrument is measured.
/// </summary>
[IsoId("_P1sQ4ZJKEeuAlLVx8pyt3w")]
[DisplayName("Benchmark Curve")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BenchmarkCurve6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Either a swap spread or spread to benchmark depending upon order type. In case of a spread to benchmark, the price offset is expressed in terms of basis points relative to a benchmark - this can be a positive or a negative spread. In case of a swap spread, the price offset is a target spread for a swap.
    /// </summary>
    [IsoId("_P3vfUZJKEeuAlLVx8pyt3w")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Spread { get; init; } 
    #else
    public System.UInt64? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_P3vfWZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BchmkId")]
    #endif
    [IsoXmlTag("BchmkId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification39? BenchmarkIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification39? BenchmarkIdentification { get; init; } 
    #else
    public SecurityIdentification39? BenchmarkIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the price of the benchmark security.
    /// </summary>
    [IsoId("_P3vfW5JKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BchmkPric")]
    #endif
    [IsoXmlTag("BchmkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? BenchmarkPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? BenchmarkPrice { get; init; } 
    #else
    public Price8? BenchmarkPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the currency used for the benchmark curve.
    /// </summary>
    [IsoId("_P3vfaZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Curve Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BchmkCrvCcy")]
    #endif
    [IsoXmlTag("BchmkCrvCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? BenchmarkCurveCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BenchmarkCurveCurrency { get; init; } 
    #else
    public string? BenchmarkCurveCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the name of the benchmark curve.
    /// </summary>
    [IsoId("_P3vfcZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Curve Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BchmkCrvNm")]
    #endif
    [IsoXmlTag("BchmkCrvNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BenchmarkCurveName7Choice_? BenchmarkCurveName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenchmarkCurveName7Choice_? BenchmarkCurveName { get; init; } 
    #else
    public BenchmarkCurveName7Choice_? BenchmarkCurveName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a point on a benchmark curve. The point can be stated via a combination of maturity month/year and coupon.
    /// </summary>
    [IsoId("_P3vfeZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Curve Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BchmkCrvPt")]
    #endif
    [IsoXmlTag("BchmkCrvPt")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? BenchmarkCurvePoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BenchmarkCurvePoint { get; init; } 
    #else
    public System.String? BenchmarkCurvePoint { get; set; } 
    #endif
    
    
    #nullable disable
    
}
