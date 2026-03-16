// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of place.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHWBc9p-Ed-ak6NoX_4Aeg_-1656476023")]
[Description(@"Type of place.")]
[Derivations(typeof(PlaceType1Code))]
public enum PlaceTypeCode
{
    /// <summary>
    /// The type of place is unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aHWBdNp-Ed-ak6NoX_4Aeg_-1656475988")]
    [Description(@"The type of place is unknown.")]
    Unknown,
}
