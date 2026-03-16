// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the transfer cancellation is rejected.
/// </summary>
[IsoId("_RQf8kNp-Ed-ak6NoX_4Aeg_1498754509")]
[DisplayName("Transfer Cancellation Rejected Status")]
public record TransferCancellationRejectedStatus1
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RQf8kdp-Ed-ak6NoX_4Aeg_1498754535")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancellationRejectedReason1Code Reason { get; init; }

    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_RQf8ktp-Ed-ak6NoX_4Aeg_1498754551")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the rejected status.
    /// </summary>
    [IsoId("_RQf8k9p-Ed-ak6NoX_4Aeg_1498757014")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<GenericIdentification1> DataSourceScheme { get; init; } = [];
}
