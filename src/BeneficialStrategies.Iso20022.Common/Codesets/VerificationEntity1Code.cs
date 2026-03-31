// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of verification entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Lxl9oBZOEeiXa46FI4OtcQ")]
[Description(@"Type of verification entity.")]
[DerivedFrom(typeof(VerificationEntityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<VerificationEntity1Code>))]
#endif
public enum VerificationEntity1Code
{
    /// <summary>
    /// Acceptor (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_NSJxcRZOEeiXa46FI4OtcQ")]
    [Description(@"Acceptor (for example signature verification by the attendant).")]
    Acceptor = VerificationEntityCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_Ne8QQhZOEeiXa46FI4OtcQ")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer = VerificationEntityCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_NonJohZOEeiXa46FI4OtcQ")]
    [Description(
        @"Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer."
    )]
    Agent = VerificationEntityCode.Agent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_OG95khZOEeiXa46FI4OtcQ")]
    [Description(@"Card issuer.")]
    Issuer = VerificationEntityCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of authentication entity defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_OVPmIhZOEeiXa46FI4OtcQ")]
    [Description(@"Other type of authentication entity defined at national level.")]
    OtherNational = VerificationEntityCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of authentication entity defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_OifX8hZOEeiXa46FI4OtcQ")]
    [Description(@"Other type of authentication entity defined at private level.")]
    OtherPrivate = VerificationEntityCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
