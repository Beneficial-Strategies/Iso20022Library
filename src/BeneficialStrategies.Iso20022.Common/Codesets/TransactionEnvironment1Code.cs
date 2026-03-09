// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the environment of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUAMPgEcEeCQm6a_G2yO_w_704662992")]
[Description(@"Indicates the environment of the transaction.")]
[DerivedFrom(typeof(TransactionEnvironmentCode))]
public enum TransactionEnvironment1Code
{
    /// <summary>
    /// Merchant environment.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TUJ9MAEcEeCQm6a_G2yO_w_765796733")]
    [Description(@"Merchant environment.")]
    Merchant = TransactionEnvironmentCode.Merchant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Private environment.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_TUJ9MQEcEeCQm6a_G2yO_w_1751770309")]
    [Description(@"Private environment.")]
    Private = TransactionEnvironmentCode.Private, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Public environment.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_TUJ9MgEcEeCQm6a_G2yO_w_-376057534")]
    [Description(@"Public environment.")]
    Public = TransactionEnvironmentCode.Public, // same ordinal as derivation source for type conversions
    
}
