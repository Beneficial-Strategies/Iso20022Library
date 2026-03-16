// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a transaction report is late.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_adsE6Np-Ed-ak6NoX_4Aeg_-1914008169")]
[Description(@"Specifies whether a transaction report is late.")]
[DerivedFrom(typeof(LateReportCode))]
public enum LateReport1Code
{
    /// <summary>
    /// The confirmation is late.
    /// Encoded/decoded by serializers as &quot;LAT1&quot;.
    /// </summary>
    [EnumMember(Value = "LAT1")]
    [IsoId("_adsE6dp-Ed-ak6NoX_4Aeg_-1032043364")]
    [Description(@"The confirmation is late.")]
    Late = LateReportCode.Late, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The confirmation is late because the trade was executed as a number of partials.
    /// Encoded/decoded by serializers as &quot;LAT2&quot;.
    /// </summary>
    [EnumMember(Value = "LAT2")]
    [IsoId("_adsE6tp-Ed-ak6NoX_4Aeg_-1032043339")]
    [Description(
        @"The confirmation is late because the trade was executed as a number of partials."
    )]
    LateBecausePartial = LateReportCode.LateBecausePartial, // same ordinal as derivation source for type conversions
}
