// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_UUvws9p-Ed-ak6NoX_4Aeg_-1302664464")]
[DisplayName("Acknowledgement Reason")]
public record AcknowledgementReason1
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_UUvwtNp-Ed-ak6NoX_4Aeg_-1655168609")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AcknowledgementReason1Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_UUvwtdp-Ed-ak6NoX_4Aeg_-239667377")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
