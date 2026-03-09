// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the report, that is, standard or proprietary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTCPotp-Ed-ak6NoX_4Aeg_1670165238")]
[Description(@"Specifies the nature of the report, that is, standard or proprietary.")]
[DerivedFrom(typeof(ReportIndicatorCode))]
public enum ReportIndicator1Code
{
    /// <summary>
    /// Requested report must contain information in the format of a statement.
    /// Encoded/decoded by serializers as &quot;STND&quot;.
    /// </summary>
    [EnumMember(Value = "STND")]
    [IsoId("_ZTCPo9p-Ed-ak6NoX_4Aeg_1969382793")]
    [Description(@"Requested report must contain information in the format of a statement.")]
    Standard = ReportIndicatorCode.Standard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested report must contain information in a bilaterally agreed format.
    /// Encoded/decoded by serializers as &quot;PRPR&quot;.
    /// </summary>
    [EnumMember(Value = "PRPR")]
    [IsoId("_ZTCPpNp-Ed-ak6NoX_4Aeg_2001706027")]
    [Description(@"Requested report must contain information in a bilaterally agreed format.")]
    Proprietary = ReportIndicatorCode.Proprietary, // same ordinal as derivation source for type conversions
    
}
