// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Denotes the current state of the Instrument (Used for derivatives).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZJ8lGdp-Ed-ak6NoX_4Aeg_-70866940")]
[Description(@"Denotes the current state of the Instrument (Used for derivatives).")]
[DerivedFrom(typeof(SecurityStatusCode))]
public enum SecurityStatus1Code
{
    /// <summary>
    /// The status is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZKGWENp-Ed-ak6NoX_4Aeg_243065")]
    [Description(@"The status is active.")]
    Active = SecurityStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The status is inactive.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_ZKGWEdp-Ed-ak6NoX_4Aeg_243066")]
    [Description(@"The status is inactive.")]
    Inactive = SecurityStatusCode.Inactive, // same ordinal as derivation source for type conversions
}
