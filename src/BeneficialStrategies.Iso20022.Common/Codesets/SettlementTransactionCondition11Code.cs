// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which a order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6sgV0Ec8EeaBWtcfqEyXyw")]
[Description(@"Specifies the conditions under which a order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementTransactionCondition11Code>))]
#endif
public enum SettlementTransactionCondition11Code
{
    /// <summary>
    /// No market claim should be automatically generated.
    /// Encoded/decoded by serializers as &quot;NOMC&quot;.
    /// </summary>
    [EnumMember(Value = "NOMC")]
    [IsoId("_87Lz4Uc8EeaBWtcfqEyXyw")]
    [Description(@"No market claim should be automatically generated.")]
    NoAutomaticMarketClaim = SettlementTransactionConditionCode.NoAutomaticMarketClaim, // same ordinal as derivation source for type conversions
}
