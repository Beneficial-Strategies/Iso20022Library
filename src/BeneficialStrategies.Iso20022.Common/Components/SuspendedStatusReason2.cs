// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reason for the suspended status.
/// </summary>
[IsoId("_RTLdLNp-Ed-ak6NoX_4Aeg_-1398166736")]
[DisplayName("Suspended Status Reason")]
public record SuspendedStatusReason2
{
    /// <summary>
    /// Reason for the suspended status.
    /// </summary>
    [IsoId("_RTVOINp-Ed-ak6NoX_4Aeg_71691695")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required SuspendedStatusReason3Code Reason { get; init; }

    /// <summary>
    /// Reason for the suspended status.
    /// </summary>
    [IsoId("_RTVOIdp-Ed-ak6NoX_4Aeg_363523743")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the suspended status.
    /// </summary>
    [IsoId("_RTVOItp-Ed-ak6NoX_4Aeg_1793072243")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Additional information about the suspended status reason.
    /// </summary>
    [IsoId("_RTVOI9p-Ed-ak6NoX_4Aeg_-1398166641")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
