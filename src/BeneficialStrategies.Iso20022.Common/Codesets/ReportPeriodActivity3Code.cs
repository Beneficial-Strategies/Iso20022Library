// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of report activity for a specific reporting period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HW4DYsESEea7jLfvGi1PDw")]
[Description(@"Specifies the type of report activity for a specific reporting period.")]
[DerivedFrom(typeof(ReportPeriodActivityCode))]
public enum ReportPeriodActivity3Code
{
    /// <summary>
    /// No transaction has been identified during the period.
    /// Encoded/decoded by serializers as &quot;NOTX&quot;.
    /// </summary>
    [EnumMember(Value = "NOTX")]
    [IsoId("_HW4DY8ESEea7jLfvGi1PDw")]
    [Description(@"No transaction has been identified during the period.")]
    NoTransaction = ReportPeriodActivityCode.NoTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No report has been received from reporting agent.
    /// Encoded/decoded by serializers as &quot;NORA&quot;.
    /// </summary>
    [EnumMember(Value = "NORA")]
    [IsoId("_LTDlEcESEea7jLfvGi1PDw")]
    [Description(@"No report has been received from reporting agent.")]
    NoReportFromAgent = ReportPeriodActivityCode.NoReportFromAgent, // same ordinal as derivation source for type conversions
    
}
