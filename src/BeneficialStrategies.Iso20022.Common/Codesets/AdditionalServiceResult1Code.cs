// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the result of the service performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Pw460J1KEeublrfU-wN95w")]
[Description(@"Identifies the result of the service performed.")]
[DerivedFrom(typeof(AdditionalServiceResultCode))]
public enum AdditionalServiceResult1Code
{
    /// <summary>
    /// The service was not performed.
    /// Encoded/decoded by serializers as &quot;NOPF&quot;.
    /// </summary>
    [EnumMember(Value = "NOPF")]
    [IsoId("_Xz7kMZ1KEeublrfU-wN95w")]
    [Description(@"The service was not performed.")]
    NotPerformed = AdditionalServiceResultCode.NotPerformed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The service is not supported and could not be performed.
    /// Encoded/decoded by serializers as &quot;NOSP&quot;.
    /// </summary>
    [EnumMember(Value = "NOSP")]
    [IsoId("_YQaE0Z1KEeublrfU-wN95w")]
    [Description(@"The service is not supported and could not be performed.")]
    NotSupported = AdditionalServiceResultCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other nationally defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_YREzMZ1KEeublrfU-wN95w")]
    [Description(@"Other nationally defined code.")]
    OtherNational = AdditionalServiceResultCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other privately defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_YRwIoZ1KEeublrfU-wN95w")]
    [Description(@"Other privately defined code.")]
    OtherPrivate = AdditionalServiceResultCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The service was performed.
    /// Encoded/decoded by serializers as &quot;PERF&quot;.
    /// </summary>
    [EnumMember(Value = "PERF")]
    [IsoId("_YX6bAZ1KEeublrfU-wN95w")]
    [Description(@"The service was performed.")]
    Performed = AdditionalServiceResultCode.Performed, // same ordinal as derivation source for type conversions
}
