// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of the trading system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xXWb8Io-EfCtyJmOYds7PQ")]
[Description(@"Status of the trading system.")]
[Derivations(typeof(TradingSystemStatus1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemStatusCode>))]
public enum TradingSystemStatusCode
{
    /// <summary>
    /// The trading system is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_3aH2sIo-EfCtyJmOYds7PQ")]
    [Description(@"The trading system is active.")]
    Active,

    /// <summary>
    /// The trading system is disrupted
    /// Encoded/decoded by serializers as &quot;OTAG&quot;.
    /// </summary>
    [EnumMember(Value = "OTAG")]
    [IsoId("_6T0AoIo-EfCtyJmOYds7PQ")]
    [Description(@"The trading system is disrupted")]
    OutageOfTheTradingSystem,

    /// <summary>
    /// The trading system is partially disrupted
    /// Encoded/decoded by serializers as &quot;POTG&quot;.
    /// </summary>
    [EnumMember(Value = "POTG")]
    [IsoId("_AFcoEIo_EfCtyJmOYds7PQ")]
    [Description(@"The trading system is partially disrupted")]
    PartialOutageOfTheTradingSystem,
}
