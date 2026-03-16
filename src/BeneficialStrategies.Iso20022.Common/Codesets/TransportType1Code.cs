// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the transportation type code list
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QBGkQDEwEemzCpWiCwK4aQ")]
[Description(@"Contains the transportation type code list")]
[DerivedFrom(typeof(TransportTypeCode))]
public enum TransportType1Code
{
    /// <summary>
    /// Air
    /// Encoded/decoded by serializers as &quot;AIRR&quot;.
    /// </summary>
    [EnumMember(Value = "AIRR")]
    [IsoId("_VCaiATEwEemzCpWiCwK4aQ")]
    [Description(@"Air")]
    Air = TransportTypeCode.Air, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bus
    /// Encoded/decoded by serializers as &quot;BUSS&quot;.
    /// </summary>
    [EnumMember(Value = "BUSS")]
    [IsoId("_VW-cwTEwEemzCpWiCwK4aQ")]
    [Description(@"Bus")]
    Bus = TransportTypeCode.Bus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_VX30oTEwEemzCpWiCwK4aQ")]
    [Description(@"Other National")]
    OtherNational = TransportTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_VuhaETEwEemzCpWiCwK4aQ")]
    [Description(@"Other Private")]
    OtherPrivate = TransportTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rail
    /// Encoded/decoded by serializers as &quot;RAIL&quot;.
    /// </summary>
    [EnumMember(Value = "RAIL")]
    [IsoId("_Vvki8TEwEemzCpWiCwK4aQ")]
    [Description(@"Rail")]
    Rail = TransportTypeCode.Rail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ship
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_V6JbQTEwEemzCpWiCwK4aQ")]
    [Description(@"Ship")]
    Ship = TransportTypeCode.Ship, // same ordinal as derivation source for type conversions
}
