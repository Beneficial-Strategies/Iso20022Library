// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the gender of a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atyWZ9p-Ed-ak6NoX_4Aeg_275832843")]
[Description(@"Specifies the gender of a person.")]
[Derivations(typeof(Gender1Code))]
public enum GenderCode
{
    /// <summary>
    /// Individual is a male.
    /// Encoded/decoded by serializers as &quot;MALE&quot;.
    /// </summary>
    [EnumMember(Value = "MALE")]
    [IsoId("_atyWaNp-Ed-ak6NoX_4Aeg_319238514")]
    [Description(@"Individual is a male.")]
    Male,

    /// <summary>
    /// Individual is a female.
    /// Encoded/decoded by serializers as &quot;FEMA&quot;.
    /// </summary>
    [EnumMember(Value = "FEMA")]
    [IsoId("_at8HYNp-Ed-ak6NoX_4Aeg_332166896")]
    [Description(@"Individual is a female.")]
    Female,
}
