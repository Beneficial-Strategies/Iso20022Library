// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is partially settled.
/// </summary>
[IsoId("_RLuxWdp-Ed-ak6NoX_4Aeg_736788368")]
[DisplayName("Partially Settled Status")]
public record PartiallySettledStatus1
{
    /// <summary>
    /// Reason for the partially settled status.
    /// </summary>
    [IsoId("_RL4iUNp-Ed-ak6NoX_4Aeg_551818539")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required SettledStatusReason1Code Reason { get; init; }

    /// <summary>
    /// Reason for the partially settled status.
    /// </summary>
    [IsoId("_RL4iUdp-Ed-ak6NoX_4Aeg_608153866")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the partially settled status in the report.
    /// </summary>
    [IsoId("_RL4iUtp-Ed-ak6NoX_4Aeg_880591540")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }

    /// <summary>
    /// Additional information about the partially settled status reason.
    /// </summary>
    [IsoId("_RL4iU9p-Ed-ak6NoX_4Aeg_1342405646")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
