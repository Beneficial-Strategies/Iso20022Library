// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rejected status code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S3XK8B-zEeuxStysDTgLiw")]
[Description(@"Specifies the rejected status code for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ValidationRuleRejected1Code>))]
#endif
public enum ValidationRuleRejected1Code
{
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_uY6bcR-zEeuxStysDTgLiw")]
    [Description(@"Rejected.")]
    Rejected = ValidationRuleCode.Rejected, // same ordinal as derivation source for type conversions
}
