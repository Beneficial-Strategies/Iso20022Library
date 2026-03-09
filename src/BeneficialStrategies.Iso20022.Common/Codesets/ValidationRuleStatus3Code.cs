// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status for the cross-element validation rules.
/// Usage: the code set is used when the formal validation rules make reference of an external code sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RcJ6JyAUEeuxStysDTgLiw")]
[Description(@"Specifies the status for the cross-element validation rules.||Usage: the code set is used when the formal validation rules make reference of an external code sets.")]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleStatus3Code
{
    /// <summary>
    /// Received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_itZM4SAeEeuSiN6KdHu9iw")]
    [Description(@"Received.")]
    Received = ValidationRuleCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_K2H4QSE7EeuIZ4Hf6difAw")]
    [Description(@"Rejected.")]
    Rejected = ValidationRuleCode.Rejected, // same ordinal as derivation source for type conversions
    
}
