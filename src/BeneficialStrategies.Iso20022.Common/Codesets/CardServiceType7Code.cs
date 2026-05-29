// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of key exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LUv5URQjEfC_aaedwHHlmw")]
[Description(@"Type of key exchange.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardServiceType7Code>))]
public enum CardServiceType7Code
{
    /// <summary>
    /// Convey the key to the receiver.
    /// Encoded/decoded by serializers as &quot;KYDL&quot;.
    /// </summary>
    [EnumMember(Value = "KYDL")]
    [IsoId("_Lbtc8RQjEfC_aaedwHHlmw")]
    [Description(@"Convey the key to the receiver.")]
    DeliverKey = CardServiceTypeCode.DeliverKey,

    /// <summary>
    /// Deactivate the specified key.
    /// Encoded/decoded by serializers as &quot;DEKY&quot;.
    /// </summary>
    [EnumMember(Value = "DEKY")]
    [IsoId("_Lbtc9xQjEfC_aaedwHHlmw")]
    [Description(@"Deactivate the specified key.")]
    DeactivateKey = CardServiceTypeCode.DeactivateKey,

    /// <summary>
    /// Request new key to be generated and conveyed.
    /// Encoded/decoded by serializers as &quot;RQKY&quot;.
    /// </summary>
    [EnumMember(Value = "RQKY")]
    [IsoId("_Lbtc-RQjEfC_aaedwHHlmw")]
    [Description(@"Request new key to be generated and conveyed.")]
    RequestKey = CardServiceTypeCode.RequestKey,
}
