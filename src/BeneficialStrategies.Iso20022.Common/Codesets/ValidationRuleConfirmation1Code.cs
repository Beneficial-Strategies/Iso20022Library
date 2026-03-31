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
[IsoId("_lfBx8CBpEeugLNJneiyzbA")]
[Description(
    @"Specifies the confirmation for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleConfirmation1Code>))]
#endif
public enum ValidationRuleConfirmation1Code
{
    /// <summary>
    /// Confirmation party in trade.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_0NxeUSBpEeugLNJneiyzbA")]
    [Description(@"Confirmation party in trade.")]
    Confirmation = ValidationRuleCode.Confirmation, // same ordinal as derivation source for type conversions
}
