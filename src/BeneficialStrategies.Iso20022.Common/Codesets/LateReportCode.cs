// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a transaction report is late.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad114Np-Ed-ak6NoX_4Aeg_-1931554281")]
[Description(@"Specifies whether a transaction report is late.")]
[Derivations(typeof(LateReport1Code))]
public enum LateReportCode
{
    /// <summary>
    /// The confirmation is late.
    /// Encoded/decoded by serializers as &quot;LAT1&quot;.
    /// </summary>
    [EnumMember(Value = "LAT1")]
    [IsoId("_ad114dp-Ed-ak6NoX_4Aeg_-1204743163")]
    [Description(@"The confirmation is late.")]
    Late,
    
    /// <summary>
    /// The confirmation is late because the trade was executed as a number of partials.
    /// Encoded/decoded by serializers as &quot;LAT2&quot;.
    /// </summary>
    [EnumMember(Value = "LAT2")]
    [IsoId("_ad114tp-Ed-ak6NoX_4Aeg_-1188118789")]
    [Description(@"The confirmation is late because the trade was executed as a number of partials.")]
    LateBecausePartial,
    
}
