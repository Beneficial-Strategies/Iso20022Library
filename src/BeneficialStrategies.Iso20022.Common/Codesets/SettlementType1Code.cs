// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates how an option trade is settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOH6d9p-Ed-ak6NoX_4Aeg_209112323")]
[Description(@"Indicates how an option trade is settled.")]
[DerivedFrom(typeof(SettlementTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementType1Code>))]
#endif
public enum SettlementType1Code
{
    /// <summary>
    /// Option trade is settled as principal.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_ZOH6eNp-Ed-ak6NoX_4Aeg_506485993")]
    [Description(@"Option trade is settled as principal.")]
    Principal = SettlementTypeCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option trade is netted off against another trade.
    /// Encoded/decoded by serializers as &quot;NETO&quot;.
    /// </summary>
    [EnumMember(Value = "NETO")]
    [IsoId("_ZOREYNp-Ed-ak6NoX_4Aeg_506486010")]
    [Description(@"Option trade is netted off against another trade.")]
    NettedOff = SettlementTypeCode.NettedOff, // same ordinal as derivation source for type conversions
}
