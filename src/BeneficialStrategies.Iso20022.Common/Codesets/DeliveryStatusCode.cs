// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides an explicit indication whether the delivery attempt resulted in success or failure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MKgsMQ2pEeWH49U6bkyMaA")]
[Description(@"Provides an explicit indication whether the delivery attempt resulted in success or failure.")]
[Derivations(typeof(DeliveryStatus1Code))]
public enum DeliveryStatusCode
{
    /// <summary>
    /// Delivery failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_RtLqkA2pEeWH49U6bkyMaA")]
    [Description(@"Delivery failed.")]
    Failure,
    
    /// <summary>
    /// Delivery succeeded.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_ulsG8A2pEeWH49U6bkyMaA")]
    [Description(@"Delivery succeeded.")]
    Success,
    
}
