// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an investigation case.||Note: |The cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a2lGB9p-Ed-ak6NoX_4Aeg_-286578843")]
[Description(@"Specifies the status of an investigation case.||Note: |The cases that have been rejected (not accepted) are unknown to the Party reporting the status of cases. They will be reported with the CaseStatusCode = Unknown.")]
[DerivedFrom(typeof(CaseStatusCode))]
public enum CaseStatus2Code
{
    /// <summary>
    /// Case has been closed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_a2lGCNp-Ed-ak6NoX_4Aeg_-286578825")]
    [Description(@"Case has been closed.")]
    Closed = CaseStatusCode.Closed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case has been assigned to another party.
    /// Encoded/decoded by serializers as &quot;ASGN&quot;.
    /// </summary>
    [EnumMember(Value = "ASGN")]
    [IsoId("_a2uP8Np-Ed-ak6NoX_4Aeg_-286578808")]
    [Description(@"Case has been assigned to another party.")]
    Assigned = CaseStatusCode.Assigned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case is currently under investigation.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_a2uP8dp-Ed-ak6NoX_4Aeg_-286578566")]
    [Description(@"Case is currently under investigation.")]
    UnderInvestigation = CaseStatusCode.UnderInvestigation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Case has never been assigned before.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_a2uP8tp-Ed-ak6NoX_4Aeg_-286578549")]
    [Description(@"Case has never been assigned before.")]
    Unknown = CaseStatusCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investigation is taking too long.
    /// Encoded/decoded by serializers as &quot;ODUE&quot;.
    /// </summary>
    [EnumMember(Value = "ODUE")]
    [IsoId("_a2uP89p-Ed-ak6NoX_4Aeg_-286578548")]
    [Description(@"Investigation is taking too long.")]
    Overdue = CaseStatusCode.Overdue, // same ordinal as derivation source for type conversions
    
}
