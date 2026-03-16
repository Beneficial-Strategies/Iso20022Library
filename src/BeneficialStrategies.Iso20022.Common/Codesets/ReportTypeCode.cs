// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the purpose of the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTe7kNp-Ed-ak6NoX_4Aeg_448071852")]
[Description(@"Specifies the purpose of the report.")]
[Derivations(typeof(ReportType2Code), typeof(ReportType1Code))]
public enum ReportTypeCode
{
    /// <summary>
    /// The report is precalculated. This type of report is sent when an amendment is proposed.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_ZTe7kdp-Ed-ak6NoX_4Aeg_882128178")]
    [Description(
        @"The report is precalculated. This type of report is sent when an amendment is proposed."
    )]
    Precalculated,

    /// <summary>
    /// The report is calculated on the basis of a dataset matched with a baseline.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_ZTe7ktp-Ed-ak6NoX_4Aeg_919991130")]
    [Description(@"The report is calculated on the basis of a dataset matched with a baseline.")]
    Current,

    /// <summary>
    /// The report contains a baseline submitted for the first time.
    /// Encoded/decoded by serializers as &quot;FWIS&quot;.
    /// </summary>
    [EnumMember(Value = "FWIS")]
    [IsoId("_ZTe7k9p-Ed-ak6NoX_4Aeg_2058968655")]
    [Description(@"The report contains a baseline submitted for the first time.")]
    ForwardInitialSubmission,

    /// <summary>
    /// The report contains a baseline that is resubmitted.
    /// Encoded/decoded by serializers as &quot;FWRE&quot;.
    /// </summary>
    [EnumMember(Value = "FWRE")]
    [IsoId("_ZTe7lNp-Ed-ak6NoX_4Aeg_2058970671")]
    [Description(@"The report contains a baseline that is resubmitted.")]
    ForwardReSubmission,

    /// <summary>
    /// The report contains a baseline that is amended.
    /// Encoded/decoded by serializers as &quot;FWAM&quot;.
    /// </summary>
    [EnumMember(Value = "FWAM")]
    [IsoId("_ZTe7ldp-Ed-ak6NoX_4Aeg_2058971008")]
    [Description(@"The report contains a baseline that is amended.")]
    ForwardAmend,
}
