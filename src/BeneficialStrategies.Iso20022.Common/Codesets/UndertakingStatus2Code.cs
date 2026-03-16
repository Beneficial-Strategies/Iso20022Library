// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the undertaking amendment status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m-E6sHymEeGWJuGCfvwOsQ")]
[Description(@"Specifies the undertaking amendment status.")]
[DerivedFrom(typeof(UndertakingStatusCode))]
public enum UndertakingStatus2Code
{
    /// <summary>
    /// Accepted.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_9NC3RnymEeGWJuGCfvwOsQ")]
    [Description(@"Accepted.")]
    Accepted = UndertakingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_u-8y1n4EEeG05p8M2uqofg")]
    [Description(@"Rejected.")]
    Rejected = UndertakingStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
