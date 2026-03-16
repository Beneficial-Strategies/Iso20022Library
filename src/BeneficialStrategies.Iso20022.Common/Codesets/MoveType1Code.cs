// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes whether peg or discretion price is static/fixed or floats.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aMtCltp-Ed-ak6NoX_4Aeg_-1643565851")]
[Description(@"Describes whether peg or discretion price is static/fixed or floats.")]
[DerivedFrom(typeof(MoveTypeCode))]
public enum MoveType1Code
{
    /// <summary>
    /// Indicates that the peg is static/fixed.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_aMtCl9p-Ed-ak6NoX_4Aeg_-1360046424")]
    [Description(@"Indicates that the peg is static/fixed.")]
    Static = MoveTypeCode.Static, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that peg floats.
    /// Encoded/decoded by serializers as &quot;FLOA&quot;.
    /// </summary>
    [EnumMember(Value = "FLOA")]
    [IsoId("_aM2zkNp-Ed-ak6NoX_4Aeg_-1360046141")]
    [Description(@"Indicates that peg floats.")]
    Float = MoveTypeCode.Float, // same ordinal as derivation source for type conversions
}
