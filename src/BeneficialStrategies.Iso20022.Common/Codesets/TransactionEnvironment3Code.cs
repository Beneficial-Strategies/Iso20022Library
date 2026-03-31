// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the entity hosting the terminal performing the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3dTnsHsIEeSR68OJvMfxJQ")]
[Description(@"Indicates the entity hosting the terminal performing the transaction.")]
[DerivedFrom(typeof(TransactionEnvironmentCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionEnvironment3Code>))]
#endif
public enum TransactionEnvironment3Code
{
    /// <summary>
    /// Bank environment.
    /// Encoded/decoded by serializers as &quot;BRCH&quot;.
    /// </summary>
    [EnumMember(Value = "BRCH")]
    [IsoId("_6F6BoXsIEeSR68OJvMfxJQ")]
    [Description(@"Bank environment.")]
    Branch = TransactionEnvironmentCode.Branch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant environment.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_6Md8oXsIEeSR68OJvMfxJQ")]
    [Description(@"Merchant environment.")]
    Merchant = TransactionEnvironmentCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other environments, for instance a mall or an airport.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_6SkkoXsIEeSR68OJvMfxJQ")]
    [Description(@"Other environments, for instance a mall or an airport.")]
    Other = TransactionEnvironmentCode.Other, // same ordinal as derivation source for type conversions
}
