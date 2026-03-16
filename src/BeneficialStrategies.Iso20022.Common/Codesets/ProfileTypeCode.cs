// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2zud0CDNEeWPMvNwVtiMsA")]
[Description(@"Specifies the type of profile.")]
[Derivations(typeof(ProfileType1Code))]
public enum ProfileTypeCode
{
    /// <summary>
    /// Trading system of federal securities in the retail market directly to the investor. The operation can be performed directly over the Internet.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_-8nQgCDNEeWPMvNwVtiMsA")]
    [Description(
        @"Trading system of federal securities in the retail market directly to the investor. The operation can be performed directly over the Internet."
    )]
    Treasury,

    /// <summary>
    /// Investors operating through algorithms and send orders automatically according to the strategies defined by their managers. Through this access model, the participants of these servers are hosted primarily within the premises of Brazilian Market and significantly reduce the time of submission of offers to trading systems.
    /// Encoded/decoded by serializers as &quot;HFTR&quot;.
    /// </summary>
    [EnumMember(Value = "HFTR")]
    [IsoId("_CCfcUCDOEeWPMvNwVtiMsA")]
    [Description(
        @"Investors operating through algorithms and send orders automatically according to the strategies defined by their managers. Through this access model, the participants of these servers are hosted primarily within the premises of Brazilian Market and significantly reduce the time of submission of offers to trading systems."
    )]
    HighFrequencyTrader,

    /// <summary>
    /// Agent liquidity, liquidity facilitator, promoter of business, specialist, market maker and liquidity provider are some designations given to those who propose to provide liquidity and minimum reference price for assets previously accredited, factors highlighted in the analysis of efficiency in capital markets.
    /// Encoded/decoded by serializers as &quot;MAKE&quot;.
    /// </summary>
    [EnumMember(Value = "MAKE")]
    [IsoId("_Fz-J4CDOEeWPMvNwVtiMsA")]
    [Description(
        @"Agent liquidity, liquidity facilitator, promoter of business, specialist, market maker and liquidity provider are some designations given to those who propose to provide liquidity and minimum reference price for assets previously accredited, factors highlighted in the analysis of efficiency in capital markets."
    )]
    MarketMaker,

    /// <summary>
    /// Investor shares that uses defensive operations (hedging), thus avoiding the risk of large swings.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_PzIhsCDOEeWPMvNwVtiMsA")]
    [Description(
        @"Investor shares that uses defensive operations (hedging), thus avoiding the risk of large swings."
    )]
    Hedge,
}
