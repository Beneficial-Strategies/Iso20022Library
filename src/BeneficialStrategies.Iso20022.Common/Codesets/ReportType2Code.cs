// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the baseline report is based on matching or pre-matching data sets.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTVxptp-Ed-ak6NoX_4Aeg_-1196146765")]
[Description(@"Specifies whether the baseline report is based on matching or pre-matching data sets.")]
[DerivedFrom(typeof(ReportTypeCode))]
public enum ReportType2Code
{
    /// <summary>
    /// The report is precalculated. This type of report is sent when an amendment is proposed.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_ZTVxp9p-Ed-ak6NoX_4Aeg_-1137964591")]
    [Description(@"The report is precalculated. This type of report is sent when an amendment is proposed.")]
    Precalculated = ReportTypeCode.Precalculated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The report is calculated on the basis of a dataset matched with a baseline.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_ZTVxqNp-Ed-ak6NoX_4Aeg_-1137964548")]
    [Description(@"The report is calculated on the basis of a dataset matched with a baseline.")]
    Current = ReportTypeCode.Current, // same ordinal as derivation source for type conversions
    
}
