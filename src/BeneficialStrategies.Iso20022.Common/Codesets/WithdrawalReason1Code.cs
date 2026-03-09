// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason that an alleged trade is withdrawn.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_x_1NIJElEeKcLcxonNWTXg")]
[Description(@"Specifies the reason that an alleged trade is withdrawn.")]
[DerivedFrom(typeof(WithdrawalReasonCode))]
public enum WithdrawalReason1Code
{
    /// <summary>
    /// Alleged trade is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_3S_I0ZElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is rejected.")]
    Rejected = WithdrawalReasonCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Alleged trade is rescinded.
    /// Encoded/decoded by serializers as &quot;RSCD&quot;.
    /// </summary>
    [EnumMember(Value = "RSCD")]
    [IsoId("_3dH8QZElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is rescinded.")]
    Rescinded = WithdrawalReasonCode.Rescinded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Alleged trade is withdrawn due to an amendment.
    /// Encoded/decoded by serializers as &quot;WTDN&quot;.
    /// </summary>
    [EnumMember(Value = "WTDN")]
    [IsoId("_3nQIoZElEeKcLcxonNWTXg")]
    [Description(@"Alleged trade is withdrawn due to an amendment.")]
    Withdrawn = WithdrawalReasonCode.Withdrawn, // same ordinal as derivation source for type conversions
    
}
