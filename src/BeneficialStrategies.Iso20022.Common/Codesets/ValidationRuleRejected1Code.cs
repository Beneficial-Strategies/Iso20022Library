// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rejected status code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_S3XK8B-zEeuxStysDTgLiw")]
[Description(@"Specifies the rejected status code for the cross-element validation rules.")]
[DerivedFrom(typeof(ValidationRuleCode))]
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
