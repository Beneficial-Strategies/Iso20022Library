// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the method of execution reporting requested by issuer of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aM2zlNp-Ed-ak6NoX_4Aeg_-1038437267")]
[Description(@"Indicates the method of execution reporting requested by issuer of the order.")]
[DerivedFrom(typeof(MultilegReportTypeCode))]
public enum MultilegReportType1Code
{
    /// <summary>
    /// Report by multileg security only (do not report legs).
    /// Encoded/decoded by serializers as &quot;BYSE&quot;.
    /// </summary>
    [EnumMember(Value = "BYSE")]
    [IsoId("_aM2zldp-Ed-ak6NoX_4Aeg_-1005190054")]
    [Description(@"Report by multileg security only (do not report legs).")]
    BySecurity = MultilegReportTypeCode.BySecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report by multileg security and by instrument legs belonging to the multileg security.
    /// Encoded/decoded by serializers as &quot;BSBL&quot;.
    /// </summary>
    [EnumMember(Value = "BSBL")]
    [IsoId("_aM2zltp-Ed-ak6NoX_4Aeg_-1005189340")]
    [Description(
        @"Report by multileg security and by instrument legs belonging to the multileg security."
    )]
    BySecurityAndLeg = MultilegReportTypeCode.BySecurityAndLeg, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report by instrument legs belonging to the multileg security only (do not report status of multileg security).
    /// Encoded/decoded by serializers as &quot;BYLE&quot;.
    /// </summary>
    [EnumMember(Value = "BYLE")]
    [IsoId("_aM2zl9p-Ed-ak6NoX_4Aeg_-1005188530")]
    [Description(
        @"Report by instrument legs belonging to the multileg security only (do not report status of multileg security)."
    )]
    ByInstrumentLeg = MultilegReportTypeCode.ByInstrumentLeg, // same ordinal as derivation source for type conversions
}
