// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of proxy person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X2Qi8BrfEeyhRdHRjakS2w")]
[Description(@"Specifies the type of proxy person.")]
[DerivedFrom(typeof(ProxyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProxyType3Code>))]
#endif
public enum ProxyType3Code
{
    /// <summary>
    /// Chairman of the meeting is the proxy.
    /// Encoded/decoded by serializers as &quot;CHRM&quot;.
    /// </summary>
    [EnumMember(Value = "CHRM")]
    [IsoId("_cpOisRrfEeyhRdHRjakS2w")]
    [Description(@"Chairman of the meeting is the proxy.")]
    Chairman = ProxyTypeCode.Chairman, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any type of proxy is allowed.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ctjCARrfEeyhRdHRjakS2w")]
    [Description(@"Any type of proxy is allowed.")]
    Discretionary = ProxyTypeCode.Discretionary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Neutral proxy nominated by the issuer to execute votes on behalf of investors at the meeting.
    /// Encoded/decoded by serializers as &quot;NEPR&quot;.
    /// </summary>
    [EnumMember(Value = "NEPR")]
    [IsoId("_cyUNQRrfEeyhRdHRjakS2w")]
    [Description(
        @"Neutral proxy nominated by the issuer to execute votes on behalf of investors at the meeting."
    )]
    NeutralProxy = ProxyTypeCode.NeutralProxy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proxy can only be a security holder.
    /// Encoded/decoded by serializers as &quot;HLDR&quot;.
    /// </summary>
    [EnumMember(Value = "HLDR")]
    [IsoId("_c2ydkRrfEeyhRdHRjakS2w")]
    [Description(@"Proxy can only be a security holder.")]
    SecurityHolder = ProxyTypeCode.SecurityHolder, // same ordinal as derivation source for type conversions
}
