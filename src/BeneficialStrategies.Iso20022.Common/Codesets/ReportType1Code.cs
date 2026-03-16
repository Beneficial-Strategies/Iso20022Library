// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the report contains a new, a resubmitted or an amended baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTVxotp-Ed-ak6NoX_4Aeg_-215532945")]
[Description(@"Specifies whether the report contains a new, a resubmitted or an amended baseline.")]
[DerivedFrom(typeof(ReportTypeCode))]
public enum ReportType1Code
{
    /// <summary>
    /// The report contains a baseline submitted for the first time.
    /// Encoded/decoded by serializers as &quot;FWIS&quot;.
    /// </summary>
    [EnumMember(Value = "FWIS")]
    [IsoId("_ZTVxo9p-Ed-ak6NoX_4Aeg_302562336")]
    [Description(@"The report contains a baseline submitted for the first time.")]
    ForwardInitialSubmission = ReportTypeCode.ForwardInitialSubmission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The report contains a baseline that is resubmitted.
    /// Encoded/decoded by serializers as &quot;FWRE&quot;.
    /// </summary>
    [EnumMember(Value = "FWRE")]
    [IsoId("_ZTVxpNp-Ed-ak6NoX_4Aeg_302562354")]
    [Description(@"The report contains a baseline that is resubmitted.")]
    ForwardReSubmission = ReportTypeCode.ForwardReSubmission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The report contains a baseline that is amended.
    /// Encoded/decoded by serializers as &quot;FWAM&quot;.
    /// </summary>
    [EnumMember(Value = "FWAM")]
    [IsoId("_ZTVxpdp-Ed-ak6NoX_4Aeg_302562379")]
    [Description(@"The report contains a baseline that is amended.")]
    ForwardAmend = ReportTypeCode.ForwardAmend, // same ordinal as derivation source for type conversions
}
