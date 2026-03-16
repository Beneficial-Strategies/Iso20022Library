// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y8_HINp-Ed-ak6NoX_4Aeg_1401456451")]
[Description(
    @"Specifies how the price valuation timing is done based on the timeline defined in the prospectus."
)]
[Derivations(typeof(ValuationTiming1Code))]
public enum ValuationTimingCode
{
    /// <summary>
    /// Price valuation is done exceptionally, outside the timeframe specified in the prospectus.
    /// Encoded/decoded by serializers as &quot;EXCP&quot;.
    /// </summary>
    [EnumMember(Value = "EXCP")]
    [IsoId("_Y8_HIdp-Ed-ak6NoX_4Aeg_1401456452")]
    [Description(
        @"Price valuation is done exceptionally, outside the timeframe specified in the prospectus."
    )]
    Exceptional,

    /// <summary>
    /// Price valuation is done within the timeframe specified in the prospectus.
    /// Encoded/decoded by serializers as &quot;USUA&quot;.
    /// </summary>
    [EnumMember(Value = "USUA")]
    [IsoId("_Y8_HItp-Ed-ak6NoX_4Aeg_1401456453")]
    [Description(@"Price valuation is done within the timeframe specified in the prospectus.")]
    Usual,

    /// <summary>
    /// Price valuation that is done outside the usual timeframe, but in conformance with a case specified in the prospectus, eg, market closing day.
    /// Encoded/decoded by serializers as &quot;PATC&quot;.
    /// </summary>
    [EnumMember(Value = "PATC")]
    [IsoId("_Y8_HI9p-Ed-ak6NoX_4Aeg_1401456454")]
    [Description(
        @"Price valuation that is done outside the usual timeframe, but in conformance with a case specified in the prospectus, eg, market closing day."
    )]
    Particular,
}
