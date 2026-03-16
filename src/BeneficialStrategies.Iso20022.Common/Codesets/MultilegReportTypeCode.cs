// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the method of execution reporting requested by issuer of the order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aM_9gNp-Ed-ak6NoX_4Aeg_1957137994")]
[Description(@"Indicates the method of execution reporting requested by issuer of the order.")]
[Derivations(typeof(MultilegReportType1Code))]
public enum MultilegReportTypeCode
{
    /// <summary>
    /// Report by multileg security only (do not report legs).
    /// Encoded/decoded by serializers as &quot;BYSE&quot;.
    /// </summary>
    [EnumMember(Value = "BYSE")]
    [IsoId("_aM_9gdp-Ed-ak6NoX_4Aeg_1999620439")]
    [Description(@"Report by multileg security only (do not report legs).")]
    BySecurity,

    /// <summary>
    /// Report by multileg security and by instrument legs belonging to the multileg security.
    /// Encoded/decoded by serializers as &quot;BSBL&quot;.
    /// </summary>
    [EnumMember(Value = "BSBL")]
    [IsoId("_aM_9gtp-Ed-ak6NoX_4Aeg_-1983198187")]
    [Description(
        @"Report by multileg security and by instrument legs belonging to the multileg security."
    )]
    BySecurityAndLeg,

    /// <summary>
    /// Report by instrument legs belonging to the multileg security only (do not report status of multileg security).
    /// Encoded/decoded by serializers as &quot;BYLE&quot;.
    /// </summary>
    [EnumMember(Value = "BYLE")]
    [IsoId("_aM_9g9p-Ed-ak6NoX_4Aeg_-1464179831")]
    [Description(
        @"Report by instrument legs belonging to the multileg security only (do not report status of multileg security)."
    )]
    ByInstrumentLeg,
}
