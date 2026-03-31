// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yx9i4tp-Ed-ak6NoX_4Aeg_-2021057381")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfPrice16Code>))]
#endif
public enum TypeOfPrice16Code
{
    /// <summary>
    /// Price is the current market price.
    /// Encoded/decoded by serializers as &quot;MRKT&quot;.
    /// </summary>
    [EnumMember(Value = "MRKT")]
    [IsoId("_Yx9i49p-Ed-ak6NoX_4Aeg_-1009264882")]
    [Description(@"Price is the current market price.")]
    Market = TypeOfPriceCode.Market, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the estimated indicative price.
    /// Encoded/decoded by serializers as &quot;INDC&quot;.
    /// </summary>
    [EnumMember(Value = "INDC")]
    [IsoId("_Yx9i5Np-Ed-ak6NoX_4Aeg_-831146210")]
    [Description(@"Price is the estimated indicative price.")]
    Indicative = TypeOfPriceCode.Indicative, // same ordinal as derivation source for type conversions
}
