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
[IsoId("_nP6msBjoEeKxeog5DTmtgg")]
[Description(@"Specifies the classification of the conduct.")]
[DerivedFrom(typeof(ConductClassificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConductClassification1Code>))]
#endif
public enum ConductClassification1Code
{
    /// <summary>
    /// Non standard or unusual.
    /// Encoded/decoded by serializers as &quot;NSTA&quot;.
    /// </summary>
    [EnumMember(Value = "NSTA")]
    [IsoId("_rUP-0RjoEeKxeog5DTmtgg")]
    [Description(@"Non standard or unusual.")]
    NonStandard = ConductClassificationCode.NonStandard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reluctant.
    /// Encoded/decoded by serializers as &quot;RCLT&quot;.
    /// </summary>
    [EnumMember(Value = "RCLT")]
    [IsoId("_rfkeARjoEeKxeog5DTmtgg")]
    [Description(@"Reluctant.")]
    Reluctant = ConductClassificationCode.Reluctant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard.
    /// Encoded/decoded by serializers as &quot;STAN&quot;.
    /// </summary>
    [EnumMember(Value = "STAN")]
    [IsoId("_roqIkRjoEeKxeog5DTmtgg")]
    [Description(@"Standard.")]
    Standard = ConductClassificationCode.Standard, // same ordinal as derivation source for type conversions
}
