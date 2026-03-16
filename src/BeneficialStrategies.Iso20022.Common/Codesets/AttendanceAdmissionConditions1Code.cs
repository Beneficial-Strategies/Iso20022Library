// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies conditions for physical admittance to general meetings.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I0hQEK4nEemG7MmivSuE5g")]
[Description(@"Specifies conditions for physical admittance to general meetings.")]
[DerivedFrom(typeof(AttendanceAdmissionConditionsCode))]
public enum AttendanceAdmissionConditions1Code
{
    /// <summary>
    /// Any attendee must be a shareholder themselves.
    /// Encoded/decoded by serializers as &quot;MASH&quot;.
    /// </summary>
    [EnumMember(Value = "MASH")]
    [IsoId("_K2sjMa4nEemG7MmivSuE5g")]
    [Description(@"Any attendee must be a shareholder themselves.")]
    AllowedForShareholder = AttendanceAdmissionConditionsCode.AllowedForShareholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding.
    /// Encoded/decoded by serializers as &quot;MAPO&quot;.
    /// </summary>
    [EnumMember(Value = "MAPO")]
    [IsoId("_K75zUa4nEemG7MmivSuE5g")]
    [Description(
        @"Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding."
    )]
    AllowedOnBehalf = AttendanceAdmissionConditionsCode.AllowedOnBehalf, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees will be placed on a attendee list and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MAAL&quot;.
    /// </summary>
    [EnumMember(Value = "MAAL")]
    [IsoId("_LDN8Qq4nEemG7MmivSuE5g")]
    [Description(
        @"Attendees will be placed on a attendee list and must bring photographic identification with them."
    )]
    AllowedWithAttendeeList = AttendanceAdmissionConditionsCode.AllowedWithAttendeeList, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MALR&quot;.
    /// </summary>
    [EnumMember(Value = "MALR")]
    [IsoId("_LFdX8a4nEemG7MmivSuE5g")]
    [Description(
        @"Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them."
    )]
    AllowedWithLetterOfRepresentation =
        AttendanceAdmissionConditionsCode.AllowedWithLetterOfRepresentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees must request proof of holding and register for attendance directly with Issuer.
    /// Encoded/decoded by serializers as &quot;MAHI&quot;.
    /// </summary>
    [EnumMember(Value = "MAHI")]
    [IsoId("_LIcaga4nEemG7MmivSuE5g")]
    [Description(
        @"Attendees must request proof of holding and register for attendance directly with Issuer."
    )]
    AllowedWithProof = AttendanceAdmissionConditionsCode.AllowedWithProof, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees will be issued an admission ticket and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MATK&quot;.
    /// </summary>
    [EnumMember(Value = "MATK")]
    [IsoId("_LN7-ga4nEemG7MmivSuE5g")]
    [Description(
        @"Attendees will be issued an admission ticket and must bring photographic identification with them."
    )]
    AllowedWithTicket = AttendanceAdmissionConditionsCode.AllowedWithTicket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting attendance is not possible.
    /// Encoded/decoded by serializers as &quot;MANP&quot;.
    /// </summary>
    [EnumMember(Value = "MANP")]
    [IsoId("_LSYZoa4nEemG7MmivSuE5g")]
    [Description(@"Meeting attendance is not possible.")]
    NotPossible = AttendanceAdmissionConditionsCode.NotPossible, // same ordinal as derivation source for type conversions
}
