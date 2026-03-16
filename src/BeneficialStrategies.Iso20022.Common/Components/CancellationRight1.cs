// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the cancellation right.
/// </summary>
[IsoId("_VMLvDtp-Ed-ak6NoX_4Aeg_396360179")]
[DisplayName("Cancellation Right")]
public record CancellationRight1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VMLvD9p-Ed-ak6NoX_4Aeg_450848807")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required CancellationRight2Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of charge.
    /// </summary>
    [IsoId("_VMLvENp-Ed-ak6NoX_4Aeg_450848826")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
