// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the confirmation for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1SaLICBpEeugLNJneiyzbA")]
[Description(
    @"Specifies the confirmation for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleAnyBank1Code>))]
#endif
public enum ValidationRuleAnyBank1Code
{
    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as &quot;ANYB&quot;.
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_GAUS4SBqEeugLNJneiyzbA")]
    [Description(@"Any bank.")]
    AnyBank = ValidationRuleCode.AnyBank, // same ordinal as derivation source for type conversions
}
