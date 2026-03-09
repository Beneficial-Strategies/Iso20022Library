// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how expenses are paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H8wEoRXyEeOBE-jZfcm4KQ")]
[Description(@"Specifies how expenses are paid.")]
[Derivations(typeof(ChargePaymentMethod1Code))]
public enum ChargePaymentMethodCode
{
    /// <summary>
    /// Payment is with cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_N9CzIBXyEeOBE-jZfcm4KQ")]
    [Description(@"Payment is with cash.")]
    Cash,
    
    /// <summary>
    /// Units are redeemed to cover payment.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_OOJxQBXyEeOBE-jZfcm4KQ")]
    [Description(@"Units are redeemed to cover payment.")]
    Unit,
    
}
