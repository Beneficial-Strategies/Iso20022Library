// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether order provided or took liquidity, on partial fill or fill order events.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U1-l0GvqEe2Re-GccwOX8g")]
[Description(@"Indicates whether order provided or took liquidity, on partial fill or fill order events.")]
[DerivedFrom(typeof(PassiveOrAgressiveTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PassiveOrAgressiveType1Code>))]
public enum PassiveOrAgressiveType1Code
{
    /// <summary>
    /// Order initiated the trade and thus took liquidity.
    /// Encoded/decoded by serializers as &quot;AGRE&quot;.
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_Vox7wWvqEe2Re-GccwOX8g")]
    [Description(@"Order initiated the trade and thus took liquidity.")]
    Aggresive = PassiveOrAgressiveTypeCode.Aggresive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order was already resting on the order book and providing liquidity.
    /// Encoded/decoded by serializers as &quot;PASV&quot;.
    /// </summary>
    [EnumMember(Value = "PASV")]
    [IsoId("_Vuh-cWvqEe2Re-GccwOX8g")]
    [Description(@"Order was already resting on the order book and providing liquidity.")]
    Passive = PassiveOrAgressiveTypeCode.Passive, // same ordinal as derivation source for type conversions
}
