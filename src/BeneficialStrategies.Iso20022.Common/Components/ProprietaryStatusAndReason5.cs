// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary status and reason of an instruction or an instruction cancellation.
/// </summary>
[IsoId("_AljAYVhHEeOMYfRGLS0NbA")]
[DisplayName("Proprietary Status And Reason")]
public record ProprietaryStatusAndReason5
{
    /// <summary>
    /// Proprietary identification of the status of the instruction.
    /// </summary>
    [IsoId("_A0uE0VhHEeOMYfRGLS0NbA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required GenericIdentification36 Status { get; init; }

    /// <summary>
    /// Proprietary identification of the reason for the status.
    /// </summary>
    [IsoId("_A0uE01hHEeOMYfRGLS0NbA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ProprietaryReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Additional information about the processed instruction.
    /// </summary>
    [IsoId("_80za9Vj8EeOgwYxfAV02bg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
