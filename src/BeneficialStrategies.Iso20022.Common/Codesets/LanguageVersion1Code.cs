// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the langage version.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__gaLYOfqEe-8kLWWTxLKuQ")]
[Description(@"Specifies the langage version.")]
[DerivedFrom(typeof(LanguageVersionCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<LanguageVersion1Code>))]
public enum LanguageVersion1Code
{
    /// <summary>
    /// Original language.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_QJtf8efrEe-8kLWWTxLKuQ")]
    [Description(@"Original language.")]
    OriginalLanguage = LanguageVersionCode.OriginalLanguage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Translated version.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_QRPrUefrEe-8kLWWTxLKuQ")]
    [Description(@"Translated version.")]
    TranslatedVersion = LanguageVersionCode.TranslatedVersion, // same ordinal as derivation source for type conversions
}
