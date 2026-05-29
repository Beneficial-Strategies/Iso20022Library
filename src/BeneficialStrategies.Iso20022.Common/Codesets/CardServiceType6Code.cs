// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0VkAwRQiEfC_aaedwHHlmw")]
[Description(@"Type of reconciliation.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardServiceType6Code>))]
public enum CardServiceType6Code
{
    /// <summary>
    /// Partial reconciliation of the day.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_0dBToRQiEfC_aaedwHHlmw")]
    [Description(@"Partial reconciliation of the day.")]
    CheckPoint = CardServiceTypeCode.CheckPoint,

    /// <summary>
    /// Final reconciliation.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_0dBToxQiEfC_aaedwHHlmw")]
    [Description(@"Final reconciliation.")]
    Final = CardServiceTypeCode.Final,
}
