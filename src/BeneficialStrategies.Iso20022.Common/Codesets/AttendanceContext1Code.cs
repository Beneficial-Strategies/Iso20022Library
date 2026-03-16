// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Human attendance at the POI location during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSESgwEcEeCQm6a_G2yO_w_-1954159559")]
[Description(@"Human attendance at the POI location during the transaction.")]
[DerivedFrom(typeof(AttendanceContextCode))]
public enum AttendanceContext1Code
{
    /// <summary>
    /// Attended payment, with an attendant.
    /// Encoded/decoded by serializers as &quot;ATTD&quot;.
    /// </summary>
    [EnumMember(Value = "ATTD")]
    [IsoId("_TSEShAEcEeCQm6a_G2yO_w_940571351")]
    [Description(@"Attended payment, with an attendant.")]
    Attended = AttendanceContextCode.Attended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Semi-attended, including self checkout. An attendant supervises several payment, and could be called to help the cardholder.
    /// Encoded/decoded by serializers as &quot;SATT&quot;.
    /// </summary>
    [EnumMember(Value = "SATT")]
    [IsoId("_TSEShQEcEeCQm6a_G2yO_w_57338064")]
    [Description(
        @"Semi-attended, including self checkout. An attendant supervises several payment, and could be called to help the cardholder."
    )]
    SemiAttended = AttendanceContextCode.SemiAttended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unattended payment, no attendant present.
    /// Encoded/decoded by serializers as &quot;UATT&quot;.
    /// </summary>
    [EnumMember(Value = "UATT")]
    [IsoId("_TSEShgEcEeCQm6a_G2yO_w_1087570186")]
    [Description(@"Unattended payment, no attendant present.")]
    Unattended = AttendanceContextCode.Unattended, // same ordinal as derivation source for type conversions
}
