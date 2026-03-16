// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of key exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tf3TcHvNEeSCJdwgzb6SFw")]
[Description(@"Type of key exchange.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
public enum CardServiceType3Code
{
    /// <summary>
    /// Convey the key to the receiver.
    /// Encoded/decoded by serializers as &quot;KYDL&quot;.
    /// </summary>
    [EnumMember(Value = "KYDL")]
    [IsoId("_a-8UIXvNEeSCJdwgzb6SFw")]
    [Description(@"Convey the key to the receiver.")]
    DeliverKey = CardServiceTypeCode.DeliverKey, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request the keys that the receiver must send in the response.
    /// Encoded/decoded by serializers as &quot;KYCG&quot;.
    /// </summary>
    [EnumMember(Value = "KYCG")]
    [IsoId("_baEJ43vNEeSCJdwgzb6SFw")]
    [Description(@"Request the keys that the receiver must send in the response.")]
    KeyChange = CardServiceTypeCode.KeyChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request the receiver to verify the key check value.
    /// Encoded/decoded by serializers as &quot;KYVF&quot;.
    /// </summary>
    [EnumMember(Value = "KYVF")]
    [IsoId("_ugAgAXvNEeSCJdwgzb6SFw")]
    [Description(@"Request the receiver to verify the key check value.")]
    KeyVerification = CardServiceTypeCode.KeyVerification, // same ordinal as derivation source for type conversions
}
