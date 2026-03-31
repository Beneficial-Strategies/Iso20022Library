// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQIxFtp-Ed-ak6NoX_4Aeg_-1177091144")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionStyle2Code>))]
#endif
public enum OptionStyle2Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_aQIxF9p-Ed-ak6NoX_4Aeg_-1107826186")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_aQIxGNp-Ed-ak6NoX_4Aeg_-1107826168")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions
}
