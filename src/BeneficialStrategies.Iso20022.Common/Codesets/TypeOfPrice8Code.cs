// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vgl4xNp-Ed-ak6NoX_4Aeg_-1213619155")]
[Description(@"Specifies the type of price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfPrice8Code>))]
#endif
public enum TypeOfPrice8Code
{
    /// <summary>
    /// True offer price.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Vgl4xdp-Ed-ak6NoX_4Aeg_-1170213422")]
    [Description(@"True offer price.")]
    Actual = TypeOfPriceCode.Actual, // same ordinal as derivation source for type conversions
}
