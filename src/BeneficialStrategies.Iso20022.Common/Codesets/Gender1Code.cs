// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the gender of a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JyNe4IoTEeahcZ3Nzs1Qag")]
[Description(@"Specifies the gender of a person.")]
[DerivedFrom(typeof(GenderCode))]
public enum Gender1Code
{
    /// <summary>
    /// Individual is a female.
    /// Encoded/decoded by serializers as &quot;FEMA&quot;.
    /// </summary>
    [EnumMember(Value = "FEMA")]
    [IsoId("_LwE5wYoTEeahcZ3Nzs1Qag")]
    [Description(@"Individual is a female.")]
    Female = GenderCode.Female, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Individual is a male.
    /// Encoded/decoded by serializers as &quot;MALE&quot;.
    /// </summary>
    [EnumMember(Value = "MALE")]
    [IsoId("_L01d8YoTEeahcZ3Nzs1Qag")]
    [Description(@"Individual is a male.")]
    Male = GenderCode.Male, // same ordinal as derivation source for type conversions
}
