// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction authentication channel, as published in an external authentication channel code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5C8hAZdfEea1K6JAcAwoVg")]
[Description(
    @"Specifies the transaction authentication channel, as published in an external authentication channel code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalAuthenticationChannelCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAuthenticationChannel1Code>))]
#endif
public enum ExternalAuthenticationChannel1Code
{
    /// <summary>
    /// Authentication provided through ATM
    /// Encoded/decoded by serializers as &quot;ATMA&quot;.
    /// </summary>
    [EnumMember(Value = "ATMA")]
    [IsoId("_uZHtovRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through ATM")]
    ATM = ExternalAuthenticationChannelCode.ATM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication provided through Card
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_uZHtpfRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Card")]
    Card = ExternalAuthenticationChannelCode.Card, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication provided through Internet Banking
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_uZHtqPRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Internet Banking")]
    InternetBanking = ExternalAuthenticationChannelCode.InternetBanking, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication provided through Mobile
    /// Encoded/decoded by serializers as &quot;MOBI&quot;.
    /// </summary>
    [EnumMember(Value = "MOBI")]
    [IsoId("_uZReovRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Mobile")]
    Mobile = ExternalAuthenticationChannelCode.Mobile, // same ordinal as derivation source for type conversions
}
