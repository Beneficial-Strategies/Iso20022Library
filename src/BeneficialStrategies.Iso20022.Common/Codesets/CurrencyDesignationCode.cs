// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a currency is settled offshore or onshore.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zhg64Qd1EeSPHJIdUs1USg")]
[Description(@"Specifies whether a currency is settled offshore or onshore.")]
[Derivations(typeof(CurrencyDesignation1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CurrencyDesignationCode>))]
#endif
public enum CurrencyDesignationCode
{
    /// <summary>
    /// Onshore.
    /// Encoded/decoded by serializers as &quot;ONSH&quot;.
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_6C154Ad1EeSPHJIdUs1USg")]
    [Description(@"Onshore.")]
    Onshore,

    /// <summary>
    /// Offshore.
    /// Encoded/decoded by serializers as &quot;OFFS&quot;.
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_80VxIAd1EeSPHJIdUs1USg")]
    [Description(@"Offshore.")]
    Offshore,
}
