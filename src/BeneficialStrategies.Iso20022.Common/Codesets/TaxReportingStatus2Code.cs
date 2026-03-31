// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single tax reporting transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tDgAwWufEeaRcazd7EYKFQ")]
[Description(@"Specifies the status of a single tax reporting transaction.")]
[DerivedFrom(typeof(StatisticalReportingStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxReportingStatus2Code>))]
#endif
public enum TaxReportingStatus2Code
{
    /// <summary>
    /// Transaction or report has been accepted.
    /// Encoded/decoded by serializers as &quot;ACPT&quot;.
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_tLFPcWufEeaRcazd7EYKFQ")]
    [Description(@"Transaction or report has been accepted.")]
    Accepted = StatisticalReportingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction or report has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_tLFPc2ufEeaRcazd7EYKFQ")]
    [Description(@"Transaction or report has been rejected.")]
    Rejected = StatisticalReportingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been accepted with warnings.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_tLFPdWufEeaRcazd7EYKFQ")]
    [Description(@"Transaction has been accepted with warnings.")]
    Warning = StatisticalReportingStatusCode.Warning, // same ordinal as derivation source for type conversions
}
