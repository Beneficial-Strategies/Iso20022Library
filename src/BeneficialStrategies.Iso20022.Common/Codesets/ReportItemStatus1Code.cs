// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NSTaoEisEeSlHoYg_EudVQ")]
[Description(@"Specifies the status of an entry in a report.")]
[DerivedFrom(typeof(ReportItemStatusCode))]
public enum ReportItemStatus1Code
{
    /// <summary>
    /// Entry has been accepted by the receiver of the report.
    /// Encoded/decoded by serializers as &quot;ACPD&quot;.
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_VMcTwUi5EeSlHoYg_EudVQ")]
    [Description(@"Entry has been accepted by the receiver of the report.")]
    Accepted = ReportItemStatusCode.Accepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Entry has been rejected by the receiver of the report.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_VbdnMUi5EeSlHoYg_EudVQ")]
    [Description(@"Entry has been rejected by the receiver of the report.")]
    Rejected = ReportItemStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
}
