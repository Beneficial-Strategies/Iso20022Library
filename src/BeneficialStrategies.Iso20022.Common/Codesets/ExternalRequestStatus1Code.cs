// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the request status, as published in an external request status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gy_x0LqtEe68nbz8Nl_hLQ")]
[Description(@"Specifies the request status, as published in an external request status code set.")]
[DerivedFrom(typeof(ExternalRequestStatusCode))]
public enum ExternalRequestStatus1Code
{
    /// <summary>
    /// Message has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("")]
    [Description(@"Message has been accepted.")]
    Accepted = ExternalRequestStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been partially accepted.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("")]
    [Description(@"Message has been partially accepted.")]
    PartiallyAccepted = ExternalRequestStatusCode.PartiallyAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is pending further analysis and investigation.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("")]
    [Description(@"Message is pending further analysis and investigation.")]
    Pending = ExternalRequestStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been received.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("")]
    [Description(@"Message has been received.")]
    Received = ExternalRequestStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("")]
    [Description(@"Message has been rejected.")]
    Rejected = ExternalRequestStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
