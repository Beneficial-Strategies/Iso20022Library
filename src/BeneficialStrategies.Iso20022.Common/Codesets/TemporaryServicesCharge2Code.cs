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
[IsoId("_LKakUVXcEfC0lMwgjvMClw")]
[Description(@"Charge types for temporary services")]
[DerivedFrom(typeof(TemporaryServicesChargeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TemporaryServicesCharge2Code>))]
public enum TemporaryServicesCharge2Code
{
    /// <summary>
    /// Hazard
    /// Encoded/decoded by serializers as &quot;HAZD&quot;.
    /// </summary>
    [EnumMember(Value = "HAZD")]
    [IsoId("_LM2NUVXcEfC0lMwgjvMClw")]
    [Description(@"Hazard")]
    Hazard = TemporaryServicesChargeCode.Hazard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holiday
    /// Encoded/decoded by serializers as &quot;HOLI&quot;.
    /// </summary>
    [EnumMember(Value = "HOLI")]
    [IsoId("_LM2NT1XcEfC0lMwgjvMClw")]
    [Description(@"Holiday")]
    Holiday = TemporaryServicesChargeCode.Holiday, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Night
    /// Encoded/decoded by serializers as &quot;NITE&quot;.
    /// </summary>
    [EnumMember(Value = "NITE")]
    [IsoId("_LM2NTVXcEfC0lMwgjvMClw")]
    [Description(@"Night")]
    Night = TemporaryServicesChargeCode.Night, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On call
    /// Encoded/decoded by serializers as &quot;ONCL&quot;.
    /// </summary>
    [EnumMember(Value = "ONCL")]
    [IsoId("_LM2NS1XcEfC0lMwgjvMClw")]
    [Description(@"On call")]
    OnCall = TemporaryServicesChargeCode.OnCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Overtime
    /// Encoded/decoded by serializers as &quot;OVRT&quot;.
    /// </summary>
    [EnumMember(Value = "OVRT")]
    [IsoId("_LM2NRVXcEfC0lMwgjvMClw")]
    [Description(@"Overtime")]
    Overtime = TemporaryServicesChargeCode.Overtime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regular
    /// Encoded/decoded by serializers as &quot;REGL&quot;.
    /// </summary>
    [EnumMember(Value = "REGL")]
    [IsoId("_LM2NQ1XcEfC0lMwgjvMClw")]
    [Description(@"Regular")]
    Regular = TemporaryServicesChargeCode.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Weekend
    /// Encoded/decoded by serializers as &quot;WKND&quot;.
    /// </summary>
    [EnumMember(Value = "WKND")]
    [IsoId("_LM2NQVXcEfC0lMwgjvMClw")]
    [Description(@"Weekend")]
    Weekend = TemporaryServicesChargeCode.Weekend, // same ordinal as derivation source for type conversions
}
