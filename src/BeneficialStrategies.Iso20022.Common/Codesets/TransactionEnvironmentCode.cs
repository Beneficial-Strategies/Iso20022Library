// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the environment of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVWQCwEcEeCQm6a_G2yO_w_1815843099")]
[Description(@"Indicates the environment of the transaction.")]
[Derivations(
    typeof(TransactionEnvironment1Code),
    typeof(TransactionEnvironment3Code),
    typeof(TransactionEnvironment2Code)
)]
public enum TransactionEnvironmentCode
{
    /// <summary>
    /// Merchant environment.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TVWQDAEcEeCQm6a_G2yO_w_-194113759")]
    [Description(@"Merchant environment.")]
    Merchant,

    /// <summary>
    /// Private environment.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_TVWQDQEcEeCQm6a_G2yO_w_1617784466")]
    [Description(@"Private environment.")]
    Private,

    /// <summary>
    /// Public environment.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_TVWQDgEcEeCQm6a_G2yO_w_-226084523")]
    [Description(@"Public environment.")]
    Public,

    /// <summary>
    /// Bank environment.
    /// Encoded/decoded by serializers as &quot;BRCH&quot;.
    /// </summary>
    [EnumMember(Value = "BRCH")]
    [IsoId("_qPp6oHsIEeSR68OJvMfxJQ")]
    [Description(@"Bank environment.")]
    Branch,

    /// <summary>
    /// Other environments, for instance a mall or an airport.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ttxAQHsIEeSR68OJvMfxJQ")]
    [Description(@"Other environments, for instance a mall or an airport.")]
    Other,
}
