// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the order is to buy or sell.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CVA04GzCEe23cotbkl38pw")]
[Description(@"Indicates whether the order is to buy or sell.")]
[DerivedFrom(typeof(SideCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<Side6Code>))]
public enum Side6Code
{
    /// <summary>
    /// Order is buy driven.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("_ETNm8WzCEe23cotbkl38pw")]
    [Description(@"Order is buy driven.")]
    Buy = SideCode.Buy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_EqamAWzCEe23cotbkl38pw")]
    [Description(@"Order is sell driven.")]
    Sell = SideCode.Sell, // same ordinal as derivation source for type conversions
}
