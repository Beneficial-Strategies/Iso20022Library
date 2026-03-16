// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party involved by the data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XQMV8I33EeWRwov1g9WL_A")]
[Description(@"Party involved by the data set.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType15Code
{
    /// <summary>
    /// Configuration to apply to a subset of the whole POI system.
    /// Encoded/decoded by serializers as &quot;PGRP&quot;.
    /// </summary>
    [EnumMember(Value = "PGRP")]
    [IsoId("_jtF7gY33EeWRwov1g9WL_A")]
    [Description(@"Configuration to apply to a subset of the whole POI system.")]
    POIGroup = PartyTypeCode.POIGroup, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration to apply to the whole POI system.
    /// Encoded/decoded by serializers as &quot;PSYS&quot;.
    /// </summary>
    [EnumMember(Value = "PSYS")]
    [IsoId("_j2B1EY33EeWRwov1g9WL_A")]
    [Description(@"Configuration to apply to the whole POI system.")]
    POISystem = PartyTypeCode.POISystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Configuration to apply to a single POI terminal.
    /// Encoded/decoded by serializers as &quot;PSNG&quot;.
    /// </summary>
    [EnumMember(Value = "PSNG")]
    [IsoId("_kCQTMY33EeWRwov1g9WL_A")]
    [Description(@"Configuration to apply to a single POI terminal.")]
    SinglePOI = PartyTypeCode.SinglePOI, // same ordinal as derivation source for type conversions
}
