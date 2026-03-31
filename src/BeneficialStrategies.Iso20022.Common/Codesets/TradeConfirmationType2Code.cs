// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that the contract was electronically non-confirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-AnesA27EeWmAKKPnqYEVQ")]
[Description(@"Specifies that the contract was electronically non-confirmed.")]
[DerivedFrom(typeof(TradeConfirmationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradeConfirmationType2Code>))]
#endif
public enum TradeConfirmationType2Code
{
    /// <summary>
    /// Non-confirmed.
    /// Encoded/decoded by serializers as &quot;NCNF&quot;.
    /// </summary>
    [EnumMember(Value = "NCNF")]
    [IsoId("_HQSTQQ28EeWmAKKPnqYEVQ")]
    [Description(@"Non-confirmed.")]
    NonConfirmed = TradeConfirmationTypeCode.NonConfirmed, // same ordinal as derivation source for type conversions
}
