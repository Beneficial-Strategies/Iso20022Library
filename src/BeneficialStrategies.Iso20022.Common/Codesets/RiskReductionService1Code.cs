// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicator of a type of a post trade risk reduction operation for the purpose of reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3WO5sIKOEeyi6unpji8kcA")]
[Description(@"Indicator of a type of a post trade risk reduction operation for the purpose of reporting.")]
[DerivedFrom(typeof(RiskReductionServiceCode))]
public enum RiskReductionService1Code
{
    /// <summary>
    /// There is no portfolio compression.
    /// Encoded/decoded by serializers as &quot;NORR&quot;.
    /// </summary>
    [EnumMember(Value = "NORR")]
    [IsoId("_IMhhYYKPEeyi6unpji8kcA")]
    [Description(@"There is no portfolio compression.")]
    NoRiskReduction = RiskReductionServiceCode.NoRiskReduction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portfolio Compression without a third-party service provider.
    /// Encoded/decoded by serializers as &quot;PWOS&quot;.
    /// </summary>
    [EnumMember(Value = "PWOS")]
    [IsoId("_ITNYMYKPEeyi6unpji8kcA")]
    [Description(@"Portfolio Compression without a third-party service provider.")]
    NoThirdPartyPortfolioCompression = RiskReductionServiceCode.NoThirdPartyPortfolioCompression, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other portfolio compression.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_IYeSsYKPEeyi6unpji8kcA")]
    [Description(@"Other portfolio compression.")]
    OtherCompression = RiskReductionServiceCode.OtherCompression, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portfolio rebalancing or margin management.
    /// Encoded/decoded by serializers as &quot;PRBM&quot;.
    /// </summary>
    [EnumMember(Value = "PRBM")]
    [IsoId("_IeBhEYKPEeyi6unpji8kcA")]
    [Description(@"Portfolio rebalancing or margin management.")]
    PortfolioRebalancing = RiskReductionServiceCode.PortfolioRebalancing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portfolio Compression with a third-party service provider or CCP.
    /// Encoded/decoded by serializers as &quot;PWAS&quot;.
    /// </summary>
    [EnumMember(Value = "PWAS")]
    [IsoId("_IilQ8YKPEeyi6unpji8kcA")]
    [Description(@"Portfolio Compression with a third-party service provider or CCP.")]
    ThirdPartyPortfolioCompression = RiskReductionServiceCode.ThirdPartyPortfolioCompression, // same ordinal as derivation source for type conversions
    
}
