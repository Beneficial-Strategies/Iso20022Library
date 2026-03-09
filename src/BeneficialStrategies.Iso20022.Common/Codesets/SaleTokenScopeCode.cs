// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Scope of the token that identifies  the payment mean of the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lucbANwsEeioifFt1dhnJA")]
[Description(@"Scope of the token that identifies  the payment mean of the customer.")]
[Derivations(typeof(SaleTokenScope1Code))]
public enum SaleTokenScopeCode
{
    /// <summary>
    /// The token is generated to recognise  a customer during the lifetime of a transaction.
    /// Encoded/decoded by serializers as &quot;SNGL&quot;.
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_px_wANwsEeioifFt1dhnJA")]
    [Description(@"The token is generated to recognise  a customer during the lifetime of a transaction.")]
    SingleUse,
    
    /// <summary>
    /// The token is generated to recognise a customer for a longer period.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_uLv-gNwsEeioifFt1dhnJA")]
    [Description(@"The token is generated to recognise a customer for a longer period.")]
    MultipleUse,
    
}
