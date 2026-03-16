// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason for which a cancellation is rejected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZbPJZtp-Ed-ak6NoX_4Aeg_1035998628")]
[Description(@"Reason for which a cancellation is rejected.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedCancellationStatusReason1Code
{
    /// <summary>
    /// Request contains an invalid or unrecognised business reference.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_ZbPJZ9p-Ed-ak6NoX_4Aeg_1582722964")]
    [Description(@"Request contains an invalid or unrecognised business reference.")]
    InvalidOrUnrecognisedReference = RejectedStatusReasonCode.InvalidOrUnrecognisedReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The cancellation request has been rejected since more than one instruction match to the cancellation criteria.
    /// Encoded/decoded by serializers as &quot;NRGM&quot;.
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_ZbPJaNp-Ed-ak6NoX_4Aeg_1582722965")]
    [Description(
        @"The cancellation request has been rejected since more than one instruction match to the cancellation criteria."
    )]
    NoCancellationMatch = RejectedStatusReasonCode.NoCancellationMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_ZbYTUNp-Ed-ak6NoX_4Aeg_1582722981")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions
}
