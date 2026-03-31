// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the classification of the conduct.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ecbaIBdvEeKYM7Bc71nDlA")]
[Description(@"Specifies the classification of the conduct.")]
[Derivations(typeof(ConductClassification1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConductClassificationCode>))]
#endif
public enum ConductClassificationCode
{
    /// <summary>
    /// Standard.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_kd8QoBdvEeKYM7Bc71nDlA")]
    [Description(@"Standard.")]
    Standard,

    /// <summary>
    /// Non standard or unusual.
    /// Encoded/decoded by serializers as &quot;NSTA&quot;.
    /// </summary>
    [EnumMember(Value = "NSTA")]
    [IsoId("_kmuZMBdvEeKYM7Bc71nDlA")]
    [Description(@"Non standard or unusual.")]
    NonStandard,

    /// <summary>
    /// Reluctant.
    /// Encoded/decoded by serializers as &quot;RCLT&quot;.
    /// </summary>
    [EnumMember(Value = "RCLT")]
    [IsoId("_kvhI0BdvEeKYM7Bc71nDlA")]
    [Description(@"Reluctant.")]
    Reluctant,
}
