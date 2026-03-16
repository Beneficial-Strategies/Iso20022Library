// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an investigation case.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2uP9Np-Ed-ak6NoX_4Aeg_-1002966557")]
[Description(@"Specifies the status of an investigation case.")]
[Derivations(typeof(CaseStatus2Code))]
public enum CaseStatusCode
{
    /// <summary>
    /// Case has been closed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_a2uP9dp-Ed-ak6NoX_4Aeg_-1002966531")]
    [Description(@"Case has been closed.")]
    Closed,

    /// <summary>
    /// Case has been assigned to another party.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_a2uP9tp-Ed-ak6NoX_4Aeg_-1002966514")]
    [Description(@"Case has been assigned to another party.")]
    Assigned,

    /// <summary>
    /// Case is currently under investigation.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_a2uP99p-Ed-ak6NoX_4Aeg_-1002966497")]
    [Description(@"Case is currently under investigation.")]
    UnderInvestigation,

    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2uP-Np-Ed-ak6NoX_4Aeg_-1002966479")]
    [Description(@"Case has never been assigned before.")]
    Unknown,

    /// <summary>
    /// Investigation is taking too long.
    /// Encoded/decoded by serializers as &quot;ODUE&quot;.
    /// </summary>
    [EnumMember(Value = "ODUE")]
    [IsoId("_a24A8Np-Ed-ak6NoX_4Aeg_-960484981")]
    [Description(@"Investigation is taking too long.")]
    Overdue,
}
