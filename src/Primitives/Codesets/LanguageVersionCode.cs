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
[IsoId("_MKufANpPEe-dLoCRY6a1wQ")]
[Description(@"Specifies the langage version.")]
[Derivations(typeof(LanguageVersion1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<LanguageVersionCode>))]
public enum LanguageVersionCode
{
    /// <summary>
    /// Original language.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_XlstgNpPEe-dLoCRY6a1wQ")]
    [Description(@"Original language.")]
    OriginalLanguage,

    /// <summary>
    /// Translated version.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_bkhTgNpPEe-dLoCRY6a1wQ")]
    [Description(@"Translated version.")]
    TranslatedVersion,
}
