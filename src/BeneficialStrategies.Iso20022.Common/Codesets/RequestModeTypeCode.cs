// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the combination of mode and type of the query information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m8c_gMm4EeWAGphE2LvqeA")]
[Description(@"Specifies the combination of mode and type of the query information.")]
[Derivations(typeof(RequestModeType1Code))]
public enum RequestModeTypeCode
{
    /// <summary>
    /// Day information query type, in on-demand mode.
    /// Encoded/decoded by serializers as &quot;ONDD&quot;.
    /// </summary>
    [EnumMember(Value = "ONDD")]
    [IsoId("_Maj4YMm8EeWAGphE2LvqeA")]
    [Description(@"Day information query type, in on-demand mode.")]
    OnDemandDayInformation,

    /// <summary>
    /// Future information query type, in on-demand mode.
    /// Encoded/decoded by serializers as &quot;ONDF&quot;.
    /// </summary>
    [EnumMember(Value = "ONDF")]
    [IsoId("_MkFAwMm8EeWAGphE2LvqeA")]
    [Description(@"Future information query type, in on-demand mode.")]
    OnDemandFutureInformation,

    /// <summary>
    /// Day information query type, in scheduled mode.
    /// Encoded/decoded by serializers as &quot;SCHD&quot;.
    /// </summary>
    [EnumMember(Value = "SCHD")]
    [IsoId("_Mtv6IMm8EeWAGphE2LvqeA")]
    [Description(@"Day information query type, in scheduled mode.")]
    ScheduledDayInformation,

    /// <summary>
    /// Future information query type, in scheduled mode.
    /// Encoded/decoded by serializers as &quot;SCHF&quot;.
    /// </summary>
    [EnumMember(Value = "SCHF")]
    [IsoId("_M209oMm8EeWAGphE2LvqeA")]
    [Description(@"Future information query type, in scheduled mode.")]
    ScheduledFutureInformation,

    /// <summary>
    /// Forecast query type and mode.
    /// Encoded/decoded by serializers as &quot;FCST&quot;.
    /// </summary>
    [EnumMember(Value = "FCST")]
    [IsoId("_M-RCYMm8EeWAGphE2LvqeA")]
    [Description(@"Forecast query type and mode.")]
    Forecast,
}
