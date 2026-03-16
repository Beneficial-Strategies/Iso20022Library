// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of statement reporting on account holdings for corporate action events eg. reporting on multiple accounts or multiple events.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTCYiNp-Ed-ak6NoX_4Aeg_263893387")]
[Description(
    @"Type of statement reporting on account holdings for corporate action events eg. reporting on multiple accounts or multiple events."
)]
[Derivations(typeof(CorporateActionStatementReportingType1Code))]
public enum CorporateActionStatementReportingTypeCode
{
    /// <summary>
    /// The reporting is for a single event and for multiple accounts.
    /// Encoded/decoded by serializers as &quot;MASE&quot;.
    /// </summary>
    [EnumMember(Value = "MASE")]
    [IsoId("_bTMJgNp-Ed-ak6NoX_4Aeg_358501091")]
    [Description(@"The reporting is for a single event and for multiple accounts.")]
    MultipleAccounts,

    /// <summary>
    /// The reporting is for multiple events for a single account.
    /// Encoded/decoded by serializers as &quot;SAME&quot;.
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("_bTMJgdp-Ed-ak6NoX_4Aeg_761162779")]
    [Description(@"The reporting is for multiple events for a single account.")]
    MultipleEvents,
}
