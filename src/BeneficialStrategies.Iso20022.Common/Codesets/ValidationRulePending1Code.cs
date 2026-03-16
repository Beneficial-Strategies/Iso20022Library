// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the pending status code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1q93Uh-0EeuxStysDTgLiw")]
[Description(@"Specifies the pending status code for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRulePending1Code
{
    /// <summary>
    /// Pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_JSdbUR-1EeuxStysDTgLiw")]
    [Description(@"Pending.")]
    Pending = ValidationRuleCode.Pending, // same ordinal as derivation source for type conversions
}
