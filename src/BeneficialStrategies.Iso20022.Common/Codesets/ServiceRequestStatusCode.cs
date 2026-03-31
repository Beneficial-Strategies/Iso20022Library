// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a service request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eXhhcvF5EemQ7oqCO5NTQw")]
[Description(@"Specifies the status of a service request.")]
[Derivations(typeof(ServiceRequestStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ServiceRequestStatusCode>))]
#endif
public enum ServiceRequestStatusCode
{
    /// <summary>
    /// Authentication, syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_eXhhefF5EemQ7oqCO5NTQw")]
    [Description(@"Authentication, syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation,

    /// <summary>
    /// Service request has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_eXhhgfF5EemQ7oqCO5NTQw")]
    [Description(@"Service request has been rejected.")]
    Rejected,

    /// <summary>
    /// Service request is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_eXhhc_F5EemQ7oqCO5NTQw")]
    [Description(@"Service request is pending.")]
    Pending,

    /// <summary>
    /// Service request is accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_eXhhgPF5EemQ7oqCO5NTQw")]
    [Description(@"Service request is accepted.")]
    Accepted,
}
