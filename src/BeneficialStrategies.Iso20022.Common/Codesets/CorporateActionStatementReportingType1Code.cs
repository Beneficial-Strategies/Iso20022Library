// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of statement reporting on account holdings for corporate action events for example. reporting on multiple accounts or multiple events.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTCYhdp-Ed-ak6NoX_4Aeg_2055089309")]
[Description(
    @"Type of statement reporting on account holdings for corporate action events for example. reporting on multiple accounts or multiple events."
)]
[DerivedFrom(typeof(CorporateActionStatementReportingTypeCode))]
public enum CorporateActionStatementReportingType1Code
{
    /// <summary>
    /// The reporting is for a single event and for multiple accounts.
    /// Encoded/decoded by serializers as &quot;MASE&quot;.
    /// </summary>
    [EnumMember(Value = "MASE")]
    [IsoId("_bTCYhtp-Ed-ak6NoX_4Aeg_-1322387625")]
    [Description(@"The reporting is for a single event and for multiple accounts.")]
    MultipleAccounts = CorporateActionStatementReportingTypeCode.MultipleAccounts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The reporting is for multiple events for a single account.
    /// Encoded/decoded by serializers as &quot;SAME&quot;.
    /// </summary>
    [EnumMember(Value = "SAME")]
    [IsoId("_bTCYh9p-Ed-ak6NoX_4Aeg_144761138")]
    [Description(@"The reporting is for multiple events for a single account.")]
    MultipleEvents = CorporateActionStatementReportingTypeCode.MultipleEvents, // same ordinal as derivation source for type conversions
}
