// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the priority level of an event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKLTBNp-Ed-ak6NoX_4Aeg_-581472374")]
[Description(@"Specifies the priority level of an event.")]
[DerivedFrom(typeof(PriorityCode))]
public enum Priority2Code
{
    /// <summary>
    /// Priority level is high.
    /// Encoded/decoded by serializers as &quot;HIGH&quot;.
    /// </summary>
    [EnumMember(Value = "HIGH")]
    [IsoId("_aKLTBdp-Ed-ak6NoX_4Aeg_-216681953")]
    [Description(@"Priority level is high.")]
    High = PriorityCode.High, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Priority level is normal.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_aKLTBtp-Ed-ak6NoX_4Aeg_-190820973")]
    [Description(@"Priority level is normal.")]
    Normal = PriorityCode.Normal, // same ordinal as derivation source for type conversions
}
