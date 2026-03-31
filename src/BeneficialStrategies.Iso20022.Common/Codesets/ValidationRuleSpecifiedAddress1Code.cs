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
[IsoId("_2SRssiBpEeugLNJneiyzbA")]
[Description(
    @"Specifies the confirmation for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleSpecifiedAddress1Code>))]
#endif
public enum ValidationRuleSpecifiedAddress1Code
{
    /// <summary>
    /// Specified address.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_D9RdESBqEeugLNJneiyzbA")]
    [Description(@"Specified address.")]
    SpecifiedAddress = ValidationRuleCode.SpecifiedAddress, // same ordinal as derivation source for type conversions
}
