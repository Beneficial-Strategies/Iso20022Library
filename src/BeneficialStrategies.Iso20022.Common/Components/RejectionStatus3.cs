// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides a rejection reason and additional information.
/// </summary>
[IsoId("_m7VCuStIEeyOa655cLd-DQ")]
[DisplayName("Rejection Status")]
public record RejectionStatus3
{
    /// <summary>
    /// Provides the rejection reason using a code.
    /// </summary>
    [IsoId("_nXDVYStIEeyOa655cLd-DQ")]
    [DisplayName("Rejected Reason")]
    [IsoXmlTag("RjctdRsn")]
    public required RejectionReason68Code RejectedReason { get; init; }

    /// <summary>
    /// Allows to provides additional information to the rejection reason code.
    /// </summary>
    [IsoId("_nXDVYytIEeyOa655cLd-DQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; }
}
