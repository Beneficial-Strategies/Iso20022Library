// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the transfer cancellation is complete.
/// </summary>
[IsoId("_RQf8mdp-Ed-ak6NoX_4Aeg_2013423795")]
[DisplayName("Transfer Cancellation Complete Status And Reason")]
public record TransferCancellationCompleteStatusAndReason1
{
    /// <summary>
    /// Reason for the transfer cancellation complete status.
    /// </summary>
    [IsoId("_RQf8mtp-Ed-ak6NoX_4Aeg_1302969453")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancelledStatusReason1Code Reason { get; init; }

    /// <summary>
    /// Reason for the transfer cancellation complete status.
    /// </summary>
    [IsoId("_RQptkNp-Ed-ak6NoX_4Aeg_2013423813")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the transfer cancellation complete status.
    /// </summary>
    [IsoId("_RQptkdp-Ed-ak6NoX_4Aeg_2013423927")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }
}
