// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of report activity for a specific period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NgO2UZfnEeSfnc-VXAEapg")]
[Description(@"Specifies the type of report activity for a specific period.")]
[Derivations(typeof(ReportPeriodActivity1Code), typeof(ReportPeriodActivity3Code))]
public enum ReportPeriodActivityCode
{
    /// <summary>
    /// No transaction has been identified during the period.
    /// Encoded/decoded by serializers as &quot;NOTX&quot;.
    /// </summary>
    [EnumMember(Value = "NOTX")]
    [IsoId("_hNRosJfnEeSfnc-VXAEapg")]
    [Description(@"No transaction has been identified during the period.")]
    NoTransaction,

    /// <summary>
    /// No report has been received from reporting agent.
    /// Encoded/decoded by serializers as &quot;NORA&quot;.
    /// </summary>
    [EnumMember(Value = "NORA")]
    [IsoId("_ypfn8JfnEeSfnc-VXAEapg")]
    [Description(@"No report has been received from reporting agent.")]
    NoReportFromAgent,

    /// <summary>
    /// Report has been received but was corrupted.
    /// Encoded/decoded by serializers as &quot;CRPT&quot;.
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_csIZkJyZEeSBzu9qI1PCRQ")]
    [Description(@"Report has been received but was corrupted.")]
    CorruptedReport,
}
