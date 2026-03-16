// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the cancellation pending status.
/// </summary>
[IsoId("_RSb2Qtp-Ed-ak6NoX_4Aeg_1032897405")]
[DisplayName("Cancellation Pending Status")]
public record CancellationPendingStatus1
{
    /// <summary>
    /// Reason for the cancellation pending status.
    /// </summary>
    [IsoId("_RSb2Q9p-Ed-ak6NoX_4Aeg_1032897423")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Reason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the cancellation pending status.
    /// </summary>
    [IsoId("_RSb2RNp-Ed-ak6NoX_4Aeg_1032897458")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RSb2Rdp-Ed-ak6NoX_4Aeg_997378841")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; }
}
