// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reason for the in-repair status.
/// </summary>
[IsoId("_RTVOJ9p-Ed-ak6NoX_4Aeg_-363009151")]
[DisplayName("In Repair Status Reason")]
public record InRepairStatusReason3
{
    /// <summary>
    /// Reason for the in repair status.
    /// </summary>
    [IsoId("_RTVOKNp-Ed-ak6NoX_4Aeg_-1745735307")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required InRepairStatusReason1Code Reason { get; init; }

    /// <summary>
    /// Reason of the in repair status.
    /// </summary>
    [IsoId("_RTVOKdp-Ed-ak6NoX_4Aeg_1452658289")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the in-repair status.
    /// </summary>
    [IsoId("_RTVOKtp-Ed-ak6NoX_4Aeg_-1707593315")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Additional information about the in-repair status reason.
    /// </summary>
    [IsoId("_RTe_INp-Ed-ak6NoX_4Aeg_-1023923466")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
