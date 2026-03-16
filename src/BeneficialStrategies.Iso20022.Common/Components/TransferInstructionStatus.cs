// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction status and the reason for the status.
/// </summary>
[IsoId("_U0yittp-Ed-ak6NoX_4Aeg_-1585322239")]
[DisplayName("Transfer Instruction Status")]
public record TransferInstructionStatus
{
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_U0yit9p-Ed-ak6NoX_4Aeg_-1918810133")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferStatus1Code Status { get; init; }

    /// <summary>
    /// Additional information about the status in textual form.
    /// </summary>
    [IsoId("_U0yiuNp-Ed-ak6NoX_4Aeg_-549474831")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
