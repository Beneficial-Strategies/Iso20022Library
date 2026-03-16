// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the environment of the transaction location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cb7FAHsIEeSR68OJvMfxJQ")]
[Description(@"Indicates the environment of the transaction location.")]
[DerivedFrom(typeof(TransactionEnvironmentCode))]
public enum TransactionEnvironment2Code
{
    /// <summary>
    /// Private environment.
    /// Encoded/decoded by serializers as &quot;PRIV&quot;.
    /// </summary>
    [EnumMember(Value = "PRIV")]
    [IsoId("_d7rAgXsIEeSR68OJvMfxJQ")]
    [Description(@"Private environment.")]
    Private = TransactionEnvironmentCode.Private, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Public environment.
    /// Encoded/decoded by serializers as &quot;PUBL&quot;.
    /// </summary>
    [EnumMember(Value = "PUBL")]
    [IsoId("_eDeRoXsIEeSR68OJvMfxJQ")]
    [Description(@"Public environment.")]
    Public = TransactionEnvironmentCode.Public, // same ordinal as derivation source for type conversions
}
