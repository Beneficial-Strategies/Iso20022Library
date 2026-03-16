// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reason for the conditionally accepted status.
/// </summary>
[IsoId("_RTLdJNp-Ed-ak6NoX_4Aeg_-536648388")]
[DisplayName("Conditionally Accepted Status Reason")]
public record ConditionallyAcceptedStatusReason2
{
    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    [IsoId("_RTLdJdp-Ed-ak6NoX_4Aeg_-653993997")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ConditionallyAcceptedStatusReason2Code Reason { get; init; }

    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    [IsoId("_RTLdJtp-Ed-ak6NoX_4Aeg_-607817225")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the conditionally accepted status.
    /// </summary>
    [IsoId("_RTLdJ9p-Ed-ak6NoX_4Aeg_-367107520")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Additional information about the conditionally accepted status reason.
    /// </summary>
    [IsoId("_RTLdKNp-Ed-ak6NoX_4Aeg_1824265125")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
