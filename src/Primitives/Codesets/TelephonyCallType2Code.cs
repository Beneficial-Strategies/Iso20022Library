// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the call type
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OBz6IVXaEfC0lMwgjvMClw")]
[Description(@"Indicates the call type")]
[DerivedFrom(typeof(TelephonyCallTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TelephonyCallType2Code>))]
public enum TelephonyCallType2Code
{
    /// <summary>
    /// Incoming phone call
    /// Encoded/decoded by serializers as &quot;ICPC&quot;.
    /// </summary>
    [EnumMember(Value = "ICPC")]
    [IsoId("_OEKqn1XaEfC0lMwgjvMClw")]
    [Description(@"Incoming phone call")]
    IncomingCall = TelephonyCallTypeCode.IncomingCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Outgoing phone call
    /// Encoded/decoded by serializers as &quot;OGPC&quot;.
    /// </summary>
    [EnumMember(Value = "OGPC")]
    [IsoId("_OEKql1XaEfC0lMwgjvMClw")]
    [Description(@"Outgoing phone call")]
    OutgoingCall = TelephonyCallTypeCode.OutgoingCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of call not elsewhere classified.
    /// Encoded/decoded by serializers as &quot;OTCL&quot;.
    /// </summary>
    [EnumMember(Value = "OTCL")]
    [IsoId("_OEKqnVXaEfC0lMwgjvMClw")]
    [Description(@"Other type of call not elsewhere classified.")]
    Other = TelephonyCallTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Page
    /// Encoded/decoded by serializers as &quot;PAGE&quot;.
    /// </summary>
    [EnumMember(Value = "PAGE")]
    [IsoId("_OEKqlVXaEfC0lMwgjvMClw")]
    [Description(@"Page")]
    Page = TelephonyCallTypeCode.Page, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Toll free phone call
    /// Encoded/decoded by serializers as &quot;TFPC&quot;.
    /// </summary>
    [EnumMember(Value = "TFPC")]
    [IsoId("_OEKqk1XaEfC0lMwgjvMClw")]
    [Description(@"Toll free phone call")]
    TollFreeCall = TelephonyCallTypeCode.TollFreeCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Voice mail
    /// Encoded/decoded by serializers as &quot;VCML&quot;.
    /// </summary>
    [EnumMember(Value = "VCML")]
    [IsoId("_OEKqkVXaEfC0lMwgjvMClw")]
    [Description(@"Voice mail")]
    VoiceMail = TelephonyCallTypeCode.VoiceMail, // same ordinal as derivation source for type conversions
}
