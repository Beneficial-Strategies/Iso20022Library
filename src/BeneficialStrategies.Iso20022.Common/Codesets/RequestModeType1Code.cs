// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the combination of mode and type of the query information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rDVVUMm4EeWAGphE2LvqeA")]
[Description(@"Specifies the combination of mode and type of the query information.")]
[DerivedFrom(typeof(RequestModeTypeCode))]
public enum RequestModeType1Code
{
    /// <summary>
    /// Forecast query type and mode.
    /// Encoded/decoded by serializers as &quot;FCST&quot;.
    /// </summary>
    [EnumMember(Value = "FCST")]
    [IsoId("_qNDQwcm8EeWAGphE2LvqeA")]
    [Description(@"Forecast query type and mode.")]
    Forecast = RequestModeTypeCode.Forecast, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Day information query type, in on-demand mode.
    /// Encoded/decoded by serializers as &quot;ONDD&quot;.
    /// </summary>
    [EnumMember(Value = "ONDD")]
    [IsoId("_qcFLQsm8EeWAGphE2LvqeA")]
    [Description(@"Day information query type, in on-demand mode.")]
    OnDemandDayInformation = RequestModeTypeCode.OnDemandDayInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Future information query type, in on-demand mode.
    /// Encoded/decoded by serializers as &quot;ONDF&quot;.
    /// </summary>
    [EnumMember(Value = "ONDF")]
    [IsoId("_qfzNocm8EeWAGphE2LvqeA")]
    [Description(@"Future information query type, in on-demand mode.")]
    OnDemandFutureInformation = RequestModeTypeCode.OnDemandFutureInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Day information query type, in scheduled mode.
    /// Encoded/decoded by serializers as &quot;SCHD&quot;.
    /// </summary>
    [EnumMember(Value = "SCHD")]
    [IsoId("_qscigsm8EeWAGphE2LvqeA")]
    [Description(@"Day information query type, in scheduled mode.")]
    ScheduledDayInformation = RequestModeTypeCode.ScheduledDayInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Future information query type, in scheduled mode.
    /// Encoded/decoded by serializers as &quot;SCHF&quot;.
    /// </summary>
    [EnumMember(Value = "SCHF")]
    [IsoId("_qtfEUcm8EeWAGphE2LvqeA")]
    [Description(@"Future information query type, in scheduled mode.")]
    ScheduledFutureInformation = RequestModeTypeCode.ScheduledFutureInformation, // same ordinal as derivation source for type conversions
}
