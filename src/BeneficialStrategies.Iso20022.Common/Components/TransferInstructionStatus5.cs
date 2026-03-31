// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction status.
/// </summary>
[IsoId("_aeWNY1NUEeijdq8ilaxyOA")]
[DisplayName("Transfer Instruction Status")]
public record TransferInstructionStatus5
{
    /// <summary>
    /// Status code.
    /// </summary>
    [IsoId("_avAfg1NUEeijdq8ilaxyOA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferStatus6Code Status { get; init; }

    /// <summary>
    /// Reason for the status.
    /// </summary>
    [IsoId("_avAfhVNUEeijdq8ilaxyOA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Reason { get; init; }
}
