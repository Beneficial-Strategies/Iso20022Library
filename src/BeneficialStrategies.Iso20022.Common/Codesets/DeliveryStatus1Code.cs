// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides an explicit indication whether the delivery attempt resulted in success or failure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8aALYA2pEeWH49U6bkyMaA")]
[Description(@"Provides an explicit indication whether the delivery attempt resulted in success or failure.")]
[DerivedFrom(typeof(DeliveryStatusCode))]
public enum DeliveryStatus1Code
{
    /// <summary>
    /// Delivery failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("__4RCAQ2pEeWH49U6bkyMaA")]
    [Description(@"Delivery failed.")]
    Failure = DeliveryStatusCode.Failure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery succeeded.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("___tGww2pEeWH49U6bkyMaA")]
    [Description(@"Delivery succeeded.")]
    Success = DeliveryStatusCode.Success, // same ordinal as derivation source for type conversions
    
}
