// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the failed settlement status.
/// </summary>
[IsoId("_RR_KV9p-Ed-ak6NoX_4Aeg_1532242447")]
[DisplayName("Failed Settlement Status")]
public record FailedSettlementStatus1
{
    /// <summary>
    /// Reason for the failed settlement status.
    /// </summary>
    [IsoId("_RR_KWNp-Ed-ak6NoX_4Aeg_1532242482")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Reason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the failed settlement status.
    /// </summary>
    [IsoId("_RR_KWdp-Ed-ak6NoX_4Aeg_1532242756")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RR_KWtp-Ed-ak6NoX_4Aeg_2124998939")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; }
}
