// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single statistical reporting transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cfa8Z-2wEeS-SNPe_7uMwA")]
[Description(@"Specifies the status of a single statistical reporting transaction.")]
[DerivedFrom(typeof(StatisticalReportingStatusCode))]
public enum StatisticalReportingStatus2Code
{
    /// <summary>
    /// Transaction or report has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_cfa8aO2wEeS-SNPe_7uMwA")]
    [Description(@"Transaction or report has been accepted.")]
    Accepted = StatisticalReportingStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_cfa8a-2wEeS-SNPe_7uMwA")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected = StatisticalReportingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_6KqdQe2wEeS-SNPe_7uMwA")]
    [Description(@"Transaction has been accepted with warnings.")]
    Warning = StatisticalReportingStatusCode.Warning, // same ordinal as derivation source for type conversions
    
}
