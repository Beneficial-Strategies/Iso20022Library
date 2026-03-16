// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates which type of interest is applied to a balance left on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdviVg93EeGeV5vP7Mvdig_45097203")]
[Description(@"Indicates which type of interest is applied to a balance left on an account.")]
[DerivedFrom(typeof(InterestCode))]
public enum InterestType1Code
{
    /// <summary>
    /// During or within a business day.
    /// Encoded/decoded by serializers as &quot;INDY&quot;.
    /// </summary>
    [EnumMember(Value = "INDY")]
    [IsoId("_zd5TUA93EeGeV5vP7Mvdig_809162901")]
    [Description(@"During or within a business day.")]
    IntraDay = InterestCode.IntraDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period of time between the end of a business day and the start of the next business day (usually the day after).
    /// Encoded/decoded by serializers as &quot;OVRN&quot;.
    /// </summary>
    [EnumMember(Value = "OVRN")]
    [IsoId("_zd5TUQ93EeGeV5vP7Mvdig_-747638714")]
    [Description(
        @"Period of time between the end of a business day and the start of the next business day (usually the day after)."
    )]
    OverNight = InterestCode.OverNight, // same ordinal as derivation source for type conversions
}
