// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// RiskReductionServiceCode definition here
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LecYgCi6EeuKKc2MztSwPw")]
[Description(@"RiskReductionServiceCode definition here")]
[Derivations(typeof(RiskReductionService1Code))]
public enum RiskReductionServiceCode
{
    /// <summary>
    /// Portfolio Compression without a third-party service provider.
    /// Encoded/decoded by serializers as &quot;PWOS&quot;.
    /// </summary>
    [EnumMember(Value = "PWOS")]
    [IsoId("_aTUiECi6EeuKKc2MztSwPw")]
    [Description(@"Portfolio Compression without a third-party service provider.")]
    NoThirdPartyPortfolioCompression,

    /// <summary>
    /// Portfolio Compression with a third-party service provider or CCP.
    /// Encoded/decoded by serializers as &quot;PWAS&quot;.
    /// </summary>
    [EnumMember(Value = "PWAS")]
    [IsoId("_bNo1QCi6EeuKKc2MztSwPw")]
    [Description(@"Portfolio Compression with a third-party service provider or CCP.")]
    ThirdPartyPortfolioCompression,

    /// <summary>
    /// Portfolio rebalancing or margin management.
    /// Encoded/decoded by serializers as &quot;PRBM&quot;.
    /// </summary>
    [EnumMember(Value = "PRBM")]
    [IsoId("_cplO0Ci6EeuKKc2MztSwPw")]
    [Description(@"Portfolio rebalancing or margin management.")]
    PortfolioRebalancing,

    /// <summary>
    /// There is no portfolio compression.
    /// Encoded/decoded by serializers as &quot;NORR&quot;.
    /// </summary>
    [EnumMember(Value = "NORR")]
    [IsoId("_eBy-8Ci6EeuKKc2MztSwPw")]
    [Description(@"There is no portfolio compression.")]
    NoRiskReduction,

    /// <summary>
    /// Other portfolio compression.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_i2NJICi6EeuKKc2MztSwPw")]
    [Description(@"Other portfolio compression.")]
    OtherCompression,
}
