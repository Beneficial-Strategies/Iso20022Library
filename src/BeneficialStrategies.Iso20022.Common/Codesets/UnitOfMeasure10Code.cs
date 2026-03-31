// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of measure expressed in miles and kilometres.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vfbbYF_pEee-csPAW1txwQ")]
[Description(@"Unit of measure expressed in miles and kilometres.")]
[DerivedFrom(typeof(UnitOfMeasureCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnitOfMeasure10Code>))]
#endif
public enum UnitOfMeasure10Code
{
    /// <summary>
    /// Unit of measure that is equal to 1, 000 meters.
    /// Encoded/decoded by serializers as &quot;KMET&quot;.
    /// </summary>
    [EnumMember(Value = "KMET")]
    [IsoId("_l6goQX0mEemfrNOe0zHQyg")]
    [Description(@"Unit of measure that is equal to 1, 000 meters.")]
    Kilometre = UnitOfMeasureCode.Kilometre, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unit of length equal to 1, 760 yards.
    /// Encoded/decoded by serializers as &quot;MILE&quot;.
    /// </summary>
    [EnumMember(Value = "MILE")]
    [IsoId("_l6goQ30mEemfrNOe0zHQyg")]
    [Description(@"Unit of length equal to 1, 760 yards.")]
    Mile = UnitOfMeasureCode.Mile, // same ordinal as derivation source for type conversions
}
