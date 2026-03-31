// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the terms used to formally address a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aM_9hNp-Ed-ak6NoX_4Aeg_1660850708")]
[Description(@"Specifies the terms used to formally address a person.")]
[DerivedFrom(typeof(NamePrefixCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NamePrefix1Code>))]
#endif
public enum NamePrefix1Code
{
    /// <summary>
    /// Title of the person is Doctor or Dr.
    /// Encoded/decoded by serializers as &quot;DOCT&quot;.
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_jXsywYc0EeeO5vQpPey46w")]
    [Description(@"Title of the person is Doctor or Dr.")]
    Doctor = NamePrefixCode.Doctor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Title of the person is Mister or Mr.
    /// Encoded/decoded by serializers as &quot;MIST&quot;.
    /// </summary>
    [EnumMember(Value = "MIST")]
    [IsoId("_jp59EYc0EeeO5vQpPey46w")]
    [Description(@"Title of the person is Mister or Mr.")]
    Mister = NamePrefixCode.Mister, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Title of the person is Miss.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_jkbAIYc0EeeO5vQpPey46w")]
    [Description(@"Title of the person is Miss.")]
    Miss = NamePrefixCode.Miss, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Title of the person is Madam.
    /// Encoded/decoded by serializers as &quot;MADM&quot;.
    /// </summary>
    [EnumMember(Value = "MADM")]
    [IsoId("_jehMcYc0EeeO5vQpPey46w")]
    [Description(@"Title of the person is Madam.")]
    Madam = NamePrefixCode.Madam, // same ordinal as derivation source for type conversions
}
