// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Scenario type based on the type of portfolio the scenario is designed to stress.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4xqg8KstEeayv9XxdmMwKQ")]
[Description(@"Scenario type based on the type of portfolio the scenario is designed to stress.")]
[Derivations(typeof(StrategyStressType1Code))]
public enum StrategyStressTypeCode
{
    /// <summary>
    /// Scenario, either by design or otherwise, that primarily tests the sensitivity of a portfolio of derivatives with a common underlying to differences in the valuation of such derivatives caused by differences in the maturity of such contracts. Typically, flex scenarios are aimed at stressing the valuation of portfolios that are insensitive to small movements in an underlying but sensitive to differences in the reaction of such portfolios in time space. For instance, calendar spreads or flattening or steeping positions in interest rate space.
    /// Encoded/decoded by serializers as &quot;FLEX&quot;.
    /// </summary>
    [EnumMember(Value = "FLEX")]
    [IsoId("_8TNVEKstEeayv9XxdmMwKQ")]
    [Description(@"Scenario, either by design or otherwise, that primarily tests the sensitivity of a portfolio of derivatives with a common underlying to differences in the valuation of such derivatives caused by differences in the maturity of such contracts. Typically, flex scenarios are aimed at stressing the valuation of portfolios that are insensitive to small movements in an underlying but sensitive to differences in the reaction of such portfolios in time space. For instance, calendar spreads or flattening or steeping positions in interest rate space.")]
    Flex,
    
    /// <summary>
    /// Scenario, either by design or otherwise, that primarily tests the sensitivity of a portfolio of derivatives to changes in the value of a common underlying. For example as parallel shift of an interest rate curve.
    /// Encoded/decoded by serializers as &quot;PRLL&quot;.
    /// </summary>
    [EnumMember(Value = "PRLL")]
    [IsoId("_-i6t4KstEeayv9XxdmMwKQ")]
    [Description(@"Scenario, either by design or otherwise, that primarily tests the sensitivity of a portfolio of derivatives to changes in the value of a common underlying. For example as parallel shift of an interest rate curve.")]
    Parallel,
    
    /// <summary>
    /// Scenario, either by design or otherwise, that primarily tests the sensitivity of a portfolio of derivatives with differing, but correlated underlyings. Typically, spread scenarios are aimed at stressing the valuation of portfolios that are insensitive to small co-movements in a set of underlyings but sensitive to differences in the reaction of such portfolios to breakdowns in historical correlations or covariance.
    /// Encoded/decoded by serializers as &quot;SPRD&quot;.
    /// </summary>
    [EnumMember(Value = "SPRD")]
    [IsoId("_oG4N0OonEeadseq5W5YLvQ")]
    [Description(@"Scenario, either by design or otherwise, that primarily tests the sensitivity of a portfolio of derivatives with differing, but correlated underlyings. Typically, spread scenarios are aimed at stressing the valuation of portfolios that are insensitive to small co-movements in a set of underlyings but sensitive to differences in the reaction of such portfolios to breakdowns in historical correlations or covariance.")]
    Spread,
    
}
