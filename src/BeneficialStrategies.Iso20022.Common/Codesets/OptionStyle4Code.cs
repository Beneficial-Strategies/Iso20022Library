// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__viXkNojEeC60axPepSq7g_1741520571")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(OptionStyleCode))]
public enum OptionStyle4Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as &quot;AMER&quot;.
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("__viXkdojEeC60axPepSq7g_227459046")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American = OptionStyleCode.American, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("__viXktojEeC60axPepSq7g_552576553")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European = OptionStyleCode.European, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as &quot;BERM&quot;.
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("__viXk9ojEeC60axPepSq7g_438737487")]
    [Description(
        @"Option that can be exercised on multiple discrete dates prior to, or on expiry date."
    )]
    Bermudan = OptionStyleCode.Bermudan, // same ordinal as derivation source for type conversions
}
