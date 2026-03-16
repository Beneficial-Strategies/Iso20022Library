// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for ReportResponse.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yk988N6VEeiwsev40qZGEQ")]
[Description(@"List of specific services for ReportResponse.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService7Code
{
    /// <summary>
    /// The POI System responds to a transaction report request.
    /// Encoded/decoded by serializers as &quot;RPTP&quot;.
    /// </summary>
    [EnumMember(Value = "RPTP")]
    [IsoId("_c4lHMd6VEeiwsev40qZGEQ")]
    [Description(@"The POI System responds to a transaction report request.")]
    AdministrativeReportTransactionResponse =
        RetailerServiceCode.AdministrativeReportTransactionResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a totals figures request.
    /// Encoded/decoded by serializers as &quot;RPAP&quot;.
    /// </summary>
    [EnumMember(Value = "RPAP")]
    [IsoId("_dKVlkd6VEeiwsev40qZGEQ")]
    [Description(@"The POI System responds to a totals figures request.")]
    AdministrativeReportGetTotalsResponse =
        RetailerServiceCode.AdministrativeReportGetTotalsResponse, // same ordinal as derivation source for type conversions
}
