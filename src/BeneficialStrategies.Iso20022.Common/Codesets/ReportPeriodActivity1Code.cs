// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of report activity for a specific reporting period.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_B2joAJfoEeSfnc-VXAEapg")]
[Description(@"Specifies the type of report activity for a specific reporting period.")]
[DerivedFrom(typeof(ReportPeriodActivityCode))]
public enum ReportPeriodActivity1Code
{
    /// <summary>
    /// No transaction has been identified during the period.
    /// Encoded/decoded by serializers as &quot;NOTX&quot;.
    /// </summary>
    [EnumMember(Value = "NOTX")]
    [IsoId("_Lbu1sZfsEeSfnc-VXAEapg")]
    [Description(@"No transaction has been identified during the period.")]
    NoTransaction = ReportPeriodActivityCode.NoTransaction, // same ordinal as derivation source for type conversions
    
}
