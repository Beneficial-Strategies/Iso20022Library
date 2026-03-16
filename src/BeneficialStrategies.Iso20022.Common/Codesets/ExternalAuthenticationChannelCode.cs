// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction authentication channel, as published in an external authentication channel code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gTbMYI8qEeeBmcwCTnMfBg")]
[Description(
    @"Specifies the transaction authentication channel, as published in an external authentication channel code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalAuthenticationChannel1Code))]
public enum ExternalAuthenticationChannelCode
{
    /// <summary>
    /// Authentication provided through ATM
    /// Encoded/decoded by serializers as &quot;ATMA&quot;.
    /// </summary>
    [EnumMember(Value = "ATMA")]
    [IsoId("_uZHtoPRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through ATM")]
    ATM,

    /// <summary>
    /// Authentication provided through Card
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_uZHto_RYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Card")]
    Card,

    /// <summary>
    /// Authentication provided through Internet Banking
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_uZHtpvRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Internet Banking")]
    InternetBanking,

    /// <summary>
    /// Authentication provided through Mobile
    /// Encoded/decoded by serializers as &quot;MOBI&quot;.
    /// </summary>
    [EnumMember(Value = "MOBI")]
    [IsoId("_uZReoPRYEeuLhpyIdtJzwg")]
    [Description(@"Authentication provided through Mobile")]
    Mobile,
}
