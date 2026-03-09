// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for ReportRequest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kRZ9oN6PEeiwsev40qZGEQ")]
[Description(@"List of specific services for ReportRequest.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService6Code
{
    /// <summary>
    /// The Sale System requests to the POI System a report on a list of transactions.
    /// Encoded/decoded by serializers as &quot;RPTQ&quot;.
    /// </summary>
    [EnumMember(Value = "RPTQ")]
    [IsoId("_potZgd6PEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests to the POI System a report on a list of transactions.")]
    AdministrativeReportTransactionRequest = RetailerServiceCode.AdministrativeReportTransactionRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Sale System requests to the POI System a report on the totals figures of the POI system.
    /// Encoded/decoded by serializers as &quot;RPAQ&quot;.
    /// </summary>
    [EnumMember(Value = "RPAQ")]
    [IsoId("_qOCUId6PEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests to the POI System a report on the totals figures of the POI system.")]
    AdministrativeReportGetTotalsRequest = RetailerServiceCode.AdministrativeReportGetTotalsRequest, // same ordinal as derivation source for type conversions
    
}
