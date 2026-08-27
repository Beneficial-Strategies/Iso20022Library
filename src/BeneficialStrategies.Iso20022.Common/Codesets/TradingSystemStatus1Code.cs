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
[IsoId("_GigyIIo_EfCtyJmOYds7PQ")]
[Description(@"Status of the trading system.")]
[DerivedFrom(typeof(TradingSystemStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemStatus1Code>))]
public enum TradingSystemStatus1Code
{
    /// <summary>
    /// The trading system is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_IGEPkYo_EfCtyJmOYds7PQ")]
    [Description(@"The trading system is active.")]
    Active = TradingSystemStatusCode.Active,

    /// <summary>
    /// The trading system is disrupted
    /// Encoded/decoded by serializers as &quot;OTAG&quot;.
    /// </summary>
    [EnumMember(Value = "OTAG")]
    [IsoId("_IJNqMYo_EfCtyJmOYds7PQ")]
    [Description(@"The trading system is disrupted")]
    OutageOfTheTradingSystem = TradingSystemStatusCode.OutageOfTheTradingSystem,

    /// <summary>
    /// The trading system is partially disrupted
    /// Encoded/decoded by serializers as &quot;POTG&quot;.
    /// </summary>
    [EnumMember(Value = "POTG")]
    [IsoId("_IMLeoYo_EfCtyJmOYds7PQ")]
    [Description(@"The trading system is partially disrupted")]
    PartialOutageOfTheTradingSystem = TradingSystemStatusCode.PartialOutageOfTheTradingSystem,
}
