// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions for physical admittance to a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vuhm8PNhEeqRfth943bvEA")]
[Description(@"Specifies the conditions for physical admittance to a general meeting.")]
[DerivedFrom(typeof(AttendanceAdmissionConditionsCode))]
public enum AttendanceAdmissionConditions2Code
{
    /// <summary>
    /// Any attendee must be a shareholder themselves.
    /// Encoded/decoded by serializers as &quot;MASH&quot;.
    /// </summary>
    [EnumMember(Value = "MASH")]
    [IsoId("_X7kGQfNhEeqRfth943bvEA")]
    [Description(@"Any attendee must be a shareholder themselves.")]
    AllowedForShareholder = AttendanceAdmissionConditionsCode.AllowedForShareholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendee must be a shareholder registered in company stock ledger book.
    /// Encoded/decoded by serializers as &quot;MASL&quot;.
    /// </summary>
    [EnumMember(Value = "MASL")]
    [IsoId("_YBXMQfNhEeqRfth943bvEA")]
    [Description(@"Attendee must be a shareholder registered in company stock ledger book.")]
    AllowedIfRegisteredInStockLedger =
        AttendanceAdmissionConditionsCode.AllowedIfRegisteredInStockLedger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding.
    /// Encoded/decoded by serializers as &quot;MAPO&quot;.
    /// </summary>
    [EnumMember(Value = "MAPO")]
    [IsoId("_YGuNYfNhEeqRfth943bvEA")]
    [Description(
        @"Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding."
    )]
    AllowedOnBehalf = AttendanceAdmissionConditionsCode.AllowedOnBehalf, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees will be placed on a attendee list and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MAAL&quot;.
    /// </summary>
    [EnumMember(Value = "MAAL")]
    [IsoId("_YLn7gfNhEeqRfth943bvEA")]
    [Description(
        @"Attendees will be placed on a attendee list and must bring photographic identification with them."
    )]
    AllowedWithAttendeeList = AttendanceAdmissionConditionsCode.AllowedWithAttendeeList, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MALR&quot;.
    /// </summary>
    [EnumMember(Value = "MALR")]
    [IsoId("_YRbokfNhEeqRfth943bvEA")]
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
    [IsoId("_YWV9wfNhEeqRfth943bvEA")]
    [Description(
        @"Attendees must request proof of holding and register for attendance directly with Issuer."
    )]
    AllowedWithProof = AttendanceAdmissionConditionsCode.AllowedWithProof, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendees will be issued an admission ticket and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MATK&quot;.
    /// </summary>
    [EnumMember(Value = "MATK")]
    [IsoId("_YaNKEfNhEeqRfth943bvEA")]
    [Description(
        @"Attendees will be issued an admission ticket and must bring photographic identification with them."
    )]
    AllowedWithTicket = AttendanceAdmissionConditionsCode.AllowedWithTicket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attendee must be a delegate of the shareholder registered in the company stock ledger book.
    /// Encoded/decoded by serializers as &quot;MADS&quot;.
    /// </summary>
    [EnumMember(Value = "MADS")]
    [IsoId("_YeOHYfNhEeqRfth943bvEA")]
    [Description(
        @"Attendee must be a delegate of the shareholder registered in the company stock ledger book."
    )]
    DelegateAllowedIfRegisteredInStockLedger =
        AttendanceAdmissionConditionsCode.DelegateAllowedIfRegisteredInStockLedger, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting attendance is not possible.
    /// Encoded/decoded by serializers as &quot;MANP&quot;.
    /// </summary>
    [EnumMember(Value = "MANP")]
    [IsoId("_YhpO0fNhEeqRfth943bvEA")]
    [Description(@"Meeting attendance is not possible.")]
    NotPossible = AttendanceAdmissionConditionsCode.NotPossible, // same ordinal as derivation source for type conversions
}
