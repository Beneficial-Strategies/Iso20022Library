// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the performed service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KoHXQZxKEe-Jl6tBAvMHqA")]
[Description(@"Result of the performed service.")]
[DerivedFrom(typeof(ResponseCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<Response12Code>))]
public enum Response12Code
{
    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_KpCkUZxKEe-Jl6tBAvMHqA")]
    [Description(@"Service has been successfuly provided.")]
    Approved = ResponseCode.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To provide this service additional information needs to be provided by the customer.
    /// Encoded/decoded by serializers as &quot;ASUP&quot;.
    /// </summary>
    [EnumMember(Value = "ASUP")]
    [IsoId("_5Syp0aDhEe-MRKYsaX6JDg")]
    [Description(@"To provide this service additional information needs to be provided by the customer.")]
    ApprovalSuspended = ResponseCode.ApprovalSuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_KpCkU5xKEe-Jl6tBAvMHqA")]
    [Description(@"Service is declined.")]
    Declined = ResponseCode.Declined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_KpCkVZxKEe-Jl6tBAvMHqA")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved = ResponseCode.PartialApproved, // same ordinal as derivation source for type conversions
}
