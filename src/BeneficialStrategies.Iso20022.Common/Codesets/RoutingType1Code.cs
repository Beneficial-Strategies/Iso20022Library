// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of routing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-Uj59p-Ed-ak6NoX_4Aeg_1478221166")]
[Description(@"Indicates the type of routing.")]
[DerivedFrom(typeof(RoutingTypeCode))]
public enum RoutingType1Code
{
    /// <summary>
    /// Indicates that routing is allowed.
    /// Encoded/decoded by serializers as &quot;ALLO&quot;.
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_Y-Uj6Np-Ed-ak6NoX_4Aeg_1903962381")]
    [Description(@"Indicates that routing is allowed.")]
    Allowed = RoutingTypeCode.Allowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that routing is blocked.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_Y-Uj6dp-Ed-ak6NoX_4Aeg_1903962382")]
    [Description(@"Indicates that routing is blocked.")]
    Blocked = RoutingTypeCode.Blocked, // same ordinal as derivation source for type conversions
}
