// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the in repair status.
/// </summary>
[IsoId("_RR_KUNp-Ed-ak6NoX_4Aeg_1062766398")]
[DisplayName("In Repair Status")]
public record InRepairStatus3
{
    /// <summary>
    /// Reason for the in-repair status.
    /// </summary>
    [IsoId("_RR_KUdp-Ed-ak6NoX_4Aeg_1346286799")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Reason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the in-repair status.
    /// </summary>
    [IsoId("_RR_KUtp-Ed-ak6NoX_4Aeg_1062766459")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RR_KU9p-Ed-ak6NoX_4Aeg_1062766424")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; }
}
