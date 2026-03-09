// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how expenses are paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFE3gBXyEeOBE-jZfcm4KQ")]
[Description(@"Specifies how expenses are paid.")]
[DerivedFrom(typeof(ChargePaymentMethodCode))]
public enum ChargePaymentMethod1Code
{
    /// <summary>
    /// Payment is with cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_T2UeMRXzEeOBE-jZfcm4KQ")]
    [Description(@"Payment is with cash.")]
    Cash = ChargePaymentMethodCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Units are redeemed to cover payment.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_UAJIkRXzEeOBE-jZfcm4KQ")]
    [Description(@"Units are redeemed to cover payment.")]
    Unit = ChargePaymentMethodCode.Unit, // same ordinal as derivation source for type conversions
    
}
