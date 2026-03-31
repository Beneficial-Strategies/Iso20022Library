// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3o5AU06KEeuOHsgMPq_2jQ")]
[Description(
    @"Specifies the status for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRulePendingAndRejected1Code>))]
#endif
public enum ValidationRulePendingAndRejected1Code
{
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_3o5AVU6KEeuOHsgMPq_2jQ")]
    [Description(@"Rejected.")]
    Rejected = ValidationRuleCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_BRWvYU6LEeuOHsgMPq_2jQ")]
    [Description(@"Pending.")]
    Pending = ValidationRuleCode.Pending, // same ordinal as derivation source for type conversions
}
