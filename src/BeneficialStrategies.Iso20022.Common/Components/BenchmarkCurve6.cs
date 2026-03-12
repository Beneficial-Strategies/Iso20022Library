// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the benchmark against which the financial instrument is measured.
/// </summary>
[IsoId("_P1sQ4ZJKEeuAlLVx8pyt3w")]
[DisplayName("Benchmark Curve")]
public partial record BenchmarkCurve6
{
    #nullable enable
    
    /// <summary>
    /// Either a swap spread or spread to benchmark depending upon order type. In case of a spread to benchmark, the price offset is expressed in terms of basis points relative to a benchmark - this can be a positive or a negative spread. In case of a swap spread, the price offset is a target spread for a swap.
    /// </summary>
    [IsoId("_P3vfUZJKEeuAlLVx8pyt3w")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Spread { get; init; } 
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_P3vfWZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Identification")]
    [IsoXmlTag("BchmkId")]
    public SecurityIdentification39? BenchmarkIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the price of the benchmark security.
    /// </summary>
    [IsoId("_P3vfW5JKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Price")]
    [IsoXmlTag("BchmkPric")]
    public Price8? BenchmarkPrice { get; init; } 
    
    /// <summary>
    /// Identifies the currency used for the benchmark curve.
    /// </summary>
    [IsoId("_P3vfaZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Curve Currency")]
    [IsoXmlTag("BchmkCrvCcy")]
    public ActiveOrHistoricCurrencyCode? BenchmarkCurveCurrency { get; init; } 
    
    /// <summary>
    /// Identifies the name of the benchmark curve.
    /// </summary>
    [IsoId("_P3vfcZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Curve Name")]
    [IsoXmlTag("BchmkCrvNm")]
    public BenchmarkCurveName7Choice_? BenchmarkCurveName { get; init; } 
    
    /// <summary>
    /// Identifies a point on a benchmark curve. The point can be stated via a combination of maturity month/year and coupon.
    /// </summary>
    [IsoId("_P3vfeZJKEeuAlLVx8pyt3w")]
    [DisplayName("Benchmark Curve Point")]
    [IsoXmlTag("BchmkCrvPt")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? BenchmarkCurvePoint { get; init; } 
    
    
    #nullable disable
    
}
