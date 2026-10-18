// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether order provided or took liquidity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_82hjEGvpEe2Re-GccwOX8g")]
[Description(@"Indicates whether order provided or took liquidity.")]
[Derivations(typeof(PassiveOrAgressiveType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PassiveOrAgressiveTypeCode>))]
public enum PassiveOrAgressiveTypeCode
{
    /// <summary>
    /// Order initiated the trade and thus took liquidity.
    /// Encoded/decoded by serializers as &quot;AGRE&quot;.
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_HbEf4GvqEe2Re-GccwOX8g")]
    [Description(@"Order initiated the trade and thus took liquidity.")]
    Aggresive,

    /// <summary>
    /// Order was already resting on the order book and providing liquidity.
    /// Encoded/decoded by serializers as &quot;PASV&quot;.
    /// </summary>
    [EnumMember(Value = "PASV")]
    [IsoId("_BGC3gGvqEe2Re-GccwOX8g")]
    [Description(@"Order was already resting on the order book and providing liquidity.")]
    Passive,
}
