// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an investigation case.||Note: |The Cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VnJzwdp-Ed-ak6NoX_4Aeg_-1043344711")]
[Description(@"Specifies the status of an investigation case.||Note: |The Cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.")]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum CaseStatus1Code
{
    /// <summary>
    /// Case has been closed.
    /// Encoded/decoded by serializers as &quot;CLOSE&quot;.
    /// </summary>
    [EnumMember(Value = "CLOSE")]
    [IsoId("_VnJzwtp-Ed-ak6NoX_4Aeg_-1011019924")]
    [Description(@"Case has been closed.")]
    Closed,
    
    /// <summary>
    /// Case has been assigned to another party.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_VnJzw9p-Ed-ak6NoX_4Aeg_-955611187")]
    [Description(@"Case has been assigned to another party.")]
    Assigned,
    
    /// <summary>
    /// Case is currently under investigation.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_VnJzxNp-Ed-ak6NoX_4Aeg_-839246940")]
    [Description(@"Case is currently under investigation.")]
    UnderInvestigation,
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_VnJzxdp-Ed-ak6NoX_4Aeg_-692327460")]
    [Description(@"Case has never been assigned before.")]
    Unknown,
    
}
