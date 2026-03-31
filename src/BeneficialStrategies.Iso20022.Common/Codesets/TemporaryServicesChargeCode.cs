// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Charge types for temporary services
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OwYzt_ffEei89sMSHxl1ew")]
[Description(@"Charge types for temporary services")]
[Derivations(typeof(TemporaryServicesCharge1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TemporaryServicesChargeCode>))]
#endif
public enum TemporaryServicesChargeCode
{
    /// <summary>
    /// Holiday
    /// Encoded/decoded by serializers as &quot;HOLI&quot;.
    /// </summary>
    [EnumMember(Value = "HOLI")]
    [IsoId("_OwYzuvffEei89sMSHxl1ew")]
    [Description(@"Holiday")]
    Holiday,

    /// <summary>
    /// On call
    /// Encoded/decoded by serializers as &quot;ONCL&quot;.
    /// </summary>
    [EnumMember(Value = "ONCL")]
    [IsoId("_OwZawvffEei89sMSHxl1ew")]
    [Description(@"On call")]
    OnCall,

    /// <summary>
    /// Hazard
    /// Encoded/decoded by serializers as &quot;HAZD&quot;.
    /// </summary>
    [EnumMember(Value = "HAZD")]
    [IsoId("_OwZawfffEei89sMSHxl1ew")]
    [Description(@"Hazard")]
    Hazard,

    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_OwYzufffEei89sMSHxl1ew")]
    [Description(@"Other National")]
    OtherNational,

    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_OwZawPffEei89sMSHxl1ew")]
    [Description(@"Other Private")]
    OtherPrivate,

    /// <summary>
    /// Overtime
    /// Encoded/decoded by serializers as &quot;OVRT&quot;.
    /// </summary>
    [EnumMember(Value = "OVRT")]
    [IsoId("_5B_YIPffEei89sMSHxl1ew")]
    [Description(@"Overtime")]
    Overtime,

    /// <summary>
    /// Night
    /// Encoded/decoded by serializers as &quot;NITE&quot;.
    /// </summary>
    [EnumMember(Value = "NITE")]
    [IsoId("_8YVB0PffEei89sMSHxl1ew")]
    [Description(@"Night")]
    Night,

    /// <summary>
    /// Regular
    /// Encoded/decoded by serializers as &quot;REGL&quot;.
    /// </summary>
    [EnumMember(Value = "REGL")]
    [IsoId("_8a9fEPffEei89sMSHxl1ew")]
    [Description(@"Regular")]
    Regular,

    /// <summary>
    /// Weekend
    /// Encoded/decoded by serializers as &quot;WKND&quot;.
    /// </summary>
    [EnumMember(Value = "WKND")]
    [IsoId("_8dnxgPffEei89sMSHxl1ew")]
    [Description(@"Weekend")]
    Weekend,
}
