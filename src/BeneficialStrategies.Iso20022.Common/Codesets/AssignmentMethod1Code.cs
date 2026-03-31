// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method under which assignment was conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bfaAkdp-Ed-ak6NoX_4Aeg_-1934141861")]
[Description(@"Method under which assignment was conducted.")]
[DerivedFrom(typeof(AssignmentMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssignmentMethod1Code>))]
#endif
public enum AssignmentMethod1Code
{
    /// <summary>
    /// Assignment was conducted randomly.
    /// Encoded/decoded by serializers as &quot;RAND&quot;.
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_bfaAktp-Ed-ak6NoX_4Aeg_-1560115838")]
    [Description(@"Assignment was conducted randomly.")]
    Random = AssignmentMethodCode.Random, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assignment was conducted on a prorata basis.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_bfaAk9p-Ed-ak6NoX_4Aeg_-1560115837")]
    [Description(@"Assignment was conducted on a prorata basis.")]
    Prorata = AssignmentMethodCode.Prorata, // same ordinal as derivation source for type conversions
}
