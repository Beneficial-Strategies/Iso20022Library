// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regulatory trading capacity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CeQmoO8bEeSLA89yUYsVSw")]
[Description(@"Specifies the regulatory trading capacity.")]
[Derivations(typeof(RegulatoryTradingCapacity1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RegulatoryTradingCapacityCode>))]
#endif
public enum RegulatoryTradingCapacityCode
{
    /// <summary>
    /// Transaction was carried out as a deal under own account.
    /// Encoded/decoded by serializers as &quot;DEAL&quot;.
    /// </summary>
    [EnumMember(Value = "DEAL")]
    [IsoId("_P5TPcO8bEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as a deal under own account.")]
    DealOnOwnAccount,

    /// <summary>
    /// Transaction was carried out as a matched principal trading.
    /// Encoded/decoded by serializers as &quot;MTCH&quot;.
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_ktFAYO8bEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as a matched principal trading.")]
    MatchedPrincipal,

    /// <summary>
    /// Transaction was carried out as an agent.
    /// Encoded/decoded by serializers as &quot;AOTC&quot;.
    /// </summary>
    [EnumMember(Value = "AOTC")]
    [IsoId("_wXAQ4O8bEeSLA89yUYsVSw")]
    [Description(@"Transaction was carried out as an agent.")]
    AnyOtherCapacity,
}
