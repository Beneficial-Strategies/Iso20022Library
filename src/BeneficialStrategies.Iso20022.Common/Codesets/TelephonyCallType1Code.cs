// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the call type
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YOAJsDEvEemzCpWiCwK4aQ")]
[Description(@"Indicates the call type")]
[DerivedFrom(typeof(TelephonyCallTypeCode))]
public enum TelephonyCallType1Code
{
    /// <summary>
    /// Voice mail
    /// Encoded/decoded by serializers as &quot;VCML&quot;.
    /// </summary>
    [EnumMember(Value = "VCML")]
    [IsoId("_caQHsTEvEemzCpWiCwK4aQ")]
    [Description(@"Voice mail")]
    VoiceMail = TelephonyCallTypeCode.VoiceMail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Toll free phone call
    /// Encoded/decoded by serializers as &quot;TFPC&quot;.
    /// </summary>
    [EnumMember(Value = "TFPC")]
    [IsoId("_cuX9kTEvEemzCpWiCwK4aQ")]
    [Description(@"Toll free phone call")]
    TollFreeCall = TelephonyCallTypeCode.TollFreeCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Page
    /// Encoded/decoded by serializers as &quot;PAGE&quot;.
    /// </summary>
    [EnumMember(Value = "PAGE")]
    [IsoId("_c1-aYTEvEemzCpWiCwK4aQ")]
    [Description(@"Page")]
    Page = TelephonyCallTypeCode.Page, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Outgoing phone call
    /// Encoded/decoded by serializers as &quot;OGPC&quot;.
    /// </summary>
    [EnumMember(Value = "OGPC")]
    [IsoId("_dFeO8TEvEemzCpWiCwK4aQ")]
    [Description(@"Outgoing phone call")]
    OutgoingCall = TelephonyCallTypeCode.OutgoingCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dGXm0TEvEemzCpWiCwK4aQ")]
    [Description(@"Other private")]
    OtherPrivate = TelephonyCallTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other national
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_degaATEvEemzCpWiCwK4aQ")]
    [Description(@"Other national")]
    OtherNational = TelephonyCallTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of call not elsewhere classified.
    /// Encoded/decoded by serializers as &quot;OTCL&quot;.
    /// </summary>
    [EnumMember(Value = "OTCL")]
    [IsoId("_dhMhoTEvEemzCpWiCwK4aQ")]
    [Description(@"Other type of call not elsewhere classified. ")]
    Other = TelephonyCallTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incoming phone call
    /// Encoded/decoded by serializers as &quot;ICPC&quot;.
    /// </summary>
    [EnumMember(Value = "ICPC")]
    [IsoId("_d28vMTEvEemzCpWiCwK4aQ")]
    [Description(@"Incoming phone call")]
    IncomingCall = TelephonyCallTypeCode.IncomingCall, // same ordinal as derivation source for type conversions
}
