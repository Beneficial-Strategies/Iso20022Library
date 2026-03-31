// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the issued undertaking name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-IP4InltEeG7BsjMvd1mEw_-583646723")]
[Description(@"Specifies the issued undertaking name.")]
[DerivedFrom(typeof(UndertakingIssuanceNameCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UndertakingIssuanceName1Code>))]
#endif
public enum UndertakingIssuanceName1Code
{
    /// <summary>
    /// Standby letter of credit.
    /// Encoded/decoded by serializers as &quot;STBY&quot;.
    /// </summary>
    [EnumMember(Value = "STBY")]
    [IsoId("_03AwIq-NEeG6R7UXUOz4dQ")]
    [Description(@"Standby letter of credit.")]
    Standby = UndertakingIssuanceNameCode.Standby, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Demand guarantee.
    /// Encoded/decoded by serializers as &quot;DGAR&quot;.
    /// </summary>
    [EnumMember(Value = "DGAR")]
    [IsoId("_nvg48q-OEeG6R7UXUOz4dQ")]
    [Description(@"Demand guarantee.")]
    Guarantee = UndertakingIssuanceNameCode.Guarantee, // same ordinal as derivation source for type conversions
}
