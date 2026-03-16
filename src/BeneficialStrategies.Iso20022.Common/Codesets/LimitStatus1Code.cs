// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of a limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdviUQ93EeGeV5vP7Mvdig_1432715289")]
[Description(@"Specifies the current status of a limit.")]
[DerivedFrom(typeof(LimitStatusCode))]
public enum LimitStatus1Code
{
    /// <summary>
    /// Limit is currently in effect.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_zdviUg93EeGeV5vP7Mvdig_372741033")]
    [Description(@"Limit is currently in effect.")]
    Enabled = LimitStatusCode.Enabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limit is not currently in effect.
    /// Encoded/decoded by serializers as &quot;DISA&quot;.
    /// </summary>
    [EnumMember(Value = "DISA")]
    [IsoId("_zdviUw93EeGeV5vP7Mvdig_815729525")]
    [Description(@"Limit is not currently in effect.")]
    Disabled = LimitStatusCode.Disabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limit has been deleted or suspended.
    /// Encoded/decoded by serializers as &quot;DELD&quot;.
    /// </summary>
    [EnumMember(Value = "DELD")]
    [IsoId("_zdviVA93EeGeV5vP7Mvdig_1401676551")]
    [Description(@"Limit has been deleted or suspended.")]
    Deleted = LimitStatusCode.Deleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limit has been asked for and is not yet enabled.
    /// Encoded/decoded by serializers as &quot;REQD&quot;.
    /// </summary>
    [EnumMember(Value = "REQD")]
    [IsoId("_zdviVQ93EeGeV5vP7Mvdig_348111115")]
    [Description(@"Limit has been asked for and is not yet enabled.")]
    Requested = LimitStatusCode.Requested, // same ordinal as derivation source for type conversions
}
