// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Conditions for physical admittance to general meetings.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0DaqkK4kEemG7MmivSuE5g")]
[Description(@"Conditions for physical admittance to general meetings.")]
[Derivations(typeof(AttendanceAdmissionConditions1Code),typeof(AttendanceAdmissionConditions2Code))]
public enum AttendanceAdmissionConditionsCode
{
    /// <summary>
    /// Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MALR&quot;.
    /// </summary>
    [EnumMember(Value = "MALR")]
    [IsoId("_AcYLUK4lEemG7MmivSuE5g")]
    [Description(@"Attendees will be placed on a attendee list or issued with a letter of representation, and must bring photographic identification with them.")]
    AllowedWithLetterOfRepresentation,
    
    /// <summary>
    /// Attendees will be placed on a attendee list and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MAAL&quot;.
    /// </summary>
    [EnumMember(Value = "MAAL")]
    [IsoId("_Xk_FoK4lEemG7MmivSuE5g")]
    [Description(@"Attendees will be placed on a attendee list and must bring photographic identification with them.")]
    AllowedWithAttendeeList,
    
    /// <summary>
    /// Attendees will be issued an admission ticket and must bring photographic identification with them.
    /// Encoded/decoded by serializers as &quot;MATK&quot;.
    /// </summary>
    [EnumMember(Value = "MATK")]
    [IsoId("_0bRUcK4lEemG7MmivSuE5g")]
    [Description(@"Attendees will be issued an admission ticket and must bring photographic identification with them.")]
    AllowedWithTicket,
    
    /// <summary>
    /// Attendees must request proof of holding and register for attendance directly with Issuer.
    /// Encoded/decoded by serializers as &quot;MAHI&quot;.
    /// </summary>
    [EnumMember(Value = "MAHI")]
    [IsoId("_CCfYEK4mEemG7MmivSuE5g")]
    [Description(@"Attendees must request proof of holding and register for attendance directly with Issuer.")]
    AllowedWithProof,
    
    /// <summary>
    /// Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding.
    /// Encoded/decoded by serializers as &quot;MAPO&quot;.
    /// </summary>
    [EnumMember(Value = "MAPO")]
    [IsoId("_M6wiIK4mEemG7MmivSuE5g")]
    [Description(@"Attendees acting on behalf of registered holder must have a valid power of attorney (POA) and/or proof of holding.")]
    AllowedOnBehalf,
    
    /// <summary>
    /// Any attendee must be a shareholder themselves.
    /// Encoded/decoded by serializers as &quot;MASH&quot;.
    /// </summary>
    [EnumMember(Value = "MASH")]
    [IsoId("_kuNJMK4mEemG7MmivSuE5g")]
    [Description(@"Any attendee must be a shareholder themselves.")]
    AllowedForShareholder,
    
    /// <summary>
    /// Meeting attendance is not possible.
    /// Encoded/decoded by serializers as &quot;MANP&quot;.
    /// </summary>
    [EnumMember(Value = "MANP")]
    [IsoId("_xdxzIK4mEemG7MmivSuE5g")]
    [Description(@"Meeting attendance is not possible.")]
    NotPossible,
    
    /// <summary>
    /// Attendee must be a shareholder registered in company stock ledger book.
    /// Encoded/decoded by serializers as &quot;MASL&quot;.
    /// </summary>
    [EnumMember(Value = "MASL")]
    [IsoId("_A2Y6cPNhEeqRfth943bvEA")]
    [Description(@"Attendee must be a shareholder registered in company stock ledger book.")]
    AllowedIfRegisteredInStockLedger,
    
    /// <summary>
    /// Attendee must be a delegate of the shareholder registered in the company stock ledger book.
    /// Encoded/decoded by serializers as &quot;MADS&quot;.
    /// </summary>
    [EnumMember(Value = "MADS")]
    [IsoId("_L_KlsPNhEeqRfth943bvEA")]
    [Description(@"Attendee must be a delegate of the shareholder registered in the company stock ledger book.")]
    DelegateAllowedIfRegisteredInStockLedger,
    
}
