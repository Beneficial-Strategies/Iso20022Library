// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the report, ie, standard or proprietary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTCPpdp-Ed-ak6NoX_4Aeg_613407085")]
[Description(@"Specifies the nature of the report, ie, standard or proprietary.")]
[Derivations(typeof(ReportIndicator1Code))]
public enum ReportIndicatorCode
{
    /// <summary>
    /// Requested report must contain information in the format of a statement.
    /// Encoded/decoded by serializers as &quot;STND&quot;.
    /// </summary>
    [EnumMember(Value = "STND")]
    [IsoId("_ZTCPptp-Ed-ak6NoX_4Aeg_1052080555")]
    [Description(@"Requested report must contain information in the format of a statement.")]
    Standard,

    /// <summary>
    /// Requested report must contain information in a bilaterally agreed format.
    /// Encoded/decoded by serializers as &quot;PRPR&quot;.
    /// </summary>
    [EnumMember(Value = "PRPR")]
    [IsoId("_ZTCPp9p-Ed-ak6NoX_4Aeg_1128730440")]
    [Description(@"Requested report must contain information in a bilaterally agreed format.")]
    Proprietary,
}
