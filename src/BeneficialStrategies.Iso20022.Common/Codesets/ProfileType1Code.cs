// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LGXUsCGLEeW_v8XsK-l3KA")]
[Description(@"Specifies the type of profile.")]
[DerivedFrom(typeof(ProfileTypeCode))]
public enum ProfileType1Code
{
    /// <summary>
    /// Investor shares that uses defensive operations (hedging), thus avoiding the risk of large swings.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_N0lOcSGLEeW_v8XsK-l3KA")]
    [Description(@"Investor shares that uses defensive operations (hedging), thus avoiding the risk of large swings.")]
    Hedge = ProfileTypeCode.Hedge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investors operating through algorithms and send orders automatically according to the strategies defined by their managers. Through this access model, the participants of these servers are hosted primarily within the premises of Brazilian Market and significantly reduce the time of submission of offers to trading systems.
    /// Encoded/decoded by serializers as &quot;HFTR&quot;.
    /// </summary>
    [EnumMember(Value = "HFTR")]
    [IsoId("_N8nJESGLEeW_v8XsK-l3KA")]
    [Description(@"Investors operating through algorithms and send orders automatically according to the strategies defined by their managers. Through this access model, the participants of these servers are hosted primarily within the premises of Brazilian Market and significantly reduce the time of submission of offers to trading systems.")]
    HighFrequencyTrader = ProfileTypeCode.HighFrequencyTrader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent liquidity, liquidity facilitator, promoter of business, specialist, market maker and liquidity provider are some designations given to those who propose to provide liquidity and minimum reference price for assets previously accredited, factors highlighted in the analysis of efficiency in capital markets.
    /// Encoded/decoded by serializers as &quot;MAKE&quot;.
    /// </summary>
    [EnumMember(Value = "MAKE")]
    [IsoId("_OEpDsSGLEeW_v8XsK-l3KA")]
    [Description(@"Agent liquidity, liquidity facilitator, promoter of business, specialist, market maker and liquidity provider are some designations given to those who propose to provide liquidity and minimum reference price for assets previously accredited, factors highlighted in the analysis of efficiency in capital markets.")]
    MarketMaker = ProfileTypeCode.MarketMaker, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trading system of federal securities in the retail market directly to the investor. The operation can be performed directly over the Internet.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_OMrlYSGLEeW_v8XsK-l3KA")]
    [Description(@"Trading system of federal securities in the retail market directly to the investor. The operation can be performed directly over the Internet.")]
    Treasury = ProfileTypeCode.Treasury, // same ordinal as derivation source for type conversions
    
}
