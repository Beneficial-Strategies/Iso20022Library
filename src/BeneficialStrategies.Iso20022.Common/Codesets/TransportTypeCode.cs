// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the transportation type code list
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sf5qh_QDEeihCvvpsmGI2w")]
[Description(@"Contains the transportation type code list")]
[Derivations(typeof(TransportType1Code))]
public enum TransportTypeCode
{
    /// <summary>
    /// Rail
    /// Encoded/decoded by serializers as &quot;RAIL&quot;.
    /// </summary>
    [EnumMember(Value = "RAIL")]
    [IsoId("_sf5qiPQDEeihCvvpsmGI2w")]
    [Description(@"Rail")]
    Rail,
    
    /// <summary>
    /// Ship
    /// Encoded/decoded by serializers as &quot;SHIP&quot;.
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_sf5qi_QDEeihCvvpsmGI2w")]
    [Description(@"Ship")]
    Ship,
    
    /// <summary>
    /// Air
    /// Encoded/decoded by serializers as &quot;AIRR&quot;.
    /// </summary>
    [EnumMember(Value = "AIRR")]
    [IsoId("_sf5qjfQDEeihCvvpsmGI2w")]
    [Description(@"Air")]
    Air,
    
    /// <summary>
    /// Bus
    /// Encoded/decoded by serializers as &quot;BUSS&quot;.
    /// </summary>
    [EnumMember(Value = "BUSS")]
    [IsoId("_sf5qivQDEeihCvvpsmGI2w")]
    [Description(@"Bus")]
    Bus,
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_sf5qifQDEeihCvvpsmGI2w")]
    [Description(@"Other National")]
    OtherNational,
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_sf5qjPQDEeihCvvpsmGI2w")]
    [Description(@"Other Private")]
    OtherPrivate,
    
}
