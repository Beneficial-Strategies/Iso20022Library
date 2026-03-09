// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a message rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aL9bsNp-Ed-ak6NoX_4Aeg_1406401816")]
[Description(@"Specifies the reason for a message rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum MessageRejectedReason1Code
{
    /// <summary>
    /// Request contains an invalid or unrecognised business reference.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_aL9bsdp-Ed-ak6NoX_4Aeg_1732404066")]
    [Description(@"Request contains an invalid or unrecognised business reference.")]
    InvalidOrUnrecognisedReference = RejectedStatusReasonCode.InvalidOrUnrecognisedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructing party is not allowed to ask for a status for that specific order.
    /// Encoded/decoded by serializers as &quot;NALO&quot;.
    /// </summary>
    [EnumMember(Value = "NALO")]
    [IsoId("_aL9bstp-Ed-ak6NoX_4Aeg_1732404091")]
    [Description(@"Instructing party is not allowed to ask for a status for that specific order.")]
    NotAllowedRequest = RejectedStatusReasonCode.NotAllowedRequest, // same ordinal as derivation source for type conversions
    
}
