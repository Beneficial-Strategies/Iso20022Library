// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type for a contract for equity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SXRBIGlOEeaLAKoEUNsD9g")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnderlyingEquityType3Code>))]
#endif
public enum UnderlyingEquityType3Code
{
    /// <summary>
    /// Underlying is a basket.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_rI7j8WlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a basket.")]
    Basket = UnderlyingTypeV2Code.Basket, // same ordinal as derivation source for type conversions
}
