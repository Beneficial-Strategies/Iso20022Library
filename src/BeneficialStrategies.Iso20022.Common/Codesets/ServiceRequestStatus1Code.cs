// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a service request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BrhagPF6EemQ7oqCO5NTQw")]
[Description(@"Specifies the status of a service request.")]
[DerivedFrom(typeof(ServiceRequestStatusCode))]
public enum ServiceRequestStatus1Code
{
    /// <summary>
    /// Service request is accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_PZY4sfF6EemQ7oqCO5NTQw")]
    [Description(@"Service request is accepted.")]
    Accepted = ServiceRequestStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service request has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_PtECofF6EemQ7oqCO5NTQw")]
    [Description(@"Service request has been rejected.")]
    Rejected = ServiceRequestStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
